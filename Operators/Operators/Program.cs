namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators

            num3 = -num1;
            Console.WriteLine("num3 is {0}",num3);
           

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++); 
            Console.WriteLine("num is {0}", ++num);

            int result;
            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);

            // relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower);

            //condtional operators
            bool isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLowerAndSunny {0}", isLowerAndSunny);
            bool isLowerAndSunny2 = isLower || isSunny;
            Console.WriteLine("result of isLowerAndSunny {0}", isLowerAndSunny2);

            Console.ReadKey();
        }
    }
}