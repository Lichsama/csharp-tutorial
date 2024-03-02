namespace ArraysAsParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentsgrades = new int[] { 15, 33, 23, 22, 16, 54, 64 };
            double AverageResult=GetAverage(studentsgrades);


            int[] happiness = { 2, 3, 4, 5, 6, 7 };
            SunIsShining(happiness);
            foreach(int i in happiness)
            {
                Console.WriteLine(i);
            }


            foreach(int grades in studentsgrades)
            {
                Console.WriteLine(grades);
            }

            Console.WriteLine("The average is "+AverageResult);

        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;
            for (int i = 0;i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }

        static void SunIsShining(int[] x)
        {
            for(int i=0;i<x.Length;i++)
            {
                x[i] += 2;
            }
        }

    }
}