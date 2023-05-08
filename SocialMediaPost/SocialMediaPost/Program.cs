using System;

namespace SocialMediaPost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the CUDDLEZZ", true, "Patrick Byrne");
            Console.WriteLine(post1.ToString());
            
            post1.SendByUsername = "Weiner";

            Console.WriteLine(post1.ToString());

            Post AnnasPost = new Post("I love kitties!", true, "Anna Bananna");
            Console.WriteLine(AnnasPost.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Black Dude",
                "https://images.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("Check out my Bathroom Cam!", "Creeper Peeper", "https://videos/creeperdude", 12.24, true);
            videoPost1.Play();
            Console.WriteLine("Press any key to stop video");
            Console.ReadKey();
            videoPost1.Stop();
            Console.WriteLine(videoPost1.ToString());

            VideoPost videoPost2 = new VideoPost();
            videoPost2.Title = "Awesome Video";
            videoPost2.SendByUsername = "Dick Smith";
            videoPost2.VideoURL = "https://site/videos";
            Console.WriteLine(videoPost2.ToString());

        }
    }
}
