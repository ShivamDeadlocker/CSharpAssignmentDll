using System;

namespace BankingApplication
{
    /// <summary>
    /// Represents a bank account with account holder name 
    /// and account number which is assigned only once.
    /// </summary>
    public class Account
    {
        // Name of the account holder
        public string acountHolderName;

        // Account number is readonly and cannot be modified after object creation
        public readonly int accountNumber;

        /// <summary>
        /// Constructor used to initialize account details.
        /// </summary>
        /// <param name="name">Account holder name</param>
        /// <param name="acountNumber">Unique account number</param>
        public Account(string name, int acountNumber)
        {
            // Assign values during object creation
            this.acountHolderName = name;
            this.accountNumber = acountNumber;
        }
    }
}