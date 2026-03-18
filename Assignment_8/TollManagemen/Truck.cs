using System;

namespace TollManagemen
{
    /// <summary>
    /// Represents a truck vehicle.
    /// Trucks pay base toll plus heavy vehicle charge.
    /// </summary>
    public class Truck : Vehical
    {
        public Truck(string vnumber, string oname) : base(vnumber, oname) { }

        public override void CalculateTollAmount(double amount)
        {
            // 10% heavy vehicle charge
            double heavyvehiclecharge = 0.10;

            FinalTollAmount = BaseTollAmount + (BaseTollAmount * heavyvehiclecharge);
        }
    }
}