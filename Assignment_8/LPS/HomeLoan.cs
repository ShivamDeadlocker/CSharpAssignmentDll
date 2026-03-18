using System;

namespace LPS
{
    /// <summary>
    /// Represents a home loan.
    /// Interest rate is fixed at 8%.
    /// </summary>
    public class HomeLoan : Loan
    {
        public HomeLoan(int lid, string cname, double lamount)
            : base(lid, cname, lamount)
        {
            // Set interest rate for home loan
            InterestRate = 0.08;
        }

        /// <summary>
        /// Calculates total payable amount including interest.
        /// </summary>
        public override void CalculateInterest()
        {
            TotalAmount = LoanAmount + (LoanAmount * InterestRate);
        }
    }
}