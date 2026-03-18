using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWithList
{
    /// <summary>
    /// Store Employee Properties Like EmpId , Name, Salary
    /// </summary>
    public class Employee
    {
        public int EmpId {get; set;}
        public string Name { get; set; }
        public double Salary { get; set; }

        //Return the following expression when the Object of Employee is directly printing
        public override string ToString()
        {
            return "Empploye Id: " + EmpId + " " + "Name: " + Name  + " " + "Salary: " + Salary + "<br/>"; 
        }
    }
}
