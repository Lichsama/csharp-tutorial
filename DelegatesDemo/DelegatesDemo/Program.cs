using System.Security.Cryptography.X509Certificates;

namespace DelegatesDemo
{
    internal class Program
    {
        public delegate bool FilterDelegate(Person p);
        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            List<Person> people = new List<Person>() { p1,p2,p3,p4};
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };
            
            Console.WriteLine("-----Before-----");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            names.RemoveAll(Filter);
            Console.WriteLine("----After-----");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            //DisplayPeople("Kids", people, IsMinor);
            //DisplayPeople("Adults", people, IsAdult);
            //DisplayPeople("Seniors", people, IsSenior);


            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >=20 && p.Age <=30;
            };

           // DisplayPeople("Between 20 and 30:", people, filter);
           // DisplayPeople("All:", people, delegate (Person p) { return true; });

            string searchKeyword = "A";
            DisplayPeople("age > 20 with searchkeyword" + searchKeyword, people, p => 
            {
                if(p.Name.Contains(searchKeyword) && p.Age > 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            DisplayPeople("Exactly 25:", people, p => p.Age == 25);

        }
        static void DisplayPeople(string title, List<Person> people, FilterDelegate Filter)
        {
            Console.WriteLine(title);
            foreach(Person p in people)
            {
                if (Filter(p))
                {
                    Console.WriteLine("{0},{1} years old",p.Name,p.Age);
                }
            }
        }
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }

        static bool Filter(string s)
        {
            return s.Contains("i");
        }
    }
}