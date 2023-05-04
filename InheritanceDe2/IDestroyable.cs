using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDe2
{
    internal interface IDestroyable
    {
        //property to store that audio file of the destruction sound
        string DestructionSound { get; set; }

        //method to destroy an object
        void Destroy();
    }
}
