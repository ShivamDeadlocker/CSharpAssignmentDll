using System;

namespace LPS
{
    /// <summary>
    /// Represents a car loan.
    /// Interest rate is fixed at 10%.
    /// </summary>
    public class CarLoan : Loan
    {
        public CarLoan(int lid, string cname, double lamount)
            : base(lid, cname, lamount)
        {
            // Set interest rate for car loan
            InterestRate = 0.10;
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