using System;

namespace Ecommerce
{
    /// <summary>
    /// Represents an online order.
    /// Shipping charges are added to the order amount.
    /// </summary>
    public class OnlineOrder : Order
    {
        public OnlineOrder(int orderId, string customerName, double orderAmount)
            : base(orderId, customerName, orderAmount)
        {
        }

        public override void CalculateAmount(double amount)
        {
            // Adding shipping charges for online order
            FinalAmount = amount + 100;
        }
    }
}