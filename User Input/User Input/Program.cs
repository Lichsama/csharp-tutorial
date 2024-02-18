namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(calculate());
            Console.Read();
        }
        public static int calculate()
        {
            Console.WriteLine("Please Enter the first Number");
            string number1Input = Console.ReadLine(); ;
            Console.WriteLine("Please Enter the second Number");
            string number2Input= Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2 ;
            return result;
        }
    }
}