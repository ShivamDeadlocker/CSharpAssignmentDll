using System;

namespace BankSystem
{
    /// <summary>
    /// Service class responsible for processing bank operations.
    /// Uses dependency injection to accept different account types.
    /// </summary>
    public class BankProcessService
    {
        // Current account balance
        public double Balance { get; }

        // Withdrawal amount
        public double WAmount { get; set; }

        // Interface reference
        private readonly IBank bank;

        /// <summary>
        /// Constructor injection of account type
        /// </summary>
        public BankProcessService(double balance, IBank Bank)
        {
            this.Balance = balance;
            this.bank = Bank;
        }

        // Deposit operation
        public string Deposit()
        {
            return bank.Deposit();
        }

        // Withdraw operation
        public string Withdraw()
        {
            return bank.WithDraw(Balance, WAmount);
        }

        // Check balance operation
        public string CheckBalance()
        {
            return "Your balance is: " + Balance + " " + bank.CheckBalance();
        }
    }
}