using System;

namespace OTT
{
    /// <summary>
    /// Represents a premium subscription plan.
    /// Premium plan includes 18% GST.
    /// </summary>
    public class PremiumPlan : Subscription
    {
        public PremiumPlan(string uname, int sduration) : base(uname, sduration) { }

        public override void CalculateTotalPrice()
        {
            // Add 18% GST to base price
            TotalPrice = BasePrice + (BasePrice * 0.18);
        }
    }
}