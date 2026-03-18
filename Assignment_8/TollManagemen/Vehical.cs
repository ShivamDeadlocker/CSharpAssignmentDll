using System;

namespace TollManagemen
{
    /// <summary>
    /// Abstract class representing a vehicle at the toll plaza.
    /// It contains common vehicle details and forces derived
    /// classes to implement their own toll calculation logic.
    /// </summary>
    public abstract class Vehical
    {
        // Vehicle number
        public string VehicleNumber { get; }

        // Owner name
        public string OwnerName { get; }

        // Final calculated toll amount
        public double FinalTollAmount { get; set; }

        // Base toll amount common for all vehicles
        public const double BaseTollAmount = 100;

        /// <summary>
        /// Constructor to initialize vehicle details.
        /// </summary>
        public Vehical(string vehicleNumber, string ownerName)
        {
            this.VehicleNumber = vehicleNumber;
            this.OwnerName = ownerName;
        }

        /// <summary>
        /// Abstract method that forces each vehicle type
        /// to implement its own toll calculation.
        /// </summary>
        public abstract void CalculateTollAmount(double amount);
    }
}