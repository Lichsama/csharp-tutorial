using System.Runtime.InteropServices;

namespace Methods_with_Return_Value_and_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result =  Add(15, 31);
            int result2 = multiplication(100, 34);
            double result3 = devide(23, 12);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        
        public static double devide(double  num1,double num2)
        {
            return num1 / num2;
        }
    }
}