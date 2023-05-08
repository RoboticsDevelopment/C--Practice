using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPost
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }
        public ImagePost() { }
        public ImagePost(string title, string sendByUsername, string imageURL, bool IsPublic)
        {
            // The following properties and the GetNextID method are inherited from Post.
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = IsPublic;

            this.ImageURL = imageURL;
        }
        public override string ToString()
        {
                return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageURL, this.SendByUsername);
            }
}
}
