namespace WriteFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "First 250", "Second 242", "Third 240" };
            File.WriteAllLines(@"C:\Users\skrll\OneDrive\Masaüstü\highscores.txt", lines);


            /*Console.WriteLine("Please give the file a name");
            string fileName=Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\skrll\OneDrive\Masaüstü\" + fileName + ".txt", input);*/

            using (StreamWriter file = new StreamWriter(@"C:\Users\skrll\OneDrive\Masaüstü\myText.txt"))
            {
                foreach(string line in lines)
                {
                    if(line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using(StreamWriter file = new StreamWriter(@"C:\Users\skrll\OneDrive\Masaüstü\myText2.txt"))
            {
               file.WriteLine("Additional Line");
            }

        }
    }
}