using Microsoft.AspNetCore.SignalR;
using SignalRServer.Services.ConnectionStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalrServer.Api.Hubs
{
    public class UsersHub : Hub
    {
        private readonly IConnectionStore _store;

        public UsersHub(IConnectionStore store)
        {
            _store = store;
        }

        public override async Task OnConnectedAsync()
        {
            //_store.Add(new ConnectedUser(Context.ConnectionId, userId));

            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await base.OnDisconnectedAsync(exception);
        }
    }
}
