using System.Dynamic;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)

        {

            int x;
            float y;


            string stringForFloat = "0.85"; // datatype should be float

            string stringForInt = "12345"; // datatype should be int

            x = int.Parse(stringForInt);
            y =float.Parse(stringForFloat);

            Console.WriteLine(x.GetType());
            Console.WriteLine(y.GetType());



            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();

        }
    }
}