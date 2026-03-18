using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SubscriberNotification
{
    //VideoUploadHandler delegate is created with one parameter
    public delegate void VideoUploadHandler(string videoTitle);

    public class Publisher
    {
        //Created a event of delegate type VideoUploadHandler
        public event VideoUploadHandler VideoUpload;

        public void UploadVideo(string title)
        {
            HttpContext.Current.Response.Write("Video is Uploaded!!!!!");

            //Checking if any handler is attached or not 
            if (VideoUpload != null)
            {
                //Involking the event
                VideoUpload(title);
            }

        }

    }
}
