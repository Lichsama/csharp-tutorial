namespace jaggedArrayChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] friends = new string[][]
            {
                new string[] {"Deniz","Kaan"},
                new string[] {"İrfan","Songül"},
                new string[] {"Kübra",}
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friends[0][0], friends[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friends[0][1], friends[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friends[0][1], friends[1][1]);
            Console.ReadKey();

        }
    }
}