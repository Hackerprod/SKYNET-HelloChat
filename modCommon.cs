using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using XNova_Utils;
using System.Text;
using System.Drawing.Imaging;
using Transparencia;
using SkynetManager;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class modCommon
{
    public static string Dota2Path { get; set; }
    public static string VPKLocation { get; set; }
    public static string TEMP_PATH { get; set; }
    public static int IE_VERSION { get; set; }
    public static string SCREENSHOT_PATH { get; set; }
    public static string HistoryPath { get; set; }
    public static string USERS_PATH { get; set; }

    public static Color Blue = Color.FromArgb(14, 173, 244);

    public static bool CloseSplash = false;
    public static bool ShowMain = false;
    public static frmSplashScreen SplashScreen;
    static frmMain frmMain = null;
    internal static void InitialiceApplication()
    {
        Timer timer = new Timer();
        timer.Interval = 100;
        timer.Tick += Timer_Tick;
        timer.Enabled = true;
        timer.Start();

        Application.Run(new frmSplashScreen());
        Application.Run(new frmMain());
    }

    private static void Timer_Tick(object sender, EventArgs e)
    {
        if (ShowMain && frmMain == null)
        {
            Application.Run(new frmMain());
        }

        if (CloseSplash)
        {
            SplashScreen.Close();
            ((System.Windows.Forms.Timer)sender).Enabled = false;
        }
    }

    public static string GetMacID(IPAddress address)
    {
        try
        {
            var destAddr = BitConverter.ToInt32(address.GetAddressBytes(), 0);
            var srcAddr = BitConverter.ToInt32(System.Net.IPAddress.Any.GetAddressBytes(), 0);
            var macAddress = new byte[6];
            var macAddrLen = macAddress.Length;
            var ret = SendArp(destAddr, srcAddr, macAddress, ref macAddrLen);
            if (ret != 0)
            {
                return "";
            }
            var mac = new PhysicalAddress(macAddress);
            return BitConverter.ToString(macAddress).Replace("-", "");
        }
        catch (Exception)
        {
            return "";
        }

    }
    [System.Runtime.InteropServices.DllImport("Iphlpapi.dll", EntryPoint = "SendARP")]
    private extern static Int32 SendArp(Int32 destIpAddress, Int32 srcIpAddress, byte[] macAddress, ref Int32 macAddressLength);


    public static bool GenerateOnStart = true;
    public static bool OpenDota = false;
    public static bool ActiveSounds = true;
    public static string ClientVersion = "5";
    public static bool NeedUpdate = false;

    static modCommon()
    {

    }
    public static string Win32Path()
    {
        string correctGameFolder = "";
        RegistryKey exeKey = Registry.ClassesRoot.OpenSubKey("dota2\\Shell\\Open\\Command", true);
        if (exeKey != null)
        {
            string exeFile = exeKey.GetValue(null).ToString().Split('"')[1];
            correctGameFolder = Directory.GetParent(exeFile).ToString();

        }
        return correctGameFolder;
    }
    public static void SetPosition(IntPtr Handle, Form form)
    {
        Rectangle rScreen = Screen.GetWorkingArea(Screen.PrimaryScreen.Bounds);
        int yy = checked(rScreen.Height - form.Height - 0);

        SetWindowPos(Handle, -1, checked(rScreen.Width - form.Width), yy, form.Width, form.Height, 16U);
        ShowWindow(Handle, 4);

    }

    [DllImport("user32.dll")]
    protected static extern bool ShowWindow(IntPtr hWnd, int flags);

    [DllImport("user32.dll")]
    protected static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    internal static string FirstUpper(string text)
    {
        string result = "";
        for (int i = 0; i < text.Count(); i++)
        {
            if (i == 0)
                result += text[i].ToString().ToUpper();
            else
                result += text[i].ToString().ToLower();
        }
        return result;
    }

    [DllImport("wininet.dll")]
    private extern static bool InternetGetConnectedState(out int Description, int ReversedValue);
    internal static bool IsCableConnected()
    {
        return InternetGetConnectedState(out int Conn, 0);
    }

    internal static string PreparePrefab(string prefab)
    {
        string result = prefab;
        switch (prefab)
        {
            case "default_item": result = "Default Item"; break;
            case "multikill_banner": result = "multikill banner"; break;
            case "radiantcreeps": result = "creeps"; break;
            case "direcreeps": result = "creeps"; break;
            case "radianttowers": result = "towers"; break;
            case "diretowers": result = "towers"; break;
            case "versus_screen": result = "versus screen"; break;
            case "cursor_pack": result = "cursors"; break;
            case "emoticon_tool": result = "emoticons"; break;
            case "hud_skin": result = "hud skin"; break;
            case "loading_screen": result = "loading"; break;
            default: break;
        }
        return FirstUpper(result);
    }

    public static void Close(Form frm)
    {
        frmMain.frm.Visible = true;
        frmMain.frm.Activate();
    }

    public static void WriteLine(string v, bool loading  = false)
    {
        if (loading)
        {
            //frmMain.frm.MostrarLabel(v);
        }
    }

    public static void Write(string v)
    {
        WriteLine(v);
    }

    internal static bool GetBool(string boolean)
    {
        switch (boolean.ToLower())
        {
            case "1":
                return true;
            case "true":
                return true;
            case "0":
                return false;
            case "false":
                return false;
            default:
                return false;
        }
    }

    internal static void Show(object v = null)
    {
        //if (v == null)
        //    return;
        frmMessage frm = new frmMessage(v.ToString());
        frm.ShowDialog();
    }


    public static SizeF GetTextSize(string text, Font font)
    {
        using (Graphics graphics = Graphics.FromImage((Image)new Bitmap(1, 1)))
            return graphics.MeasureString(text, font);
    }

    public static string GetVideoFileName(string HeroName)
    {
        string FileName = HeroName + ".webm";
        return FileName.Replace(" ", "_");
    }

    public static string GetIp()
    {
        string hostname = Dns.GetHostName();
        IPHostEntry iphe = Dns.GetHostEntry(hostname);
        IPAddress ipaddress = null;
        foreach (IPAddress item in iphe.AddressList)
        {
            if (item.AddressFamily == AddressFamily.InterNetwork)
            {
                ipaddress = item;
            }
        }
        return ipaddress.ToString();
    }
    public static string GetPath()
    {
        string file = Process.GetCurrentProcess().MainModule.FileName;
        FileInfo info = new FileInfo(file);
        return info.DirectoryName;
    }
    internal static List<string> ReadAllLines(string FilePath)
    {
        List<string> result = new List<string>();
        var file = File.ReadAllBytes(FilePath);
        string text = Encoding.Default.GetString(file);
        TextBox structure = new TextBox();
        structure.Text = text;
        for (int i = 0; i < structure.Lines.Count(); i++)
        {
            result.Add(structure.Lines[i]);
        }
        return result;
    }
    internal static void WriteAllLines(string FilePath, List<string> line)
    {
        string content = "";
        for (int i = 0; i < line.Count; i++)
        {
            if (i == line.Count - 1)
            {
                content += line[i];
            }
            else
                content += line[i] + Environment.NewLine;
        }
        var file = Encoding.Default.GetBytes(content);
        FileStream stream = new FileStream(FilePath, FileMode.OpenOrCreate);
        stream.Write(file, 0, file.Length);
        stream.Close();
    }

    public static string ConvertHtmlTotext(string source)
    {
        try
        {
            string result;

            // Remove HTML Development formatting
            // Replace line breaks with space
            // because browsers inserts space
            result = source.Replace("\r", " ");
            // Replace line breaks with space
            // because browsers inserts space
            result = result.Replace("\n", " ");
            // Remove step-formatting
            result = result.Replace("\t", string.Empty);
            // Remove repeating spaces because browsers ignore them
            result = System.Text.RegularExpressions.Regex.Replace(result,
                                                                  @"( )+", " ");

            // Remove the header (prepare first by clearing attributes)
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*head([^>])*>", "<head>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"(<( )*(/)( )*head( )*>)", "</head>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(<head>).*(</head>)", string.Empty,
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // remove all scripts (prepare first by clearing attributes)
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*script([^>])*>", "<script>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"(<( )*(/)( )*script( )*>)", "</script>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            //result = System.Text.RegularExpressions.Regex.Replace(result,
            //         @"(<script>)([^(<script>\.</script>)])*(</script>)",
            //         string.Empty,
            //         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"(<script>).*(</script>)", string.Empty,
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // remove all styles (prepare first by clearing attributes)
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*style([^>])*>", "<style>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"(<( )*(/)( )*style( )*>)", "</style>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(<style>).*(</style>)", string.Empty,
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // insert tabs in spaces of <td> tags
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*td([^>])*>", "\t",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // insert line breaks in places of <BR> and <LI> tags
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*br( )*>", "\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*li( )*>", "\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // insert line paragraphs (double line breaks) in place
            // if <P>, <DIV> and <TR> tags
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*div([^>])*>", "\r\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*tr([^>])*>", "\r\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*p([^>])*>", "\r\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // Remove remaining tags like <a>, links, images,
            // comments etc - anything that's enclosed inside < >
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<[^>]*>", string.Empty,
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // replace special characters:
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @" ", " ",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&bull;", " * ",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&lsaquo;", "<",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&rsaquo;", ">",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&trade;", "(tm)",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&frasl;", "/",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&lt;", "<",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&gt;", ">",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&copy;", "(c)",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&reg;", "(r)",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            // Remove all others. More can be added, see
            // http://hotwired.lycos.com/webmonkey/reference/special_characters/
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&(.{2,6});", string.Empty,
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // for testing
            //System.Text.RegularExpressions.Regex.Replace(result,
            //       this.txtRegex.Text,string.Empty,
            //       System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            // make line breaking consistent
            result = result.Replace("\n", "\r");

            // Remove extra line breaks and tabs:
            // replace over 2 breaks with 2 and over 4 tabs with 4.
            // Prepare first to remove any whitespaces in between
            // the escaped characters and remove redundant tabs in between line breaks
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(\r)( )+(\r)", "\r\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(\t)( )+(\t)", "\t\t",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(\t)( )+(\r)", "\t\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(\r)( )+(\t)", "\r\t",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            // Remove redundant tabs
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(\r)(\t)+(\r)", "\r\r",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            // Remove multiple tabs following a line break with just one tab
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(\r)(\t)+", "\r\t",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            // Initial replacement target string for line breaks
            string breaks = "\r\r\r";
            // Initial replacement target string for tabs
            string tabs = "\t\t\t\t\t";
            for (int index = 0; index < result.Length; index++)
            {
                result = result.Replace(breaks, "\r\r");
                result = result.Replace(tabs, "\t\t\t\t");
                breaks = breaks + "\r";
                tabs = tabs + "\t";
            }

            // That's it.
            return result;
        }
        catch
        {
            MessageBox.Show("Error");
            return source;
        }

    }

    public static Bitmap ChangeOpacity(Image img, float opacityvalue)
    {
        Bitmap bitmap4 = default(Bitmap);
        try
        {
            Bitmap bitmap = new Bitmap(img.Width, img.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            ColorMatrix newColorMatrix = new ColorMatrix
            {
                Matrix33 = opacityvalue
            };
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(newColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();
            bitmap4 = bitmap;
            return bitmap4;
        }
        catch (Exception ex)
        {
            Exception ex2 = ex;
            return bitmap4;
        }
    }
    public static string GetUniqueAlphaNumericID()
    {
        string str1 = "";
        try
        {
            //Random Marcado por mi

            string str2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            short num1 = checked((short)str2.Length);
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder();
            int num2 = 1;
            do
            {
                int startIndex = random.Next(0, (int)num1);
                stringBuilder.Append(str2.Substring(startIndex, 1));
                checked { ++num2; }
            }
            while (num2 <= 6);
            stringBuilder.Append(DateAndTime.Now.ToString("HHmmss"));
            str1 = stringBuilder.ToString();
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            WriteLog.Save(ex);
            ProjectData.ClearProjectError();
        }
        return str1;
    }
}
