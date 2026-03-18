using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentGateway
{
    public abstract class PaymentSystem
    {
        public string TransactionId { get; }
        public double Amount { get;  }
        public DateTime paymentDate = System.DateTime.Now;
        public double ProcessingFees { get; set; }

        public PaymentSystem(string transactionId, double amount )
        {
            this.TransactionId = transactionId;
            this.Amount = amount;
        }

        public abstract void CalculateProcessingFees();

    }
}
