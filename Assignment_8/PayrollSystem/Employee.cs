using System;

namespace PayrollSystem
{
    /// <summary>
    /// Abstract base class representing an employee in the payroll system.
    /// Contains common employee details and forces derived classes
    /// to implement their own salary calculation logic.
    /// </summary>
    public abstract class Employee
    {
        // Employee Id
        public int EmployeeId { get; }

        // Employee Name
        public string EmployeeName { get; }

        // Basic salary provided during object creation
        public double BasicSalary { get; }

        // Final calculated salary
        public double calculatedSalary { get; set; }

        /// <summary>
        /// Constructor used to initialize employee details.
        /// </summary>
        public Employee(int empId, string empName, double salary)
        {
            this.EmployeeId = empId;
            this.EmployeeName = empName;
            this.BasicSalary = salary;
        }

        /// <summary>
        /// Abstract method that forces derived classes
        /// to implement salary calculation.
        /// </summary>
        public abstract void CalculateSalary(double salary);
    }


}