namespace InheritanceChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee micheal = new Employee("Micheal", "Miller", 40000);
            micheal.Work();
            micheal.Pause();

            Boss kaan = new Boss("Kaan", "Karaarslan", 100000, "Porsche");
            kaan.Lead();

            Trainees deniz = new Trainees("Deniz", "Yıldırım", 5000, 5, 4);
            deniz.Work();
            deniz.Pause();
            Console.ReadKey();
        }
    }
}