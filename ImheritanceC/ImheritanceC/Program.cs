namespace ImheritanceC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes",true,"Kaan");
            Console.WriteLine(post1.ToString());
            
            ImagePost imagepost1 = new ImagePost("Check out my new shoes", "Kaan","https://iamges.com/shoes", true);
            VideoPost videopost1 = new VideoPost("FailVideo", "Kaan", "www.video.com", true, 10);
            


            Console.WriteLine(imagepost1.ToString());
            Console.WriteLine(videopost1.ToString());

            videopost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videopost1.Stop();
            Console.ReadLine();
        }
    }
}