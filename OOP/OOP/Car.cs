using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        //private member
        //Access modifier private
        //Member variables
        private string _name; // private field typically used for stroing data.
        private int _hp;
        private string _color;
        private int _maxSpeed;

        public int MaxSpeed { set {  _maxSpeed = value; } } // Write Only
        // public int MaxSpeed { get; set; }
       // public int MaxSpeed { get; } = 10; Read Only

        // the public property
        public string Name { get { return _name; } // Get accessor
            set { _name = value; } } // set accessor
        public int getHp()
        {
            return _hp;
        }
        public string getName()
        {
            return _name;
        }
        public void setName(string name)
        {
            if(name=="")
            {
                _name = "DefaulName";
            }
            else
            {
                _name = name;
            }
        }

        // Default Constructor
        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "red";
        }
        // Partial Specifaction Constructor
        public Car(string name, int hp = 0)
        {
            _name = name;
            Console.WriteLine(name + "Car was created.");
            _hp = hp;
            _color = "Red";
        }

        // Full Specifaction Constructor
        public Car(string name, int hp, string color) {
            _name = name;
            Console.WriteLine(name + "Car was created.");
            _hp = hp;
            _color = color;
        }

        //Member methods
        public void Drive()
        {
            Console.WriteLine(_name + "Car is driving");
        }

        public void Stop()
        {
            Console.WriteLine(_name + "Car stopped");
        }

        public void Details()
        {
            Console.WriteLine("The car name is" + _name);
            Console.WriteLine("Horse power is " + _hp);
            Console.WriteLine("The car color is " + _color);
        }
    }
}
