using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HoaPhatApp.TCPServer
{
    internal class Listener
    {
        Socket socket;
        ToolStripStatusLabel lbServerStatus = null;

        public bool Listening
        {
            get;
            private set;
        }
        public int Port
        {
            get;
            private set;
        }

        public Listener(int port, ToolStripStatusLabel lb)
        {
            this.lbServerStatus = lb;

            Port = port;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            if (Listening)
            {
                return;
            }
            socket.Bind(new IPEndPoint(0, Port));
            socket.Listen(0);
            socket.BeginAccept(CallBack, null);
            Listening = true;

            this.lbServerStatus.Text = "Listenning";
            this.lbServerStatus.ForeColor = Color.Green;
            this.lbServerStatus.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        public void Stop()
        {
            if (!Listening)
            {
                return;
            }
            socket.Close();
            socket.Dispose();
            this.lbServerStatus.Text = "In active";
            this.lbServerStatus.ForeColor = Color.Red;
            this.lbServerStatus.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        /*
         this be call if have a client connected to server
         */
        void CallBack(IAsyncResult iar)
        {
            try
            {
                Socket socket = this.socket.EndAccept(iar); // socket accepted ( this is client)
                if (SocketAccepted != null)
                {
                    SocketAccepted(socket); // Call event socket accepted
                }
                this.socket.BeginAccept(CallBack, null);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public delegate void SocketAcceptedHandler(Socket e);
        public event SocketAcceptedHandler SocketAccepted;

    }
}
