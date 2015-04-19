using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Notificaciones.Web
{
    public class ChatHub : Hub
    {
        private List<string> messages;

        public ChatHub()
        {
            messages = new List<string>();
        }

        public void Send(string name, string message)
        {
            messages.Add(message);
            //Clients.All.hello();

            
            
            //Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message, DateTime.Now.ToString("hh:mm"));
        }
    }
}