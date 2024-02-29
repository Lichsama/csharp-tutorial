namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare jaggedArray
            int[][] jaggedArray = new int[3][];

            jaggedArray[0]=new int[5];
            jaggedArray[1]=new int[3];
            jaggedArray[2]=new int[3];

            

            int[][] triangle = new int[][]
            {
                new int []{1},
                new int []{2,3},
                new int []{4,5,6},
                new int []{7,8,9,10},
            };

            foreach (int[] row in triangle)
            {
                foreach(int number in row)
                {
                    Console.WriteLine(number);
                }
            }


            int[][] jaggedArray2 = new int[][]
            {
                new int []{2,3,5, 7,11},
                new int []{1,3,5,}
            };

            Console.WriteLine("The value in the middle of the first entry {0}", jaggedArray2[0][2]);

            for(int i=0; i<jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}",i);
                for (int j=0; j < jaggedArray2.Length; j++)
                {
                    Console.WriteLine("{0}", jaggedArray2[i][j]);
                }
            }

            
        }
    }
}