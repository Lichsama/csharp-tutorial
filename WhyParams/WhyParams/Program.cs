namespace WhyParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = Sum(1, 2, 3);
            int sum2 = Sum(3, 4, 5, 6, 7);
            int sum3 = Sum();
        }

        public static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach(int number in numbers)
            {
                total += number;
            }
            return total;
        }
    }
}