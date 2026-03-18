using System;

namespace Ecommerce
{
    /// <summary>
    /// Abstract class representing an order in the e-commerce system.
    /// Contains common order details and forces derived classes
    /// to implement their own final amount calculation logic.
    /// </summary>
    public abstract class Order
    {
        // Unique order id
        public int OrderId { get; }

        // Customer name
        public string CustomerName { get; }

        // Base order amount
        public double OrderAmount { get; }

        // Final amount after calculation
        public double FinalAmount { get; set; }

        /// <summary>
        /// Constructor used to initialize order details.
        /// </summary>
        public Order(int orderId, string customerName, double orderAmount)
        {
            this.OrderId = orderId;
            this.CustomerName = customerName;
            this.OrderAmount = orderAmount;
        }

        /// <summary>
        /// Abstract method that must be implemented
        /// by each order type to calculate final amount.
        /// </summary>
        public abstract void CalculateAmount(double amount);
    }
}