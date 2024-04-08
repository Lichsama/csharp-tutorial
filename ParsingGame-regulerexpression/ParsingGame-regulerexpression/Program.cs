using System.Linq;
using System.Text.RegularExpressions;

namespace ParsingGame_regulerexpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\skrll\OneDrive\Masaüstü\input2.txt");
            string pattern = @"\d{3}|\d{2}";
            string[] arr = new string[100];
            char[] x = new char[] { };
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(text);
            Console.WriteLine("{0} hits found", matchCollection.Count);
            foreach (Match hit in matchCollection)
            {
                
                GroupCollection group = hit.Groups;
                Console.Write("{0} ", group[0].Value);
                
                
                


            }
            
        }
    }
}