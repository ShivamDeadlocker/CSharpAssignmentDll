using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

/// <summary>
/// This is Publisher class that contains only events declaration and events involkation
/// </summary>
namespace Alarm
{
    //Created a Delegate
    public delegate void AlarmHandler();

    public class AlarmPublisher
    {
        //Creating a event having a type of delegate i.e "AlarmHandler"
        public event AlarmHandler AlarmRing;

        public void Ring()
        {

            HttpContext.Current.Response.Write("Alarm is ringing!!!!!");

            //Involke the events
            if (AlarmRing != null)
            {
                AlarmRing();
            }

        }

    }
}
