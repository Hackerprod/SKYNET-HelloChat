using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using SKYNET.Common;
using System.Web.Script.Serialization;
using SKYNET.Chat;

namespace SKYNET
{
    public class DiscoveryServer 
    {
        IPAddress IpAddress;
        public IPEndPoint LocalEndPoint { get; set; }

        public string Name
        {
            get
            {
                return "Discovery";
            }
        }

        public ServiceStatus Status { get; set; }

        private void OnPacketReceived(object sender, PacketReceivedEventArgs e)
        {
            MessageProcessor.ProcessMessagePayload(e.Stream.ToArray(), e.EndPoint);
        }
        public static IPAddress GetSubnetMask(IPAddress address)
        {
            NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            for (int i = 0; i < allNetworkInterfaces.Length; i++)
            {
                foreach (UnicastIPAddressInformation unicastIPAddressInformation in allNetworkInterfaces[i].GetIPProperties().UnicastAddresses)
                {
                    if (unicastIPAddressInformation.Address.AddressFamily == AddressFamily.InterNetwork && address.Equals(unicastIPAddressInformation.Address))
                    {
                        return unicastIPAddressInformation.IPv4Mask;
                    }
                }
            }
            throw new ArgumentException(string.Format("Can't find subnetmask for IP address '{0}'", address));
        }

        public bool Start()
        {
            try
            {
                this.udpListener_0 = new UdpListener(IpAddress, 25018);
                this.udpListener_0.EnableBroadcast = true;
                this.udpListener_0.PacketReceived += this.OnPacketReceived;
                this.udpListener_0.Start();
                this.Status = ServiceStatus.Online;

                LocalEndPoint = udpListener_0.LocalEndPoint;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public void Stop()
        {
            if (this.Status != ServiceStatus.Online)
            {
                return;
            }
            this.Status = ServiceStatus.Shuttingdown;
            try
            {
                this.udpListener_0.Stop();
            }
            catch
            {
            }
            this.Status = ServiceStatus.Offline;
        }

        public DiscoveryServer()
        {
            IpAddress = IPAddress.Parse(modCommon.GetIp());
        }

        private UdpListener udpListener_0;


        private IPAddress ipaddress_0;
        public void Disconnect()
        {
            Small_Message small = new Small_Message();
            small.MessageType = MessageType.LogOut;
            frmMain.Transmit(small);

        }
    }
}
