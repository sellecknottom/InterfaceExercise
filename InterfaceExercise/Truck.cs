using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public string EngineType { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public bool IsDomestic { get; set; }
        public bool HasExtendedCab { get; set; }
        public bool HasExtendedBed { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"{EngineType}\n" +
                $"{Year}\n" +
                $"{Make}\n" +
                $"{Model}\n" +
                $"{Logo}\n" +
                $"{(IsDomestic ? "Is a U.S.company" : "Is an international company")}\n" +
                $"{(HasExtendedCab ? "It has an extended cab option" : "It does not have an extended cab")}\n" +
                $"{(HasExtendedBed ? "It has an extended bed option" : "It does not have an extended bed")}\n" +
                $"");
        }
    }
}
