using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRInConsole
{
    public class ChatHub :Hub
    {
        public async Task SendMessage(string username, string message )
        {
            await Clients.All.SendAsync("ReceiveMessage", username, message);
        }
    }
}
