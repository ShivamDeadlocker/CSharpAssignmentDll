using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway
{
    public class NetBankingPayment : PaymentSystem
    {
        public NetBankingPayment(string trid, double amount) : base(trid, amount) { }

        public override void CalculateProcessingFees()
        {
            ProcessingFees = Amount - 50;
        }
    }
}
