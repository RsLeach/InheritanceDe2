﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDe2
{
    internal class Car : Vehical, IDestroyable
    {
        //implementing the interfaces property
        public string DestructionSound { get; set; }

        /*Creating a new property to store the destroyable objects nearby
          when a car gets destroyed it should also destroy the nearby object
          this list is of type IDestroyable which means it can store any object
          that implements this interface and we can only access the properties and
          methods in this interface*/
        public List<IDestroyable> DestroyablesNearby;

        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
            DestructionSound = "CarExplosionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        //implementing the interface's method
        public void Destroy()
        {
            //when a car gets destroyed, play destruction sound
            //and create fire effect
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");
            //go through each destroyable object nearby and call it's destroy method
            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
        
    }
}
