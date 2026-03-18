using System;

namespace LPS
{
    /// <summary>
    /// Represents a personal loan.
    /// Interest rate is fixed at 12%.
    /// </summary>
    public class PersonalLoan : Loan
    {
        public PersonalLoan(int lid, string cname, double lamount)
            : base(lid, cname, lamount)
        {
            // Set interest rate for personal loan
            InterestRate = 0.12;
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