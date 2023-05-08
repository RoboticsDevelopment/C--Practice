using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPost
{
    public class Post
    {
        private static int currentPostId;

        //properties
        protected int ID { get; set; }
        public string Title { get; set; }
        public string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "Generic Post";
            IsPublic= true;
            SendByUsername = "No User Information";
        }

        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername= sendByUsername;
            this.IsPublic= isPublic;
        }

        protected int GetNextID()
        {
            return currentPostId++;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
                {
                return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
            }
        }
    }

