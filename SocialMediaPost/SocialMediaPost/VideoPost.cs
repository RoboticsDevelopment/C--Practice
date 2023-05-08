using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocialMediaPost
{
    internal class VideoPost : Post
    {


        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        public string VideoURL { get; set; }
        protected double VideoLength { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, double VideoLength, bool isPublic)
        {
            // The following properties and the GetNextID method are inherited from Post.
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            this.VideoURL = videoURL;
            this.VideoLength = VideoLength;
        }


        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing!");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }   
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < VideoLength)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s,", currDuration);
                GC.Collect();
            }else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}mins - by {4}", this.ID, this.Title, this.VideoURL, this.VideoLength, this.SendByUsername);
        }
    }
}
