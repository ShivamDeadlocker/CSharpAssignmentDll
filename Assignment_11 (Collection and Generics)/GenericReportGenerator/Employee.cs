using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericReportGenerator
{
    /// <summary>
    /// Employee Class with Propeties like  Id, Name 
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "Employee ID: " + Id + " Name: " + Name;
        }
    }
}
