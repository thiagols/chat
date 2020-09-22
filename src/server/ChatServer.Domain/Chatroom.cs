using System.Collections.Generic;

namespace ChatServer.Domain
{
    public class Chatroom
    {
        private string Name;
        private List<User> Users;

        public Chatroom(string name)
        {
            this.Name = name;
        }

        public override string ToString() => $"{Name}_room";

        public void AddUser(User user)
        {
            Users.Add(user);
        }
    }
}
