using System;

namespace LPS
{
    /// <summary>
    /// Abstract class representing a loan in the loan processing system.
    /// Contains common loan details and forces derived classes
    /// to implement their own interest calculation logic.
    /// </summary>
    public abstract class Loan
    {
        // Loan Id
        public int LoanId { get; }

        // Customer name
        public string CustomerName { get; }

        // Loan amount requested
        public double LoanAmount { get; }

        // Interest rate applied for the loan
        public double InterestRate { get; set; }

        // Total amount payable after adding interest
        public double TotalAmount { get; set; }

        /// <summary>
        /// Constructor used to initialize loan details.
        /// </summary>
        public Loan(int loandId, string customerName, double loanAmount)
        {
            this.LoanId = loandId;
            this.CustomerName = customerName;
            this.LoanAmount = loanAmount;
        }

        /// <summary>
        /// Abstract method that forces derived classes
        /// to calculate interest differently.
        /// </summary>
        public abstract void CalculateInterest();
    }
}