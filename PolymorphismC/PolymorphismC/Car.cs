using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    internal class Car
    { 


        public string Color {  get; set; } 
        public int HP { get; set; }

        // has a relationship
        protected CarIDInfo carIDInfo=new CarIDInfo();
        public void SetCarIDInfo(int idNum,string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}",carIDInfo.IDNum,carIDInfo.Owner);
        }

        public Car(string color,int hp)
        {
            this.Color = color;
            this.HP = hp;
        }


        public void ShowDetails()
        {
            Console.WriteLine("Color is:{0}\nHp is:{1}",Color,HP);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
