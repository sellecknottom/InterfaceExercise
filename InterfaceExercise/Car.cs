using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public string EngineType { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public bool IsDomestic { get; set; }
        public bool HasTrunk { get; set; }
        public bool IsSportsCar { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"{EngineType}\n" +
                $"{Year}\n" +
                $"{Make}\n" +
                $"{Model}\n" +
                $"{Logo}\n" +
                $"{(IsDomestic ? "Is a U.S.company" : "Is an international company")}\n" +
                $"{(HasTrunk ? "It has a trunk" : "It does not have a trunk")}\n" +
                $"{(IsSportsCar ? "It is a sports car" : "It is not a sports car")}\n" +
                $"");
        }
    }
}
