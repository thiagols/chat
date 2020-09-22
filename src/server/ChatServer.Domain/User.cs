namespace ChatServer.Domain
{
    public class User
    {
        private string Nickname;

        public User(string nickname)
        {
            Nickname = nickname;
        }

        public string GetNickname() => Nickname;
        public void SetNickname(string nickname) => Nickname = nickname;

        public override string ToString() => Nickname;
        }
    }
}
