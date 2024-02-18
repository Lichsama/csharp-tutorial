﻿namespace TryAndCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number!");
            string userInput = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cant devide by zero!");
            }

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

              Console.WriteLine("Format exception, please enter the correct type next time.");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }

            Console.ReadKey();
        }
    }
}