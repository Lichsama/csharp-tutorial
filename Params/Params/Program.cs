using System.ComponentModel;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = MinV2(6, 4, 2, 8, 10, 1, 5);
            Console.WriteLine("The minimum is {0} : ",min);


        }

        public static int MinV2(params int[] numbers) 
        {
            int min = int.MaxValue;
            foreach (int number in numbers)
            {
                if (number<min)

                {
                    min= number;
                }

            }
            return min;
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for(int i=0; i<sentence.Length; i++)
            {
                Console.Write(sentence[i]+" ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach(object o in stuff)
            {
                Console.Write(o + " ");

            }
            Console.WriteLine();
        }
    }
}