using System;

namespace WatchStore
{
    /// <summary>
    /// Interface that defines the contract for all payment methods.
    /// Any payment type must implement validation, processing
    /// and receipt generation.
    /// </summary>
    public interface IPayment
    {
        // Validate payment details
        string ValidatePayment();

        // Process the payment transaction
        string ProcessPayment();

        // Generate payment receipt
        string GenerateReceipt();
    }
}