namespace ternary_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {

         
            int temperature = -5;
            string stateOfmatter;

            if (temperature < 0)
            {
                stateOfmatter = "solid";
            }
            else
            {
                stateOfmatter = "liquid";
            }

            Console.WriteLine("State of matter is {0}",stateOfmatter);

            temperature += 30;
           

            // in short:
            stateOfmatter = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of matter is {0}", stateOfmatter);

            Console.ReadKey();
        }
    }
}