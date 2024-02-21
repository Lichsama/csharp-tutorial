namespace forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 50; counter +=5)
            {
                Console.WriteLine(counter + "is lower than 50 ");
            }
            Console.WriteLine("For loop is done");

            for (int counter = 1; counter < 21; counter += 2)
            {
                Console.WriteLine(counter + " is lower than 50 ");
            }
            Console.ReadKey(); 

        }
    }
}