using System;

namespace WatchStore
{
    /// <summary>
    /// Handles UPI payment operations.
    /// </summary>
    public class UpiPayment : IPayment
    {
        public string ValidatePayment()
        {
            return "UPI Payment Validated!!!";
        }

        public string ProcessPayment()
        {
            return "UPI Payment Processed!!!";
        }

        public string GenerateReceipt()
        {
            return "UPI Payment Receipt Generated!!!";
        }
    }
}