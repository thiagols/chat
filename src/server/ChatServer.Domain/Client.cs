using System;
using System.Net.Sockets;
using System.Threading;

namespace ChatServer.Domain
{
    public class Client
    {
        private Guid ID;
        private string Nickname;
        
        public Socket Socket { get; set; }
        public Thread thread;

        public Client()
        {
            ID = Guid.NewGuid();
            Nickname = ID.ToString();
        }

        public Client(string nickname)
        {
            ID = Guid.NewGuid();
            Nickname = nickname;
        }

        public string GetNickname() => Nickname;
        public void SetNickname(string nickname) => Nickname = nickname;

        public override string ToString() => Nickname;

        private bool _isDisposed = false;
        public void Dispose()
        {
            if (!_isDisposed)
            {
                if (this.Socket != null)
                {
                    this.Socket.Shutdown(SocketShutdown.Both);
                    this.Socket.Close();
                    this.Socket = null;
                }
                if (this.thread != null)
                    this.thread = null;
                _isDisposed = true;
            }
        }
    }
}
