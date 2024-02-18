namespace if_and_tryparse_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool userEnteredANumber=int.TryParse(temperature, out number);

            if(userEnteredANumber)
            {
                numTemp = number;
            }
            else
            {
                numTemp=0;
                Console.WriteLine("Value entered,was no number. 0 set as temperature");
            }
            if (numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }
        }
    }
}