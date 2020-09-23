using System.Collections.Generic;

namespace ChatServer.Domain
{
    public class Chatroom
    {
        private string Name;
        private List<Client> Users;

        public Chatroom(string name)
        {
            this.Name = name;
        }

        public override string ToString() => $"{Name}_room";

        public void AddUser(Client user)
        {
            Users.Add(user);
        }
    }
}
