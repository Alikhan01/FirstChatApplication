using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet;

namespace SimpleChatApplicationfrom_Waqar.Models
{
    public class ChatHub : Hub
    {
        //public void Hello()
        //{
        //    Clients.All.hello(); // Hub will control chats --
        //}

        public void Send(string name, string message)
        {
            Clients.All.BroadcastMessage(name, message);
        }
    }
}