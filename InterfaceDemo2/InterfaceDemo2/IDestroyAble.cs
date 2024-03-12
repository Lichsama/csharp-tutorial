using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    internal interface IDestroyAble
    {
        string DestructionSound { get; set; }

        void Destroy(); 
    }
}
