using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecalci
{
    //Created a delegates having a parameter of double type which is for salary
    public delegate double PayrollSystem(double salary);

    /// <summary>
    /// This class is used for involking the delegates using CalculateBonus method
    /// </summary>
    public class EmployeCalci
    {
        public double CalculateBonus(double salary, PayrollSystem ps)
        {
           double result = 0;
           return result = ps(salary);
        }

    }
}
