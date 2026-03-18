using System;

namespace HMS
{
    /// <summary>
    /// Represents a visiting doctor.
    /// Travel allowance is added to consultation fee.
    /// </summary>
    public class VisitingDoctor : Doctors
    {
        public VisitingDoctor(int drid, string dname, double cfee)
            : base(drid, dname, cfee)
        { }

        public override void CalculateTotalFee(double cfee)
        {
            // Travel allowance added for visiting doctor
            double travelAllowance = 1000;

            TotalFee = cfee + travelAllowance;
        }
    }
}