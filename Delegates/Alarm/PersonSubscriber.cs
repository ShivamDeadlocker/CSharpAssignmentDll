using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

/// <summary>
/// This is a subscriber class that contains the eventhandler!!!
/// </summary>
namespace Alarm
{
    public class PersonSubscriber
    {
        //The method signature is same as delegates
        public void WakeUp()
        {
            HttpContext.Current.Response.Write("Person is Wakeup After, Alarm's ring!!!!!");
        }
    }
}
