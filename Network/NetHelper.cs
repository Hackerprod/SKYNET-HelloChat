using SKYNET;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Web.Script.Serialization;
using XNova_Utils;

public class NetHelper
{
    private static byte[] bytes;

    public static void SendMessage(BaseMessage message)
    {
        try
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.EnableBroadcast = true;

            string json = new JavaScriptSerializer().Serialize(message);

            bytes = Encoding.UTF8.GetBytes(json);
            socket.SendTo(bytes, 0, bytes.Length, SocketFlags.None, new IPEndPoint(IPAddress.Broadcast, 25018));
            socket.Close();

            frmMessage mesage = new frmMessage();
        }
        catch (SocketException)
        {
        }
        catch (Exception ex)
        {

        }
    }

    internal static bool IsSomeNetworkRange(IPAddress iP)
    {
        if (iP == null)
            return false;

        string RemoteIP = iP.ToString();
        string MyIP = modCommon.GetIp();
        try
        {
            if (RemoteIP.Split('.')[0] == MyIP.Split('.')[0])
                if (RemoteIP.Split('.')[1] == MyIP.Split('.')[1])
                    if (RemoteIP.Split('.')[2] == MyIP.Split('.')[2])
                        return true;
        }
        catch { return false; }

        return false;
    }
}