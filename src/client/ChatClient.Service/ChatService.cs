using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatClient.Service
{
    public class ChatService
    {
        public Socket Socket { get; private set; }
        public IPAddress ServerIp { get; private set; }
        public int ServerPort { get; private set; }
        private bool IsConnected { get; set; }
        public bool IsChatting { get; private set; }

        public ChatService()
        {
            IsConnected = false;
            IsChatting = false;
        }

        public bool Connect(string ipServer, string portServer)
        {
            if (IsConnected) return true;

            try
            {
                Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPAddress.TryParse(ipServer, out IPAddress serverip);
                Int32.TryParse(portServer, out int port);

                Socket.Connect(serverip, port);
                IsConnected = true;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Logoff()
        {
            if (!IsConnected) return;

            if (Socket != null)
            {
                Socket.Shutdown(SocketShutdown.Both);
                Socket.Close();
                Socket = null;
                IsConnected = false;
                IsChatting = false;
            }
        }
        
        public void SetNickname(string nick)
        {
            byte[] message = Encoding.Unicode.GetBytes($"setname {nick}");
            Socket.Send(message);
        }

        public bool SendMessage(string destinyUser, string msg)
        {
            try
            {
                if(IsChatting)
                {
                    byte[] message = Encoding.Unicode.GetBytes($"sendmsg {destinyUser} {msg}");
                    Socket.Send(message);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void SetChattingActive()
        {
            IsChatting = true;
        }

        public bool IsChatServerOn()
        {
            return IsChatting && IsConnected;
        }
    }
}
