using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem
{
   public class UpiPayment : IPayment
    {
        public string PaymentProcess(string msg)
        {
            return "UPI Payment Type: " + msg;
        }
    }
}
