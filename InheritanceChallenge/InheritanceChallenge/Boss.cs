using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    internal class Boss : Employee
    {
        public string CompanyCar;


        public Boss() { }

        public Boss(string name, string firstName, int salary,string companycar) : base(name, firstName, salary)
        {
            CompanyCar = companycar;
        }

        public void Lead()
        {
            Console.WriteLine("I'm boss! My name is {0} {1}",Name,FirstName);
        }

    }
}
