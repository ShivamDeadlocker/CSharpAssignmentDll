using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem
{
    public class CreditCard : IPayment
    {
        public string PaymentProcess(string msg)
        {
            return "Credit Card Payment Type: " + msg;
        }
    }
}
