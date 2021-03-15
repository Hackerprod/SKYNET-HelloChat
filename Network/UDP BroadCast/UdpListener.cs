using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace SKYNET
{
    public class UdpListener
    {
        public IPEndPoint LocalEndPoint { get; private set; }

        public UdpListener(IPAddress ip, int port)
        {
            this.Port = port;
            this._localEndPoint = new IPEndPoint(ip, port);
            this._running = false;
        }

        public UdpListener(int port)
        {
            this.Port = port;
            this._localEndPoint = new IPEndPoint(IPAddress.Any, port);
            this._running = false;
        }

        public int Port { get; }

        private void CreateSocket()
        {
            this._socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            this._socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            if (this.EnableBroadcast)
            {
                this._socket.EnableBroadcast = true;
            }
            this._socket.Bind(this._localEndPoint);
            LocalEndPoint = (IPEndPoint)_socket.LocalEndPoint;
        }

        public event UdpListener.PacketReceivedDelegate PacketReceived;

        public event UdpListener.ExceptionThrownDelegate ExceptionThrown;

        public bool EnableBroadcast { get; set; }

        protected void OnPacketReceived(IPEndPoint endPoint, MemoryStream dataStream)
        {
            UdpListener.PacketReceivedDelegate packetReceived = this.PacketReceived;
            if (packetReceived == null)
            {
                return;
            }
            packetReceived(this, new PacketReceivedEventArgs(endPoint, dataStream));
        }

        protected virtual void OnExceptionThrown(ExceptionEventArgs e)
        {
            UdpListener.ExceptionThrownDelegate exceptionThrown = this.ExceptionThrown;
            if (exceptionThrown == null)
            {
                return;
            }
            exceptionThrown(this, e);
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                Socket socket = (Socket)ar.AsyncState;
                EndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
                if (this._running)
                {
                    int num = socket.EndReceiveFrom(ar, ref endPoint);
                    if (num == 0 && this._running)
                    {
                        this.StartReceiving(false);
                    }
                    else if (this._running)
                    {
                        using (MemoryStream stream = RecyclableStreams.Manager.GetStream("udp_listener_packet", this._buffer, 0, num))
                        {
                            this.OnPacketReceived((IPEndPoint)endPoint, stream);
                        }
                        this.StartReceiving(false);
                    }
                }
            }
            catch (ObjectDisposedException)
            {
                this.StartReceiving(true);
            }
            catch (SocketException)
            {
                this.StartReceiving(true);
            }
            catch (Exception ex)
            {
                this.OnExceptionThrown(new ExceptionEventArgs(ex));
                this.StartReceiving(false);
            }
        }

        public void Send(byte[] data, IPEndPoint endpoint)
        {
            try
            {
                this._socket.BeginSendTo(data, 0, data.Length, SocketFlags.None, endpoint, delegate (IAsyncResult ar)
                {
                    try
                    {
                        this._socket.EndSendTo(ar);
                    }
                    catch
                    {
                    }
                }, null);
            }
            catch (ObjectDisposedException)
            {
            }
            catch (Exception ex)
            {
                this.OnExceptionThrown(new ExceptionEventArgs(ex));
            }
        }

        public void Send(byte[] data, int offset, int length, IPEndPoint endpoint)
        {
            try
            {
                this._socket.BeginSendTo(data, offset, length, SocketFlags.None, endpoint, delegate (IAsyncResult ar)
                {
                    try
                    {
                        this._socket.EndSendTo(ar);
                    }
                    catch
                    {
                    }
                }, null);
            }
            catch (ObjectDisposedException)
            {
            }
            catch (Exception ex)
            {
                this.OnExceptionThrown(new ExceptionEventArgs(ex));
            }
        }

        public bool Start()
        {
            if (this._running)
            {
                return false;
            }
            this._running = true;
            try
            {
                this.CreateSocket();
                this.StartReceiving(false);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void StartReceiving(bool restart = false)
        {
            if (!this._running)
            {
                return;
            }
            try
            {
                if (restart)
                {
                    try
                    {
                        this._socket.Close();
                    }
                    catch
                    {
                    }
                    this.CreateSocket();
                }
                EndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
                this._socket.BeginReceiveFrom(this._buffer, 0, this._buffer.Length, SocketFlags.None, ref endPoint, new AsyncCallback(this.ReceiveCallback), this._socket);
            }
            catch (ObjectDisposedException)
            {
                this.StartReceiving(true);
            }
            catch (SocketException)
            {
                this.StartReceiving(true);
            }
            catch (Exception ex)
            {
                this.OnExceptionThrown(new ExceptionEventArgs(ex));
                this.StartReceiving(true);
            }
        }

        public void Stop()
        {
            if (!this._running)
            {
                return;
            }
            this._running = false;
            try
            {
                this._socket.Shutdown(SocketShutdown.Receive);
                this._socket.Close();
                this._socket.Dispose();
            }
            catch
            {
            }
        }

        private readonly byte[] _buffer = new byte[4096];

        private readonly IPEndPoint _localEndPoint;

        private bool _running;

        private Socket _socket;

        public delegate void ExceptionThrownDelegate(object sender, ExceptionEventArgs e);

        public delegate void PacketReceivedDelegate(object sender, PacketReceivedEventArgs e);
    }
}