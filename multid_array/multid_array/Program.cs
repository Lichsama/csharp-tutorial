namespace multid_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare 2D
            string[,] matrix;

            //3D Array
            int[,,] array;

            //two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3}, // row 0
                {4,5,6}, // row 1
                {7,8,9}, // row 2
            };

            string[,,] array3D = new string[,,] 
            {
              {  
                    {"100","001"},
                    {"010","011"} 
              },
              {
                    {"100","101"},
                    {"110","111"}
              }
            };

            string[,] array2Dstring = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };
            array2Dstring[1, 1]= "Chicken";

            int dimensions = array2Dstring.Rank;
            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };


            Console.WriteLine(dimensions);
            Console.WriteLine("central value is {0}", array2D[2,0]);
            Console.WriteLine("central value is {0}", array3D[1,0,1]);
        }
    }
}