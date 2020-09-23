using ChatServer.Service;

namespace ChatServer.App
{
    class Program
    {
        static void Main()
        {
            ChatService server = new ChatService();
            server.Start();
        }
    }
}
