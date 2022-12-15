using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle , ICompany
    {
        public Car()
        { 
        }

        public string CompanyName { get; set; } = "Doge";
        public string Motto { get; set; } = "Engine Wineing";
        public double EngineSize { get ; set ; } = 6.4;
        public string Make { get ; set ; } = "Dodge";
        public string Model { get; set; } = "Challanger";
        public int SeatCount { get; set; } = 4;
        public bool HasChangedGears { get ; set ; }
        public void Drive()
        {
            Console.WriteLine($"{GetType().Name}Now Driving Forward...");
        }
        public void Reverse()
           
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name}Now Reversing...");
                HasChangedGears= false;
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
                HasChangedGears= false;
            }
            else
            {
                Console.WriteLine("Can't PaRk until we change Gears!");
            }
        }


        public void ChangeGears(bool isChanged)
        {
            HasChangedGears= isChanged;
        }
    }

}