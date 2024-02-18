namespace nestedif
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isAdmin = false;
            bool isRegistered = true;

            string userName = "";
            Console.WriteLine("Please enter your username");
            userName = Console.ReadLine();

            if(isRegistered)
            {
                Console.WriteLine("Hi there, registered user");
                if(userName != "")
                {
                    Console.WriteLine("Hi there, " + userName);
                }
                if(userName.Equals("Admin"))
                {
                    Console.WriteLine( "Hi there, Admin" );
                }
            }
            Console.Read();
        }
    }
}