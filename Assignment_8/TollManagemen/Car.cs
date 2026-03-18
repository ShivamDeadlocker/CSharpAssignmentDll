using System;

namespace TollManagemen
{
    /// <summary>
    /// Represents a car vehicle.
    /// Cars only pay the base toll amount.
    /// </summary>
    public class Car : Vehical
    {
        public Car(string vnumber, string oname) : base(vnumber, oname) { }

        public override void CalculateTollAmount(double amount)
        {
            // No additional charge for cars
            FinalTollAmount = BaseTollAmount;
        }
    }
}