using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway
{
    public class CreditCardPayment : PaymentSystem
    {
        public CreditCardPayment(string trid, double amount) : base(trid, amount) { }

        public override void CalculateProcessingFees()
        {
            ProcessingFees = Amount * 0.2; 
        }
    }
}
