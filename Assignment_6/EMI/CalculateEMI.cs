using System;

namespace EMI
{
    /// <summary>
    /// Utility class used to calculate EMI for a loan based on
    /// principal amount, interest rate and number of months.
    /// </summary>
    public class CalculateEMI
    {
        /// <summary>
        /// Calculates EMI using the standard EMI formula.
        /// </summary>
        /// <param name="principalA">Loan principal amount</param>
        /// <param name="aRate">Annual interest rate</param>
        /// <param name="months">Loan tenure in months</param>
        /// <returns>Calculated EMI value</returns>
        public static double Calculate(double principalA, double aRate, int months)
        {
            // Convert annual interest rate to monthly rate
            double mRate = aRate / 12 / 100;
            double emi = 0;

            // Calculate (1 + rate)^months
            double newRate = MyPower((1 + mRate), months);

            // EMI formula
            emi = principalA * mRate * (newRate / (newRate - 1));

            return emi;
        }

        /// <summary>
        /// Custom method to calculate power value (base^exponent).
        /// </summary>
        /// <param name="i">Base value</param>
        /// <param name="j">Exponent value</param>
        /// <returns>Calculated power value</returns>
        public static double MyPower(double i, double j)
        {
            double result = 1;

            // Multiply base value repeatedly to calculate power
            for (int x = 0; x < j; x++)
            {
                result *= i;
            }

            return result;
        }
    }
}