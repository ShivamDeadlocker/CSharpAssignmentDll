using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem
{
    public interface ILogger
    {
         string Logs(string msg);
    }
}
