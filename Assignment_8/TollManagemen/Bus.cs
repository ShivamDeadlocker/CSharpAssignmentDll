using System;

namespace TollManagemen
{
    /// <summary>
    /// Represents a bus vehicle.
    /// Buses pay base toll plus passenger tax.
    /// </summary>
    public class Bus : Vehical
    {
        public Bus(string vnumber, string oname) : base(vnumber, oname) { }

        public override void CalculateTollAmount(double amount)
        {
            // 5% passenger tax
            double passengerTax = 0.05;

            FinalTollAmount = BaseTollAmount + (BaseTollAmount * passengerTax);
        }
    }
}