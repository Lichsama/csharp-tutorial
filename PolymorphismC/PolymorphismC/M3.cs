using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    internal class M3:BMW
    {

        public M3(string color, int hp, string model) : base(color, hp,model)
        {
            Model = model;
        }

        /*
        public override void Repair()
        {
            base.Repair();
        }
        */
    }
}
