using System.Collections;

namespace ArrayListC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring
            ArrayList myArrayList=new ArrayList();
            ArrayList myArrayList2=new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);


            // delete element with specific value
            myArrayList.Remove(13);

            // delete element at specifi position
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }else if(obj is double)
                {
                    sum += (double)obj;
                }
                else
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}