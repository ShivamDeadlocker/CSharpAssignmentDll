using System;

namespace ProductOrder
{
    /// <summary>
    /// Represents an order and applies discount based on order amount.
    /// </summary>
    public class Discount
    {
        // Order ID
        public int OrderId { get; set; }

        // Order amount
        public double Amount { get; set; }

        // Indicates whether discount is applied
        public bool IsDiscountApplied { get; set; }

        /// <summary>
        /// Applies discount if order amount is greater than 5000.
        /// </summary>
        /// <param name="d">Discount object</param>
        public void ApplyDiscount(Discount d)
        {
            if (d.Amount > 5000)
            {
                // Apply 10% discount
                double discount = d.Amount * 0.10;
                d.Amount = d.Amount - discount;

                d.IsDiscountApplied = true;
            }
            else
            {
                d.IsDiscountApplied = false;
            }
        }
    }
}