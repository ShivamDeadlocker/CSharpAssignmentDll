using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    //Created a delegate with parameter
   public delegate string PaymentModule(double amount);
         
   /// <summary>
   /// This is responsible for calling the delegates 
   /// </summary>
   public class CommonPaymentService
    {
        public string Pay(double amt, PaymentModule pay)
        {
            return pay(amt);
        }

    }
}
