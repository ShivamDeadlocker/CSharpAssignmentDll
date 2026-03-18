using System;

namespace EmployeeCount
{
    /// <summary>
    /// Represents an employee and keeps track of the
    /// total number of employees created in the system.
    /// </summary>
    public class Employee
    {
        // Static variable to store employee count
        public static int empCount;

        /// <summary>
        /// Constructor increments employee count
        /// whenever a new Employee object is created.
        /// </summary>
        public Employee()
        {
            empCount++;
        }

        /// <summary>
        /// Property used to get the current employee count.
        /// </summary>
        public static int EmpCount
        {
            get
            {
                return empCount;
            }
        }
    }
}