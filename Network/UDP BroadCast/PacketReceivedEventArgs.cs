using System;
using System.IO;
using System.Net;

namespace SKYNET
{
    public class PacketReceivedEventArgs : EventArgs
    {
        public IPEndPoint EndPoint { get; private set; }

        public MemoryStream Stream { get; private set; }

        public PacketReceivedEventArgs(IPEndPoint endpoint, MemoryStream stream)
        {
            this.EndPoint = endpoint;
            this.Stream = stream;
        }
    }
}