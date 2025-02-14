using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HoaPhatApp.Devices
{
    internal class Client
    {
        /// <summary>
        /// The receiver unique id
        /// </summary>
        public string ID { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public IPEndPoint IPEndPoint { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        private Socket socket;

        public Client(Socket accepted)
        {
            socket = accepted;
            ID = Guid.NewGuid().ToString();
            IPEndPoint = (IPEndPoint)socket.RemoteEndPoint;
            socket.BeginReceive(new byte[] { 0 }, 0, 0, 0, CallBack, null);
        }

        /*
         this be call if have a message from client send to server (or disconnected)
         */
        void CallBack(IAsyncResult iar)
        {
            try
            {
                socket.EndReceive(iar);
                byte[] buffer = new byte[8192]; //application buffer
                int rec = socket.Receive(buffer, buffer.Length, 0); // Copy the received data from socket buffer to application buffer
                if (rec == 0) // that mean client disconnected
                {
                    Close();
                    if (Disconnected != null)
                    {
                        Disconnected(this); // Call event disconnected
                    }
                }
                else if (rec < buffer.Length)
                {
                    Array.Resize<byte>(ref buffer, rec); // resize the app buffer 
                    if (Received != null)
                    {
                        Received(this, buffer); // Call event received
                    }
                    socket.BeginReceive(new byte[] { 0 }, 0, 0, 0, CallBack, null);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Close();

                if (Disconnected != null)
                {
                    Disconnected(this); // this one to know what is the client disconnected
                }
            }
        }
        /// <summary>
        /// Close socket
        /// </summary>
        public void Close()
        {
            socket.Close();
            socket.Dispose();
        }

        public delegate void ClientReceivedHandler(Client sender, byte[] data);
        public delegate void ClientDisconnectedHandler(Client sender);
        public event ClientReceivedHandler Received;
        public event ClientDisconnectedHandler Disconnected;
    }
}
