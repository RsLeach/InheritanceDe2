using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDe2
{
    internal class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }
        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            DestructionSound = "ChairDestructionSound.mp3";
        }

        //implementing interface destroy method
        public void Destroy()
        {
            //when a chair gets destroyed play destruction sound
            //spawn the destroyed chair parts
            Console.WriteLine("The {0} chair was destroyed", Color);
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }
    }
}
