using System;

namespace WatchStore
{
    /// <summary>
    /// Handles Credit Card payment operations.
    /// </summary>
    public class CreditCard : IPayment
    {
        public string ValidatePayment()
        {
            return "Credit Card Payment Validated!!!";
        }

        public string ProcessPayment()
        {
            return "Credit Card Payment Processed!!!";
        }

        public string GenerateReceipt()
        {
            return "Credit Card Payment Receipt Generated!!!";
        }
    }
}