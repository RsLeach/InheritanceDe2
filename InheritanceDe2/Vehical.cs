using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDe2
{
    internal class Vehical
    {
        public float Speed { get; set; }
        public string Color { get; set; }

        //default constructor
        public Vehical()
        {
            Speed = 120f;
            Color = "White";
        }

        public Vehical(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
