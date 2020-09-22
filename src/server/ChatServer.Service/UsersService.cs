using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer.Service
{
    public class UsersService
    {
        private ConcurrentDictionary<string, WebSocket> _users = new ConcurrentDictionary<string, WebSocket>();

        public WebSocket GetRoom(string name) => _users.FirstOrDefault(room => room.Key.Equals(name)).Value;

        public List<string> GetAllRooms() => _users.Keys.ToList();

        public void AddRoom(WebSocket room)
        {
            _users.TryAdd(Guid.NewGuid().ToString(), room);
        }

        public async Task RemoveRoom(string name)
        {
            _users.TryRemove(name, out WebSocket room);

            await room.CloseAsync(closeStatus: WebSocketCloseStatus.NormalClosure,
                                statusDescription: "Closed room!",
                                cancellationToken: CancellationToken.None);
        }
    }
}
