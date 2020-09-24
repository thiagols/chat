using System.Net.Sockets;

namespace ChatClient.Domain
{
    public interface IChatService
    {
        Socket Socket { get; }
        bool Connect(string ipServer, string portServer);
        public void Logoff();
        public void SetNickname(string nick);
        public bool SendMessage(string destinyUser, string msg);
        public void SetChattingActive();
        public bool IsChatServerOn();

    }
}
