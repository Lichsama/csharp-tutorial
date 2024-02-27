namespace _2Darrays
{
    internal class Program
    {
        static int[,] matrix = { 
            { 1, 2, 3 }, 
            { 4, 5, 6 }, 
            { 7, 8, 9 }
        };

        static void Main(string[] args)
        {
             foreach(int item in matrix)
            {
                Console.Write(item +" ");
            }
            
            Console.WriteLine("\n This is our 2D array printed using nested for loop");
            //outer loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                //inner loop
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                    Console.Write(matrix[i,j]+" ");
                }
            }

            Console.WriteLine("\n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                //inner loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine("");
            }

            //for(int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    //inner loop

            //    Console.WriteLine(matrix[i,i]);

            //}

            for (int i = 0,j=2; i < matrix.GetLength(0); i++,j--)
            {
                Console.WriteLine(matrix[i,j]);
            }




            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    //inner loop
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        if (matrix[i,j] %2 != 0)
            //        {
            //            Console.Write(matrix[i, j] + " ");
            //        }

            //    }
            //}
        }
    }
}