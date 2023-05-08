using System;

namespace InheritanceDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair officeChair = new Chair("Plastic", "Brown");
            Chair gamingChair = new Chair("Wood", "Red");

            Car damagedCar = new Car("Blue", 80f);

            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();
        }
    }
}
