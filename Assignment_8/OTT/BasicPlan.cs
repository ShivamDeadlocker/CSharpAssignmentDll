using System;

namespace OTT
{
    /// <summary>
    /// Represents a basic subscription plan.
    /// Only base price is applied.
    /// </summary>
    public class BasicPlan : Subscription
    {
        public BasicPlan(string uname, int sduration) : base(uname, sduration) { }

        public override void CalculateTotalPrice()
        {
            // Basic plan has no extra charges
            TotalPrice = BasePrice;
        }
    }
}