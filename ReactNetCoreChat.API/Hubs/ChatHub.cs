using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactNetCoreChat.API.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
    }
}
