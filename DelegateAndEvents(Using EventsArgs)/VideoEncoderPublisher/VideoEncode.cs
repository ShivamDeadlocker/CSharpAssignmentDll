using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace VideoEncoderPublisher
{
    //Created a Delegate Having two parameter source of events and event related arguments

    //public delegate void VideoUploadHandler(object source, VideoEventsArgs args);

    
    public class VideoEncode
    {
        //public event VideoUploadHandler VideoUploadEvent;

        public event EventHandler<VideoEventsArgs> VideoUploadEvent;

        public void OnVideoUplod(string title, string author)
        {
            HttpContext.Current.Response.Write("Video Title is: " + title + " Author is" + author  + "<br/>");

            VideoEventsArgs args = new VideoEventsArgs();
            args.Title = title;
            args.Author = author;

            if (VideoUploadEvent != null)
            {
                VideoUploadEvent(this, args);
            }
        }

    }

    public class VideoEventsArgs : EventArgs
    {
        public string Title { get; set; }
        public string Author { get; set; }

    }
}
