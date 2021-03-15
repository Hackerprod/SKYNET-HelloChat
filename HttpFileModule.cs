using HttpServer;
using HttpServer.HttpModules;
using HttpServer.Sessions;
using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

/*public class HttpFileModule : FileModule
{
    
    private class ThumbLoadCallback
    {
        public IHttpRequest req;

        public IHttpResponse res;

        public ThumbLoadCallback(IHttpRequest request, IHttpResponse response)
        {
            req = request;
            res = response;
        }

        public void OnThumbLoadComplete(object sender, string path, Bitmap bmp)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                bmp.Save(memoryStream, ImageFormat.Png);
                byte[] array = memoryStream.ToArray();
                res.ContentLength = array.Length;
                res.SendHeaders();
                res.SendBody(array, 0, array.Length);
                modCommon.Instance.Debug("thumb sent");
            }
            catch (Exception ex)
            {
                modCommon.Instance.Error(ex.Message);
            }
        }
    }

    private static readonly string[] DefaultForbiddenChars = new string[0];

    private string[] forbiddenChars;

    public override string[] ForbiddenChars
    {
        get
        {
            return forbiddenChars;
        }
        set
        {
            forbiddenChars = value;
        }
    }

    public HttpFileModule(string baseUri, string basePath, bool useLastModifiedHeader)
        : base(baseUri, basePath, useLastModifiedHeader)
    {
        forbiddenChars = DefaultForbiddenChars;
    }

    public HttpFileModule(string baseUri, string basePath)
        : base(baseUri, basePath, useLastModifiedHeader: false)
    {
        forbiddenChars = DefaultForbiddenChars;
    }

    protected override string GetPath(Uri uri)
    {
        string text = HttpUtility.UrlDecode(uri.LocalPath);
        text = text.TrimStart('/');
        return text.Replace('/', Path.DirectorySeparatorChar);
    }

    public override bool Process(IHttpRequest request, IHttpResponse response, IHttpSession session)
    {
        NameValueCollection headers = request.Headers;
        bool flag = false;
        string name = "fileseq";
        if (headers[name] != null)
        {
            flag = true;
        }
        if (flag)
        {
            int fileSeq = int.Parse(headers[name]);
            if (headers["downloader_version"] == null)
            {
                response.Status = HttpStatusCode.InternalServerError;
                string s = "Your Zapya's version is too low.";
                byte[] bytes = Encoding.UTF8.GetBytes(s);
                response.Body.Write(bytes, 0, bytes.Length);
                return true;
            }
            int num = int.Parse(headers["downloader_version"]);
            if (num < 2)
            {
                response.Status = HttpStatusCode.InternalServerError;
                string s2 = "Your Zapya's version is too low.";
                byte[] bytes2 = Encoding.UTF8.GetBytes(s2);
                response.Body.Write(bytes2, 0, bytes2.Length);
                return true;
            }
            return ProcessDirRequest(request, response, session, num, fileSeq);
        }
        return ProcessFileRequest(request, response, session);
    }

    private bool ProcessFileRequest(IHttpRequest request, IHttpResponse response, IHttpSession session)
    {
        string uriString;
        if ((uriString = ParseRequest(request)) != null)
        {
            try
            {
                request.Uri = new Uri(uriString);
                string text = request.UriPath.ToString();
                if (text.Contains("/media/db/thumb/"))
                {
                    SendThumb(request, response);
                    response.Disconnect();
                    return true;
                }
                if (text.Contains("/media/db/play/"))
                {
                    text.Replace("/media/db/play/", "/media/db/fetch/");
                    response.Status = HttpStatusCode.PartialContent;
                    response.AddHeader("TransferMode.DLNA.ORG", "Streaming");
                }
                else if (text.Contains("DmContainPecialChar") && text.Contains("/media/db/fetch/"))
                {
                    SendFilesWithSpecialChar(request, response);
                    return true;
                }
            }
            catch (Exception ex)
            {
                modCommon.Instance.Error(ex.Message);
            }
            modCommon.Instance.Info($"New request: {request.Uri.ToString()}");
            return base.Process(request, response, session);
        }
        modCommon.Instance.Error("Request is not handled");
        return false;
    }

    private bool ProcessDirRequest(IHttpRequest request, IHttpResponse response, IHttpSession session, int downloaderVersion, int fileSeq)
    {
        string uriString;
        if ((uriString = ParseRequest(request)) != null)
        {
            try
            {
                request.Uri = new Uri(uriString);
                long offset = 0L;
                if (!string.IsNullOrEmpty(request.Headers["Range"]))
                {
                    string text = request.Headers["Range"].ToLower();
                    string text2 = "bytes=";
                    if (text.StartsWith(text2))
                    {
                        text = text.Substring(text2.Length);
                    }
                    if (!string.IsNullOrEmpty(text) && text.Contains("-"))
                    {
                        string[] array = text.Split('-');
                        try
                        {
                            offset = long.Parse(array[0]);
                        }
                        catch
                        {
                        }
                        try
                        {
                            long.Parse(array[1]);
                        }
                        catch
                        {
                        }
                    }
                }
                modCommon.Instance.Info($"New request: {request.Uri.ToString()}");
                response.AddHeader("uploader_version", "2");
                response.Connection = ConnectionType.Close;
                response.SendHeaders();
                SendDir(request, response, fileSeq, offset);
                response.Disconnect();
                return true;
            }
            catch (Exception ex)
            {
                modCommon.Instance.Error(ex.Message);
                return false;
            }
        }
        return false;
    }

    private string ParseRequest(IHttpRequest request)
    {
        string absoluteUri = request.Uri.AbsoluteUri;
        foreach (string header in request.Headers)
        {
            Console.WriteLine($"{header}: {request.Headers[header]}");
        }
        string pattern = "(.+)/media/db/(thumb|fetch|play|file)/(video|image|audio|app|folder)(/.+)";
        Match match = Regex.Match(absoluteUri, pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
        if (match.Success)
        {
            return match.Groups[1].ToString() + match.Groups[4].ToString().Substring(0, match.Groups[4].ToString().LastIndexOf('/'));
        }
        modCommon.Instance.Error($"Unknown Uri: {absoluteUri}");
        return null;
    }

    private void WriteFileData(DmTransferHistory transfer, FileStream fileStream, IHttpResponse response, int bufSize, long offset, long length)
    {
        byte[] buffer = new byte[bufSize];
        long num = length;
        fileStream.Seek(offset, SeekOrigin.Begin);
        while (num > 0 && transfer.Status != TransferStatus.Delete && transfer.Status != TransferStatus.Wait && transfer.Status != TransferStatus.DisConnect)
        {
            int num2 = 0;
            try
            {
                num2 = fileStream.Read(buffer, 0, bufSize);
            }
            catch (Exception ex)
            {
                modCommon.Instance.Debug(ex.Message);
            }
            if (num2 <= 0)
            {
                break;
            }
            response.SendBody(buffer, 0, num2);
            num -= num2;
            transfer.TransferBytes += num2;
            int num3 = (int)((double)transfer.TransferBytes / (double)transfer.TotalBytes * 100.0);
            if (num3 > 100)
            {
                num3 = 100;
            }
            transfer.Progress = num3;
        }
    }

    private void WriteFileData(FileStream fileStream, IHttpResponse response, int bufSize, long offset, long length)
    {
        byte[] buffer = new byte[bufSize];
        long num = length;
        fileStream.Seek(offset, SeekOrigin.Begin);
        while (num > 0)
        {
            int num2 = fileStream.Read(buffer, 0, bufSize);
            if (num2 <= 0)
            {
                break;
            }
            response.SendBody(buffer, 0, num2);
            num -= num2;
        }
    }

    public override void Send(IHttpRequest request, IHttpResponse response, FileStream fileStream, int bufSize, long offset, long length)
    {
        bool flag = false;
        if (request.UriPath.ToString().Contains("DmContainPecialChar"))
        {
            flag = true;
        }
        string name = fileStream.Name;
        if (response != null && fileStream != null && bufSize > 0 && length > 0)
        {
            string ipAddr = request.RemoteEndPoint.Address.ToString();
            DmUserHandle dmUserHandle = DmUserHandleManager.Instance.FindUserByIpAddress(ipAddr);
            if (dmUserHandle != null)
            {
                offset = ((offset >= 0 && offset < fileStream.Length) ? offset : 0);
                modCommon.Instance.Info($"{fileStream.Name} -> {dmUserHandle.DecodedName}@{dmUserHandle.IpAddr.ToString()}");
                DmTransferHistory dmTransferHistory = null;
                string text = request.UriPath.ToString();
                if (text.Contains("/media/db/play/"))
                {
                    text.Replace("/media/db/play/", "/media/db/fetch/");
                }
                text = text.Replace("/", "\\");
                DmTransferHistory[] allTransferHistory = DmTransferHistoryManager.Instance.GetAllTransferHistory();
                foreach (DmTransferHistory dmTransferHistory2 in allTransferHistory)
                {
                    if (dmTransferHistory2.TransType == TransferType.SendFile && dmTransferHistory2.RemoteNick == dmUserHandle.DecodedName && text.Contains(dmTransferHistory2.TargetPath))
                    {
                        dmTransferHistory = dmTransferHistory2;
                        break;
                    }
                }
                if (dmTransferHistory == null)
                {
                    if (request.UriPath.ToString().Contains("/media/db/file/"))
                    {
                        try
                        {
                            WriteFileData(fileStream, response, bufSize, offset, length);
                        }
                        catch (Exception ex)
                        {
                            modCommon.Instance.Error(ex.Message);
                        }
                        finally
                        {
                            fileStream.Close();
                        }
                    }
                }
                else
                {
                    try
                    {
                        dmTransferHistory.TransferBytes = offset;
                        dmTransferHistory.Status = TransferStatus.Running;
                        WriteFileData(dmTransferHistory, fileStream, response, bufSize, offset, length);
                    }
                    catch (Exception ex2)
                    {
                        modCommon.Instance.Error(ex2.Message);
                        dmTransferHistory.Status = TransferStatus.Wait;
                    }
                    finally
                    {
                        fileStream.Close();
                    }
                    if (dmTransferHistory.TransferBytes >= dmTransferHistory.TotalBytes)
                    {
                        dmTransferHistory.Status = TransferStatus.Success;
                        dmTransferHistory.Progress = 100;
                        if (flag)
                        {
                            dmTransferHistory.TargetPath = name;
                            dmTransferHistory.Key = name;
                        }
                        TransferApi.TransferItem transferItem = new TransferApi.TransferItem(dmTransferHistory.Lkey, dmTransferHistory.FileName, dmTransferHistory.TransferBytes, dmTransferHistory.OwnerDeviceId, dmTransferHistory.RemoteDeviceId, 0, 1);
                        transferItem.OwnerZid = ApiConfig.Instance.UserId;
                        transferItem.RecvZid = "0000";
                        TransferLogManager.Instance.AddTransferItem(transferItem);
                    }
                    DmTransferManager.Instance.UpdateTask(dmTransferHistory);
                    dmTransferHistory.TransferEnd(dmTransferHistory);
                    modCommon.Instance.Info($"Sending {fileStream.Name} to {dmUserHandle.DecodedName}@{dmUserHandle.IpAddr.ToString()}. bytes {dmTransferHistory.TransferBytes}");
                }
            }
        }
    }

    private void SendFilesWithSpecialChar(IHttpRequest request, IHttpResponse response)
    {
        string ipAddr = request.RemoteEndPoint.Address.ToString();
        DmUserHandle dmUserHandle = DmUserHandleManager.Instance.FindUserByIpAddress(ipAddr);
        string text = GetPath(request.Uri);
        if (text.EndsWith("\\"))
        {
            text = text.Substring(0, text.Length - 1);
        }
        if (text.Contains("DmContainPecialChar"))
        {
            text = text.Replace("DmContainPecialChar", "");
        }
        DmDirCacheFile dmDirCacheFile = new DmDirCacheFile();
        dmDirCacheFile.ReadFile(dmUserHandle.UserProfile.Imei, text);
        modCommon.Instance.Info($"{text} -> {dmUserHandle.DecodedName}@{dmUserHandle.IpAddr.ToString()}");
        DmDirCacheItem item = default(DmDirCacheItem);
        dmDirCacheFile.GetItem(0, ref item);
        FileStream fileStream = new FileStream(item.filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        if (!string.IsNullOrEmpty(request.Headers["if-Modified-Since"]))
        {
            DateTime t = DateTime.Parse(request.Headers["if-Modified-Since"]).ToUniversalTime();
            DateTime dateTime = File.GetLastWriteTime(item.filePath).ToUniversalTime();
            dateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, DateTimeKind.Utc);
            if (dateTime > t)
            {
                response.Status = HttpStatusCode.NotModified;
            }
        }
        long num = 0L;
        long num2 = 0L;
        if (!string.IsNullOrEmpty(request.Headers["Range"]))
        {
            string text2 = request.Headers["Range"].ToLower();
            string text3 = "bytes=";
            if (text2.StartsWith(text3))
            {
                text2 = text2.Substring(text3.Length);
            }
            if (!string.IsNullOrEmpty(text2) && text2.Contains("-"))
            {
                string[] array = text2.Split('-');
                try
                {
                    num = long.Parse(array[0]);
                }
                catch
                {
                }
                try
                {
                    num2 = long.Parse(array[1]);
                }
                catch
                {
                }
            }
        }
        if (num2 == 0)
        {
            num2 = fileStream.Length - 1;
        }
        if (num < fileStream.Length)
        {
            response.ContentLength = num2 - num + 1;
            string value = $"bytes {num}-{num2}/{fileStream.Length}";
            response.AddHeader("Content-Range", value);
            response.SendHeaders();
            if (request.Method != "Headers" && response.Status != HttpStatusCode.NotModified)
            {
                Send(request, response, fileStream, 8192, num, response.ContentLength);
            }
            dmDirCacheFile.DeleteFile();
        }
    }

    public void SendDir(IHttpRequest request, IHttpResponse response, int seq, long offset)
    {
        string ipAddr = request.RemoteEndPoint.Address.ToString();
        DmUserHandle dmUserHandle = DmUserHandleManager.Instance.FindUserByIpAddress(ipAddr);
        bool flag = false;
        if (dmUserHandle != null)
        {
            string text = GetPath(request.Uri);
            if (text.EndsWith("\\"))
            {
                text = text.Substring(0, text.Length - 1);
            }
            if (text.Contains("DmContainPecialChar"))
            {
                text = text.Replace("DmContainPecialChar", "");
                flag = true;
            }
            DmDirCacheFile dmDirCacheFile = new DmDirCacheFile();
            dmDirCacheFile.ReadFile(dmUserHandle.UserProfile.Imei, text);
            string text2 = null;
            modCommon.Instance.Info($"{text} -> {dmUserHandle.DecodedName}@{dmUserHandle.IpAddr.ToString()}");
            DmTransferHistory dmTransferHistory = null;
            DmTransferHistory[] allTransferHistory = DmTransferHistoryManager.Instance.GetAllTransferHistory();
            foreach (DmTransferHistory dmTransferHistory2 in allTransferHistory)
            {
                if (dmTransferHistory2.TransType == TransferType.SendFile && dmTransferHistory2.RemoteNick == dmUserHandle.DecodedName && text == dmTransferHistory2.TargetPath)
                {
                    dmTransferHistory = dmTransferHistory2;
                    break;
                }
            }
            if (dmTransferHistory == null)
            {
                modCommon.Instance.Error("transfer is null");
            }
            else if (seq < 0 || seq >= dmDirCacheFile.GetCount())
            {
                modCommon.Instance.Error("seq is invalid. " + seq);
            }
            else
            {
                try
                {
                    string zapyaOSType = dmUserHandle.UserProfile.ZapyaOSType;
                    dmTransferHistory.Status = TransferStatus.Running;
                    dmTransferHistory.FileSeqInDir = seq;
                    long num = offset;
                    do
                    {
                        DmDirCacheItem item = default(DmDirCacheItem);
                        if (!dmDirCacheFile.GetItem(dmTransferHistory.FileSeqInDir, ref item))
                        {
                            modCommon.Instance.Error("seq is not correct. " + seq);
                            dmTransferHistory.Status = TransferStatus.Failed;
                            break;
                        }
                        if (Directory.Exists(item.filePath))
                        {
                            DmDirFileHeader dmDirFileHeader = new DmDirFileHeader();
                            dmDirFileHeader.FileSeq = dmTransferHistory.FileSeqInDir;
                            dmDirFileHeader.FileName = ToHeaderPath(text, item.filePath, zapyaOSType);
                            dmDirFileHeader.FileLength = 0L;
                            dmDirFileHeader.DirEnd = false;
                            dmDirFileHeader.IsDir = true;
                            response.SendBody(dmDirFileHeader.ToBytes());
                            num = 0L;
                        }
                        else if (File.Exists(item.filePath))
                        {
                            FileInfo fileInfo = new FileInfo(item.filePath);
                            DmDirFileHeader dmDirFileHeader2 = new DmDirFileHeader();
                            dmDirFileHeader2.FileSeq = dmTransferHistory.FileSeqInDir;
                            if (item.fileName == "" || item.fileName == null)
                            {
                                dmDirFileHeader2.FileName = ToHeaderPath(text, item.filePath, zapyaOSType);
                            }
                            else
                            {
                                dmDirFileHeader2.FileName = '/' + item.fileName;
                                text2 = item.filePath;
                            }
                            dmDirFileHeader2.FileLength = fileInfo.Length - num;
                            dmDirFileHeader2.DirEnd = false;
                            dmDirFileHeader2.IsDir = false;
                            response.SendBody(dmDirFileHeader2.ToBytes());
                            if (dmDirFileHeader2.FileLength > 0)
                            {
                                FileStream fileStream = new FileStream(item.filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                                WriteFileData(dmTransferHistory, fileStream, response, 10240, num, dmDirFileHeader2.FileLength);
                            }
                            num = 0L;
                        }
                        else
                        {
                            num = 0L;
                            modCommon.Instance.Error(item.filePath + " deleted.");
                        }
                        dmTransferHistory.FileSeqInDir++;
                    }
                    while (dmTransferHistory.FileSeqInDir < dmDirCacheFile.GetCount());
                    if (dmTransferHistory.Status == TransferStatus.Running && dmTransferHistory.FileSeqInDir >= dmDirCacheFile.GetCount())
                    {
                        DmDirFileHeader dmDirFileHeader3 = new DmDirFileHeader();
                        dmDirFileHeader3.FileSeq = dmTransferHistory.FileSeqInDir;
                        dmDirFileHeader3.FileName = "";
                        dmDirFileHeader3.FileLength = 0L;
                        dmDirFileHeader3.DirEnd = true;
                        dmDirFileHeader3.IsDir = true;
                        response.SendBody(dmDirFileHeader3.ToBytes());
                        dmTransferHistory.Status = TransferStatus.Success;
                    }
                }
                catch (Exception ex)
                {
                    modCommon.Instance.Error(ex.Message + ex.StackTrace);
                    dmTransferHistory.Status = TransferStatus.Failed;
                }
                if (dmTransferHistory.Status == TransferStatus.Success)
                {
                    dmDirCacheFile.DeleteFile();
                    TransferApi.TransferItem transferItem = new TransferApi.TransferItem(dmTransferHistory.Lkey, dmTransferHistory.FileName, dmTransferHistory.TransferBytes, dmTransferHistory.OwnerDeviceId, dmTransferHistory.RemoteDeviceId, 0, 1);
                    transferItem.OwnerZid = ApiConfig.Instance.UserId;
                    transferItem.RecvZid = "0000";
                    TransferLogManager.Instance.AddTransferItem(transferItem);
                    if (flag)
                    {
                        DmDirCacheItem item2 = default(DmDirCacheItem);
                        dmDirCacheFile.GetItem(0, ref item2);
                        dmTransferHistory.TargetPath = item2.filePath;
                        dmTransferHistory.Key = item2.filePath;
                    }
                    if (text2 != null)
                    {
                        dmTransferHistory.TargetPath = text2;
                    }
                }
                DmTransferManager.Instance.UpdateTask(dmTransferHistory);
                dmTransferHistory.TransferEnd(dmTransferHistory);
                modCommon.Instance.Info($"Sending {text} to {dmUserHandle.DecodedName}@{dmUserHandle.IpAddr.ToString()}. bytes {dmTransferHistory.TransferBytes}");
            }
        }
    }

    private string ToHeaderPath(string dirToSend, string fileToSend, string targetOS)
    {
        int num = dirToSend.LastIndexOf("\\");
        string str = dirToSend.Substring(num + 1);
        string text = fileToSend.Substring(dirToSend.Length);
        if (text.StartsWith("\\"))
        {
            text = text.Substring(1);
        }
        text = str + "\\" + text;
        if (!targetOS.Contains("Windows"))
        {
            text = text.Replace("\\", "/");
        }
        return text;
    }

    private void SendThumb(IHttpRequest request, IHttpResponse response)
    {
        string ipAddr = request.RemoteEndPoint.Address.ToString();
        DmUserHandle dmUserHandle = DmUserHandleManager.Instance.FindUserByIpAddress(ipAddr);
        if (dmUserHandle != null)
        {
            string path = GetPath(request.Uri);
            modCommon.Instance.Info($"thumb: {path} -> {dmUserHandle.DecodedName}@{dmUserHandle.IpAddr.ToString()}");
            if (!File.Exists(path))
            {
                response.Status = HttpStatusCode.NotFound;
                response.Send();
            }
            else
            {
                try
                {
                    ThumbLoadCallback cb = new ThumbLoadCallback(request, response);
                    ThumbManager.Instance.LoadFileThumbAsync(path, cb);
                }
                catch (Exception ex)
                {
                    modCommon.Instance.Error(ex.Message);
                }
            }
        }
    }
}
*/