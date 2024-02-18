namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberasString = "128.6";
            int parsedValue;
            bool success= int.TryParse(numberasString, out parsedValue);    
            if(success )
            {
                Console.WriteLine("Parsing succesful - number is " + parsedValue);
            }
            else {
                Console.WriteLine("Parsing Failed");
             }
        }
    }
}