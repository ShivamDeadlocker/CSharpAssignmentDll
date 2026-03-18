using System;

namespace GST
{
    /// <summary>
    /// Class used to calculate GST and final payable bill amount.
    /// </summary>
    public class TaxCalculation
    {
        // Constant GST rate (18%) which cannot be changed during program execution
        const double TaxRate = 0.18;

        /// <summary>
        /// Calculates tax amount and total payable bill.
        /// </summary>
        /// <param name="totalMoney">Original bill amount</param>
        /// <param name="payableAmount">Final amount including tax</param>
        /// <returns>Calculated tax value</returns>
        public static double Bill(int totalMoney, out double payableAmount)
        {
            // Calculate GST
            double tax = totalMoney * TaxRate;

            // Add GST to original amount
            payableAmount = totalMoney + tax;

            // Return tax amount
            return tax;
        }
    }
}