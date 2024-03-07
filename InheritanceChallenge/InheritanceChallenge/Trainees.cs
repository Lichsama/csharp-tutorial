using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    internal class Trainees : Employee
    {
        protected int WorkingHours;
        protected int SchoolHours;

        public Trainees() { }

        public Trainees(string name,string firstname,int salary,int workinghours,int schoolhours) :base(name,firstname,salary)
        { 
            
            WorkingHours = workinghours;
            SchoolHours = schoolhours;
        }

        public new void Work()
        {
            Console.WriteLine("Working Hours is : {0}",this.WorkingHours);
        }

        public void Learn()
        {
            Console.WriteLine("I'm learning for {0} hours!",SchoolHours);
        }
    }
}
