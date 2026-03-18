using System;

namespace WatchStore
{
    /// <summary>
    /// Service class responsible for handling payment operations.
    /// Uses dependency injection to accept any payment type
    /// that implements IPayment.
    /// </summary>
    public class ProcessPaymentService
    {
        // Purchase amount
        public double Amount { get; }

        // Payment interface reference
        private readonly IPayment Payment;

        /// <summary>
        /// Constructor injection of payment type
        /// </summary>
        public ProcessPaymentService(double amount, IPayment payment)
        {
            Amount = amount;
            Payment = payment;
        }

        // Validate payment
        public string Validate()
        {
            return Payment.ValidatePayment();
        }

        // Process payment
        public string Process()
        {
            return Payment.ProcessPayment();
        }

        // Generate receipt
        public string Generate()
        {
            return Payment.GenerateReceipt();
        }
    }
}