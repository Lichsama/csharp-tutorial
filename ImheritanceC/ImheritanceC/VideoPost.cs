using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImheritanceC
{
    class VideoPost:Post
    {
        protected bool IsPlaying = false;
        protected int CurrDuration = 0;
        Timer timer;

        protected string VideoURL { get; set; }    

        protected int Length {  get; set; }

        public VideoPost()
        {

        }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
            ID=GetNextId();
            Title= title;
            SendByUsername= sendByUsername;
            VideoURL= videoURL;
            IsPublic= isPublic;
            Length= length;
        }

        public void Play()
        {
            if(!IsPlaying)
            {
                IsPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 100);
            }
          
        }

        private void TimerCallback(Object o)
        {
            if(CurrDuration< Length )
            {
                CurrDuration++;
                Console.WriteLine("Video at {0}",CurrDuration);
                GC.Collect();

            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if(IsPlaying) 
            {
                IsPlaying= false;   
                Console.WriteLine("Stopped at {0}", CurrDuration);
                CurrDuration = 0;
                timer.Dispose();
            }
           
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} by - {4}", this.ID, this.Title, this.VideoURL,this.Length, this.SendByUsername);
        }

    }
}
