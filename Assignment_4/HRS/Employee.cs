using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HRS
{
    /// <summary>
    /// Class having a name , position and salary properties
    /// Class having a PromoteEmployee method which take a Employee class objec as a parameter 
    /// PromoteEmployee() is responsible for increasing the salary properties by 10%
    /// </summary>
    public class Employee
    {
        public string name { get; set; }
        public string position { get; set; }
        public double salary { get; set; }

        /// <summary>
        /// Increases the salary of the employee by 10% after promotion.
        /// </summary>
        /// <param name="emp">Employee object whose salary will be updated</param>
        public void PromoteEmployee(Employee emp)
        {
                emp.salary = salary + (salary * 0.10);       
        }
    }
}
