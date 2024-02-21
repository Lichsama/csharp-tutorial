namespace dowhileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int lenghtofText = 0;
            string wholeText = "";

            do
            {
                Console.WriteLine("Please enter the name of a firend");
                string nameOfAFriend = Console.ReadLine();
                int currentLenght = nameOfAFriend.Length;
                lenghtofText += currentLenght;
                wholeText += nameOfAFriend;
   

            } while (lenghtofText < 20);
            Console.WriteLine("Thanks, that was enough!"+ wholeText);
            Console.Read();
        }
    }
}