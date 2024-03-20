using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    internal class Audi:Car
    {

        private string brand = "Audi";
        public string Model { get; set; }


        public Audi(string color, int hp, string model) : base(color, hp)
        {
            Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand" + brand + "HP:" + HP + "Color:" + Color);
        }

        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired", Model);
        }
    }
}
