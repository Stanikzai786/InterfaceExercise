using InterfaceExercise;
using System;
using System.Collections.Generic;
namespace InterfaceExercise
{
    class program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var truck = new Truck();
            var vehicles = new List<IVehicle>() { car, truck };
            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.Reverse();
            }

        }
    }
}
