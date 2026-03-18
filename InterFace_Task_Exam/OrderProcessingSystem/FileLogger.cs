using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem
{
    public class FileLogger : ILogger
    {
        public string Logs(string msg)
        {
            return "File Logs: " + msg;
        }
    }
}
