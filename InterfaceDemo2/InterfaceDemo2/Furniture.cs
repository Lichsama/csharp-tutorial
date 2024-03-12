using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    class Furniture
    {
        public string Color { get; set; }

        public string Material { get; set; }   

        public Furniture()
        {
            Color = "White";
            Material = "Wood";
        }

        public Furniture(String color,string material)
        {
            Color = color;
            Material = material;
        }

    }
}
