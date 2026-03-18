using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem
{
    class Employee
    {
        public string name { get; set; }
        public string position { get; set; }
        public int salary { get; set; }

        public void UpdateSalary(int salary)
        {
            this.salary = salary;
        }
    }
}
