using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            Car car = new Car();
            car.EngineType = "V4";
            car.Make = "Toyota";
            car.Model = "Corolla";
            car.Year = 2001;
            car.Logo = "Toyota Logo";
            car.IsDomestic = false;
            car.HasTrunk = true;
            car.IsSportsCar = false;

            car.DisplayDetails();

            Truck truck = new Truck();
            truck.EngineType = "V8";
            truck.Make = "Ford";
            truck.Model = "F-150";
            truck.Year = 2021;
            truck.Logo = "Ford Logo";
            truck.IsDomestic = true;
            truck.HasExtendedCab = true;
            truck.HasExtendedBed = true;

            truck.DisplayDetails();

            SUV suv = new SUV();
            suv.EngineType = "V6";
            suv.Make = "Jeep";
            suv.Model = "Cherokee";
            suv.Year = 2015;
            suv.Logo = "Jeep Logo";
            suv.IsDomestic= true;
            suv.NumberOfWheelDrive = 4;
            suv.CanOffRoad = true;

            suv.DisplayDetails();
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
