using System;

namespace HMS
{
    /// <summary>
    /// Abstract class representing a doctor in the hospital system.
    /// Contains common doctor details and forces derived classes
    /// to implement their own fee calculation logic.
    /// </summary>
    public abstract class Doctors
    {
        // Doctor ID
        public int DoctorId { get; }

        // Doctor name
        public string DoctorName { get; }

        // Basic consultation fee
        public double ConsultationFee { get; }

        // Final calculated fee
        public double TotalFee { get; set; }

        /// <summary>
        /// Constructor used to initialize doctor details.
        /// </summary>
        public Doctors(int doctorId, string doctorName, double consultationFee)
        {
            this.DoctorId = doctorId;
            this.DoctorName = doctorName;
            this.ConsultationFee = consultationFee;
        }

        /// <summary>
        /// Abstract method that forces derived classes
        /// to calculate the total consultation fee differently.
        /// </summary>
        public abstract void CalculateTotalFee(double cfee);
    }
}