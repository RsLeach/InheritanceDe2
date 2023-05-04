using System;

namespace InheritanceDe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating two objects of type chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");
            //creating object type car
            Car damagedCar = new Car(80f, "Blue");
            //adding two chairs to IDestroyable list of the car
            //two chairs will be destroyed when in proximity. 
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            //destroy car
            damagedCar.Destroy();
        }
    }
}
