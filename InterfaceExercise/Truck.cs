using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle , ICompany
    {
        public Truck()
        {
        }

        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Power";
        public double EngineSize { get; set; } = 6.0;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Raptor";
        public int SeatCount { get; set; } = 5;
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; }
        public void Drive()
        {
            if(HasFourWheelDrive == true)
            {
                Console.WriteLine($" 4 Wheel drive{GetType().Name}Now Driving Forward...");
            }
            else
            {
                Console.WriteLine($"{GetType().Name}Now Driving Forward...");
            }
        }
        public void Reverse()

        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name}Now Reversing...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change Gears!");
            }
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name}Now in pArK...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't PaRk until we change Gears!");
            }
        }


        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }

}