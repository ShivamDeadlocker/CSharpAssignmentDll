using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem
{
    //Delegate for Payment Processing
    public delegate string PaymentProcessingModule();

    /// <summary>
    /// The class is resonsible for running the delegate
    /// </summary>
    public class CommonProcessingService
    {


        public string OrderProcessingService(PaymentProcessingModule ppm)
        {
            string result = "";

            //GetInvocationList store the array of Delegates usually used with Multicast Delegates
            foreach (Delegate d in ppm.GetInvocationList())
            {
                //DynamicInvoke Involke the Each Delegates 
                result += d.DynamicInvoke().ToString() + "<br/>";
            }
            return result;
        }
    }
}
