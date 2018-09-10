using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalrServer.Api.Hubs
{
    public class SimpleHub : Hub
    {
        public SimpleHub()
        {

        }

        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await base.OnDisconnectedAsync(exception);
        }

        public async Task GetTestResponse()
        {
            await Clients.Caller.SendAsync("TestResponse", "some text");
        }
    }
}
