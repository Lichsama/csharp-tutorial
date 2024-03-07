using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    internal class Employee
    {
       protected string Name {  get; set; }
       protected string FirstName {  get; set; }
       protected int Salary {  get; set; }
     
       public Employee()
        {

        }

        public Employee(string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }
        
        public virtual void Work()
        {
            Console.WriteLine("I'm Working.");
        }

        public virtual void Pause()
        {
            Console.WriteLine("I'm having a break");
        }


 
        


    }
}
