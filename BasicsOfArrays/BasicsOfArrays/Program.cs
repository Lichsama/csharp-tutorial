﻿namespace BasicsOfArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("Grades at index 0 : {0}", grades[0]);
           
            string input= Console.ReadLine();
            // Assign value to array grades at index 0
            grades[0]=int.Parse(input);

            Console.WriteLine("Grades at index 0 : {0}", grades[0]);


            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("Length Of grades "+gradesOfMathStudentsA.Length);

            Console.ReadKey();

        }
    }
}