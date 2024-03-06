using System;
namespace StacksDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define
            Stack<int> stack=new Stack<int>();

            //add element
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
           
            //remove
            // int mystackItem=stack.Pop();

            //peek top of the stack without remove
            Console.WriteLine(stack.Peek());

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Count);
            }

            int[] numbers=new int[] {8,2,3,4,7,6,2};
            Stack<int> myStack= new Stack<int>(); 
            foreach(int number in numbers)
            {
                Console.WriteLine(number + " ");
                myStack.Push(number);
            }


        }
    }
}