namespace enhanced_if_challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Temperature");
            string tempeature=Console.ReadLine();
            int numTemp;
            int number;
            string stateofweather;
            bool isTrue = int.TryParse(tempeature, out number);
            if(isTrue==true)
            {
                numTemp = number;
            }
            else
            {
                Console.WriteLine("Error you must be entered number");
                numTemp = 0;
            }

            stateofweather = numTemp <= 15 ? "it's too cold here" : numTemp >=16 && numTemp <=28 ? "it is ok" : "it's hot here";
            Console.WriteLine("State of weather {0}",stateofweather);


        }
    }
}