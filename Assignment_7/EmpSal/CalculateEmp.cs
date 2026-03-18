using System;

namespace EmpSal
{
    /// <summary>
    /// Represents an employee and performs salary calculation
    /// including HRA, Tax and Net Salary.
    /// </summary>
    public class CalculateEmp
    {
        // Employee ID
        public int EmpID { get; set; }

        // Employee Name
        public string EmpName { get; set; }

        // Basic Salary entered by user
        public double BasicSalary { get; set; }

        // House Rent Allowance
        public double HRA { get; set; }

        // Tax deduction
        public double Tax { get; set; }

        // Final salary after calculations
        public double NetSalary { get; set; }

        /// <summary>
        /// Calculates HRA, Tax and Net Salary for the given employee object.
        /// </summary>
        /// <param name="emp">Employee object whose salary needs to be calculated</param>
        public void CalculateSalary(CalculateEmp emp)
        {
            // Calculate HRA (20% of Basic Salary)
            emp.HRA = emp.BasicSalary * 0.20;

            // Calculate Tax (10% of Basic Salary)
            emp.Tax = emp.BasicSalary * 0.10;

            // Calculate Net Salary
            emp.NetSalary = emp.BasicSalary + emp.HRA - emp.Tax;
        }
    }
}