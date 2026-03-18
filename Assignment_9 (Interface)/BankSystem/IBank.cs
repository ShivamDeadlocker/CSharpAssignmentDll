using System;

namespace BankSystem
{
    /// <summary>
    /// Interface defining basic banking operations.
    /// Any bank account type must implement these methods.
    /// </summary>
    public interface IBank
    {
        // Deposit money
        string Deposit();

        // Withdraw money
        string WithDraw(double balance, double wamount);

        // Check account balance
        string CheckBalance();
    }
}