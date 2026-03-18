using System;

namespace OTT
{
    /// <summary>
    /// Abstract class representing a subscription plan.
    /// Contains common user details and forces derived
    /// classes to implement price calculation.
    /// </summary>
    public abstract class Subscription
    {
        // Username of the subscriber
        public string UserName { get; }

        // Duration of subscription in months
        public int SubscriptionDuration { get; }

        // Final calculated price of the plan
        public double TotalPrice { get; set; }

        // Base price for subscription
        public const double BasePrice = 100;

        /// <summary>
        /// Constructor used to initialize subscription details.
        /// </summary>
        public Subscription(string userName, int subscriptionDuration)
        {
            this.UserName = userName;
            this.SubscriptionDuration = subscriptionDuration;
        }

        /// <summary>
        /// Abstract method that forces each plan
        /// to calculate price differently.
        /// </summary>
        public abstract void CalculateTotalPrice();
    }
}