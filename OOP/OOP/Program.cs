using System.Security.AccessControl;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Car myCar = new Car();
           // Read only myCar.MaxSpeed = 100; 
            Console.WriteLine("Maxspeed is" + myCar.MaxSpeed);
            Console.WriteLine(myCar.Name);

            //Car myCar = new Car();
            //myCar._name = "Test";
            //myCar.setName("1");
            //Console.WriteLine(myCar.getName());
            //myCar.Details();
            //Car audi = new Car("Audi A4", 250, "Blue");
            //audi.Drive();
            //Car bmw = new Car("BMW M5", 350);
            //bmw.Drive();
            //audi.Details();
            //bmw.Details();

            //Console.WriteLine("Press 1 to stop the car!");
            //string userinput = Console.ReadLine();
            //if (userinput == "1")
            //{
            //    audi.Stop();
            //}
            //else
            //{
            //    Console.WriteLine("Car drives indefinetely");
            //}
        }
    }
}