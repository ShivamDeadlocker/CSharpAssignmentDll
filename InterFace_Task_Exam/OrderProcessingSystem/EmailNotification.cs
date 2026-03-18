using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem
{
   public class EmailNotification : INotification
    {
        public string Notification(string msg)
        {
            return "Email Notification" + msg;
        }
    }
}
