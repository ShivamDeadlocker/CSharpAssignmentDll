using System;

namespace WatchStore
{
    /// <summary>
    /// Handles NetBanking payment operations.
    /// Implements IPayment interface.
    /// </summary>
    public class NetBanking : IPayment
    {
        public string ValidatePayment()
        {
            return "Netbanking Payment Validated!!!";
        }

        public string ProcessPayment()
        {
            return "Netbanking Payment Processed!!!";
        }

        public string GenerateReceipt()
        {
            return "Netbanking Payment Receipt Generated!!!";
        }
    }
}