using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem
{
    public class CloudLogger : ILogger
    {
        public string Logs(string msg)
        {
            return  "Cloud Logs: " + msg;
        }
    }
}
