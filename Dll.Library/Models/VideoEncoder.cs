using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dll.Library.Data;

namespace Dll.Library.Models
{
    public class VideoEncoder : IVideoEncoder
    {
        public delegate void VideoEncodedHandler(object source, VideoEventArgs e);

        public event EventHandler<VideoEventArgs>  OnVideoDemand;

        public Video Video { get; set; }

        public VideoEncoder(Video video)
        {
            Video = video;
        }

        public void Encode(Video video)
        {
            Console.WriteLine("Video se enkoduje::: " + " Titul je " + video.Title + " Nazev filmu: " + video.NameOfVideo);
            Thread.Sleep(5000);

            OnVideoEncode(video);
        }

        protected virtual void OnVideoEncode(Video video)
        {
            OnVideoDemand?.Invoke(this, new VideoEventArgs(){Video = video});
        }
    }
}
