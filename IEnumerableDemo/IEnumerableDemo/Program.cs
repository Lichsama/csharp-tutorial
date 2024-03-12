namespace IEnumerableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);

            Console.WriteLine("This was a List<int>");
            foreach (int i in unknownCollection)
            {
                Console.Write(i+" ");
                Console.WriteLine();
            }

            unknownCollection = GetCollection(2);
            Console.WriteLine("This was a Queue<int>");
            foreach (int i in unknownCollection)
            {
                Console.Write(i + " ");
                Console.WriteLine();
            }
            
            unknownCollection = GetCollection(3);
            Console.WriteLine("This was a new<int>");
            foreach (int i in unknownCollection)
            {
                Console.Write(i + " ");
                Console.WriteLine();
            }


        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();

            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if (option == 1)
            {
                return numbersList;

            }
            else if (option == 2)
            {
                return numbersQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };



            }
        }
    }
}