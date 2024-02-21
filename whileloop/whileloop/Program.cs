namespace whileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";
            while(enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by one and anything else");
                enteredText = Console.ReadLine();
                counter++;
                Console.WriteLine("Current people count is {0}", counter);
            }
            Console.WriteLine("{0} people are inside the bus", counter);
            

            for (int i = -3; i < 4; i++)
            {
                Console.WriteLine(i);
            }

            int z = -3;

            while (z < 4)
            {
                Console.WriteLine(z);
                z++;
            }
            Console.Read();
        }
    }
}