using System;

namespace Ecommerce
{
    /// <summary>
    /// Represents an in-store order.
    /// No shipping charges are applied.
    /// </summary>
    public class StoreOrder : Order
    {
        public StoreOrder(int orderId, string customerName, double orderAmount)
            : base(orderId, customerName, orderAmount)
        {
        }

        public override void CalculateAmount(double amount)
        {
            // Store orders do not include shipping charges
            FinalAmount = amount;
        }
    }
}