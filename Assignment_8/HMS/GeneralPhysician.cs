using System;

namespace HMS
{
    /// <summary>
    /// Represents a general physician.
    /// Only consultation fee is charged.
    /// </summary>
    public class GeneralPhysician : Doctors
    {
        public GeneralPhysician(int drid, string dname, double cfee)
            : base(drid, dname, cfee)
        { }

        public override void CalculateTotalFee(double cfee)
        {
            // Only consultation fee
            TotalFee = cfee;
        }
    }
}