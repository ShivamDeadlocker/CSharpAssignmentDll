using System;

namespace OTT
{
    /// <summary>
    /// Represents a family subscription plan.
    /// Family plan adds 30% extra cost.
    /// </summary>
    public class FamilyPlan : Subscription
    {
        public FamilyPlan(string uname, int sduration) : base(uname, sduration) { }

        public override void CalculateTotalPrice()
        {
            // Add 30% extra for family usage
            TotalPrice = BasePrice + (BasePrice * 0.30);
        }
    }
}