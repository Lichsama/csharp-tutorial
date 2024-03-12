using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    class Chair : Furniture, IDestroyAble
    {
        public string DestructionSound { get; set; }

      public Chair(string color,string material)
        {
            Color = color;
            Material = material;
            DestructionSound = "ChairDest.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine("The {0} chair was Destroyed",Color);
            Console.WriteLine("Playing destruction sound {0}",DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }

    }
}
