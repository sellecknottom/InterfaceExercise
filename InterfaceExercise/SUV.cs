using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public string EngineType { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public bool IsDomestic { get; set; }
        public int NumberOfWheelDrive { get; set; }
        public bool CanOffRoad { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"{EngineType}\n" +
                $"{Year}\n" +
                $"{Make}\n" +
                $"{Model}\n" +
                $"{Logo}\n" +
                $"{(IsDomestic ? "Is a U.S. company" : "Is an international company")} \n" +
                $"{NumberOfWheelDrive}\n" +
                $"{(CanOffRoad ? "It can go off road" : "It cannot go off road")}\n" +
                $"");
        }
    }
}
