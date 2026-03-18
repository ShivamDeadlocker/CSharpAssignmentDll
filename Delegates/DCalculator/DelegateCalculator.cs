using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DCalculator
{
    public delegate double Calculation(double num1, double num2);

    public class DelegateCalculator
    {
        double result;
        public double Calculate(double num1, double num2, Calculation cal)
        {
            result = cal(num1, num2);
            return result;
        }

    }
}
