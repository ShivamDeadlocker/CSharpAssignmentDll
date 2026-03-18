using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SubscriberNotification
{
    /// <summary>
    /// This is having a event handler for VideoUpload event i.e GetNotification
    /// </summary>
    public class Subscriber
    {
        public string Name { get; set; }

        public Subscriber(string name)
        {
            this.Name = name;
        }

        //This is acts like a event handler 
        public void GetNotification(string videoTitle)
        {
            HttpContext.Current.Response.Write(Name + " Video is uploaded , Title: " + videoTitle + "<br/>");
        }

    }
}
