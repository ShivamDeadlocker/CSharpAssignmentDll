using System;

namespace PayrollSystem
{
    /// <summary>
    /// Represents a permanent employee.
    /// Permanent employees receive HRA and bonus.
    /// </summary>
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(int empId, string empName, double basicSalary)
            : base(empId, empName, basicSalary)
        {
        }

        /// <summary>
        /// Calculates salary for permanent employee
        /// including HRA and bonus.
        /// </summary>
        public override void CalculateSalary(double salary)
        {
            double hra = 10;      // Fixed HRA
            double bonus = 100;   // Fixed bonus

            calculatedSalary = BasicSalary + hra + bonus;
        }
    }
}