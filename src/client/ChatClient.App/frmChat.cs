using ChatClient.Service;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatClient.App
{
    public partial class frmChat : Form
    {
        private Thread Thread { get; set; }
        public StringBuilder Messages;

        public ChatService _chatService = new ChatService();

        public frmChat()
        {
            InitializeComponent();
            ClearAllFields();

            Messages = new StringBuilder();
        }

        private void btnEntrar_Click(object sender, System.EventArgs e)
        {
            if(_chatService.Connect(txtIP.Text, txtPorta.Text))
            {
                _chatService.SetNickname(txtApelido.Text);
                StartChatting();

                SetStatus("Usuário conectado.");
            }
            else
            {
                SetStatus("Falha ao realizar a conexão, por favor, revise os dados inseridos.");
            }
        }
        private void btnSair_Click(object sender, System.EventArgs e)
        {
            _chatService.Logoff();

            SetStatus("Usuário desconectado.");
        }

        public void StartChatting()
        {
            _chatService.SetChattingActive();

            Thread = new Thread(GetMessages);
            Thread.Start();
        }

        private void GetMessages()
        {
            while (_chatService.IsChatServerOn())
            {
                try
                {
                    byte[] data = new byte[512];
                    int res = _chatService.Socket.Receive(data);

                    if (res > 0)
                    {
                        string message = Encoding.Unicode.GetString(data);
                        ReceiveMessage(message);
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        delegate void ReceberMensagemCallback(string msg);

        void ReceiveMessage(string msg)
        {
            if (InvokeRequired)
            {
                ReceberMensagemCallback callback = ReceiveMessage;
                Invoke(callback, msg);
            }
            else
            {
                Messages.AppendLine(msg.Trim('\0'));
                txtChat.Text = Messages.ToString();
            }
        }

        private void btnEnviarMsg_Click(object sender, System.EventArgs e)
        {
            var destinyUser = listPessoas.SelectedItem.ToString();
            SendMessage(destinyUser, txtChat.Text);
        }

        private void btnEnviarMsgAll_Click(object sender, EventArgs e)
        {
            SendMessage("Todos", txtChat.Text);
        }

        private void SendMessage(string destinyUser, string chatroom)
        {
            if (_chatService.SendMessage(destinyUser, txtMensagem.Text))
            {
                SetStatus("Mensagem enviada.");
            }
            else
            {
                SetStatus("Falha ao enviar mensagem.");
            }
        }

        private void ClearAllFields()
        {
            //txtApelido.Text = string.Empty;
            //txtNovaSala.Text = string.Empty;
            //txtMensagem.Text = string.Empty;
            //listSalas.Items.Clear();
            //listPessoas.Items.Clear();
        }
        private void SetStatus(string msg)
        {
            statusMsg.Items.Clear();
            statusMsg.Items.Add(msg);
        }

    }
}
