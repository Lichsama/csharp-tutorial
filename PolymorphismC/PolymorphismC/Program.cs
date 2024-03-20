namespace PolymorphismC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car> 
            { 
                new Audi("Blue", 250, "A4"), 
                new BMW("Red", 200, "M3") 
            };


            foreach(var car in cars) 
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW("Red", 200, "Z3");
            Car audiA3 = new Audi("Green", 250, "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            bmwZ3.SetCarIDInfo(1234, "Kaan");
            audiA3.SetCarIDInfo(3131, "Tufan");
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();



            BMW bmwM5 = new BMW("White", 330, "M5");
            bmwM5.ShowDetails();

            Car carb = (Car)bmwM5;
            carb.ShowDetails();

            M3 myM3 = new M3("Red", 260, "M3 Super Turbo");
            myM3.Repair();


            Console.ReadKey();
        }
    }
}