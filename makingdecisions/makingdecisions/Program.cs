namespace makingdecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);

            if(numTemp<10)
            {
                Console.WriteLine("Take the coat");

            }
            if (numTemp == 10)
            {
                Console.WriteLine("it's 10 degrees C");
            }
            if (numTemp > 10)
            {
                Console.WriteLine("cozy and warm!");
            }
            Console.Read();
        }
    }
}