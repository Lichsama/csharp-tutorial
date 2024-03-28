namespace Readfromtext
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\skrll\OneDrive\Masaüstü\textFile.txt");
            Console.WriteLine("Textfile contains following text: {0}",text);
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\skrll\OneDrive\Masaüstü\textFile.txt");
            Console.WriteLine("Contents of textfile.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
        }
    }
}