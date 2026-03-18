using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    /// <summary>
    /// This contains the different payment methods 
    /// </summary>
    public class PaymentMethods
    {
        public string CreditCard(double amount)
        {
            return amount + " " + "Pay through Credit Card!!!" + "<br/>"; 
        }

        public string UPI(double amount)
        {
            return amount + " " + "Pay through UPI!!!" + "<br/>";
        }

        public string NetBanking(double amount)
        {
            return amount + " " + "Pay through Net Banking!!!" + "<br/>";
        }
    }
}
