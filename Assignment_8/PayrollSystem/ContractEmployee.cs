using System;

namespace PayrollSystem
{
    /// <summary>
    /// Represents a contract employee.
    /// Contract employees receive fixed salary with no bonus.
    /// </summary>
    public class ContractEmployee : Employee
    {
        public ContractEmployee(int empId, string empName, double basicSalary)
            : base(empId, empName, basicSalary)
        {
        }

        /// <summary>
        /// Calculates salary for contract employee.
        /// No additional benefits are applied.
        /// </summary>
        public override void CalculateSalary(double salary)
        {
            calculatedSalary = BasicSalary;
        }
    }
}