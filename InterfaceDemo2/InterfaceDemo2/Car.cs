using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    class Car : Vehicle,IDestroyAble
    {
        public string DestructionSound {  get; set; }

        public List<IDestroyAble> DestroyablesNearby;

        public Car(float speed,string color) 
        {
            Speed=speed;
            Color = color;
            DestructionSound = "CarExp.mp3";
            DestroyablesNearby = new List<IDestroyAble>();
        }

        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}",DestructionSound);
            Console.WriteLine("Create Fire");
            foreach(IDestroyAble destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }

        }
    }
}
