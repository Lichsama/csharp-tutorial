using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImheritanceC
{
    class Post
    {
        private static int CurrentPostId;

        // prop
        protected int ID { get; set; }
        protected string Title {  get; set; } 
        protected string SendByUsername {  get; set; }
        protected bool IsPublic { get; set; }   

        public Post() 
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Kaan";
        }

        public Post(string title,bool isPublic,string sendByUsername)
        {
            this.ID=GetNextId();
            this.Title= title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
        }
        
        protected int GetNextId()
        {
            return ++CurrentPostId;
        }

        public void Update(string title,bool isPublic)
        {
            this.Title=title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by - {2}" ,this.ID,this.Title,this.SendByUsername);
        }

    }
}
