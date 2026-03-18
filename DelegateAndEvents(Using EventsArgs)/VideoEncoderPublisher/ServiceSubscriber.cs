using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace VideoEncoderPublisher
{
    public class ServiceSubscriber
    {
        public string Name { get; set; }

        public void OnVideoUploded(object obj, VideoEventsArgs args)
        {
            HttpContext.Current.Response.Write(Name + " Video is Uploaded And Title is :"  + args .Title + "<br/>");
        }

    }
}
