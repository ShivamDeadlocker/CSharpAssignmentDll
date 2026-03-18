using System;

namespace HMS
{
    /// <summary>
    /// Represents a surgeon doctor.
    /// Surgery charges are added to consultation fee.
    /// </summary>
    public class Surgeon : Doctors
    {
        public Surgeon(int drid, string dname, double cfee)
            : base(drid, dname, cfee)
        { }

        public override void CalculateTotalFee(double cfee)
        {
            // Additional surgery charges
            double surgeryCharges = 100;

            TotalFee = cfee + surgeryCharges;
        }
    }
}