namespace Challenge_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myfriend1 = "Berke Kamaz";
            string myfriend2 = "Kemal Yıldırım";
            string myfriend3 = "Cem Ateş";
            Console.WriteLine("Lütfen Seçim Yapınız");
            string sonuc = Console.ReadLine();
            if(sonuc =="1")
            {
                sonuc = myfriend1;
            }
            else if(sonuc =="2")
            {
                 sonuc=myfriend2;
            }
            else
            {
                sonuc = myfriend3;
            }
            GreetFriend(sonuc);
            Console.Read();

        }

        public static void GreetFriend(string sonuc)
        {
            Console.WriteLine("Hi {0}, my friend!", sonuc);
        }
    }
}