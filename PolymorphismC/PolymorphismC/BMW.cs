using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    internal class BMW : Car
    {
        private string brand = "BMW";
        public string Model { get; set; }   


        public BMW(string color, int hp, string model) : base(color, hp)
        {
            Model = model;
        }
     
        public new void ShowDetails()
        {
            Console.WriteLine("Brand"+brand+"HP:"+HP+"Color:"+Color);
        }

        public sealed override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired",Model);
        }
    }
}
