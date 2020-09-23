using ChatServer.Domain;
using ChatServer.Domain.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ChatServer.Service
{
    public class ChatService
    {
        #region Properties

        public Thread ChatProcess { get; private set; }
        public bool IsServerActive { get; private set; }
        public Socket ListeningSocket { get; private set; }
        public List<Client> ClientsPool { get; private set; }
        public IPEndPoint EndPoint { get; private set; }

        #endregion

        #region Public Methods
        public ChatService()
        {
            IsServerActive = false;
            ClientsPool = new List<Client>();
        }

        public void Start()
        {
            try
            {
                Console.WriteLine("Iniciando Servidor...");

                while (true)
                {
                    if (IsServerActive) return;

                    ListeningSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    EndPoint = new IPEndPoint(IPAddress.Any, 8833);
                    ListeningSocket.Bind(EndPoint);
                    ListeningSocket.Listen(5);

                    ConsoleUtil.PrintWithColor("Servidor online! IP: 127.0.0.1 | Porta: 8833", ConsoleColor.Blue);

                    ChatProcess = new Thread(WaitClients);
                    ChatProcess.Start();
                    IsServerActive = true;
                }
            }
            catch (Exception)
            {
                ConsoleUtil.PrintWithColor("Não foi possível estabelecer conexão.", ConsoleColor.Red);
                return;
            }
        }
        public void Stop()
        {
            if (!IsServerActive) return;

            ConsoleUtil.PrintWithColor("Parando o servidor...", ConsoleColor.Blue);
            
            IsServerActive = false;
            
            while (ClientsPool.Count != 0)
            {
                Client client = ClientsPool[0];
                ClientsPool.Remove(client);
                client.Dispose();
            }

            ListeningSocket.Close();
            ListeningSocket = null;

            ConsoleUtil.PrintWithColor("Servidor parado.", ConsoleColor.Blue);
        }

        #endregion

        #region Private Methods

        private void WaitClients()
        {
            while (IsServerActive)
            {
                Client client = new Client();

                try
                {
                    client.Socket = ListeningSocket.Accept();
                    client.thread = new Thread(() => ProcessMessaging(client));

                    ClientsPool.Add(client);

                    client.thread.Start();

                    Console.WriteLine("{0} connected.", client.GetNickname());
                }
                catch (Exception)
                {
                    ConsoleUtil.PrintWithColor("Falha na espera da conexão com o cliente", ConsoleColor.Red);
                }
            }
        }

        private void ProcessMessaging(Client client)
        {
            if (!SendMessage(client, "Você agora está online!"))
                return;

            while (IsServerActive)
            {
                try
                {
                    byte[] buff = new byte[512];

                    if (!client.Socket.Connected)
                    {
                        ClientsPool.Remove(client);
                        ConsoleUtil.PrintWithColor($"{client.GetNickname()} desconectado...", ConsoleColor.Green);
                        client.Dispose();
                        return;
                    }

                    int res = client.Socket.Receive(buff);

                    string strMessage = Encoding.Unicode.GetString(buff);

                    ExecClientCommand(client, strMessage, res);
                }
                catch (SocketException)
                {
                    ClientsPool.Remove(client);
                    ConsoleUtil.PrintWithColor($"{client.GetNickname()} desconectado...", ConsoleColor.Green);
                    client.Dispose();
                    return;
                }
            }
        }

        private void ExecClientCommand(Client client, string strMessage, int res)
        {
            string response = string.Empty;

            if (res > 0)
            {
                var cmd = strMessage.Split(" ").FirstOrDefault();
                var paramters = strMessage.Replace($"{cmd} ",string.Empty).Trim('\0');

                if (cmd.Equals("setname"))
                {
                    string username = paramters;
                    bool IsFree = true;

                    foreach (Client clientPoll in ClientsPool)
                    {
                        if (clientPoll.GetNickname() == username)
                        {
                            IsFree = false;
                            response = "Nickname já em uso!";
                            break;
                        }
                    }
                    if (IsFree)
                    {
                        client.SetNickname(username);
                        response = "Seu novo nick: " + username;
                    }
                    
                }
                else if (cmd.Equals("getclients"))
                {
                    response = "Usuarios online:\n";
                   
                    foreach (Client user in ClientsPool)
                        response = response + user.GetNickname() + "\n";
                   
                }
                else if (cmd.Equals("sendmsg"))
                {
                    bool IsSend = false;

                    var destiny = paramters.Split(" ").FirstOrDefault();
                    var msgto = client.GetNickname() + ":" + paramters.Replace($"{destiny} ", string.Empty);

                    foreach (Client user in ClientsPool)
                    {
                        if (destiny.Equals("Todos") || user.GetNickname().Equals(destiny))
                        {
                            IsSend = SendMessage(user, msgto);
                        }
                    }
                    if (!IsSend)
                    {
                        response = "Não foi possível enviar a mensagem para " + destiny;
                    }
                }

                SendMessage(client, response);
            }
        }

        private bool SendMessage(Client client, string msg)
        {
            try
            {
                client.Socket.Send(Encoding.Unicode.GetBytes(msg));
                return true;
            }
            catch
            {
                ConsoleUtil.PrintWithColor($"Não foi possível enviar a mensagem para {client.GetNickname()}", ConsoleColor.Red);
                return false;
            }
        }

        #endregion
    }
}
