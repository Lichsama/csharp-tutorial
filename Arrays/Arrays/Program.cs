namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[10];
            //for(int i = 0; i<10; i++)
            //{
            //    nums[i] = i+10;
            //}

            //for(int j =0; j<nums.Length; j++)
            //{
            //    Console.WriteLine("Element{0} = {1}",j,nums[j]);
            //}
            
            //int counter = 0;
            //foreach (int k in nums)
            //{
                
            //    Console.WriteLine("Element{0} = {1}", counter, k);
            //    counter++;
                
            //}

            //string[] myFriends = { "Micheal", "Wlad", "Ilja", "Andy", "Daniel" };
            //foreach(string name in myFriends)
            //{
            //    Console.WriteLine("Hi there {0}, my friend",name);
            //}

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            GetEven(array);

        }
        public static void GetOdd(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 != 0)
                {
                    Console.WriteLine(Array[i]);
                }
            }
        }

        public static void GetEven(int[] Array)
        {
            foreach (int value in Array)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(value);
                }
            }
        }

    }
}