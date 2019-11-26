using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenDesignPatterns.Factories;
using TenDesignPatterns.Persistence;
using TenDesignPatterns.Services;

namespace TenDesignPatterns
{
    class Program
    {
        public static void FactoryVehiclesInfo(IAbstractVehicleFactory abstractFactory)
        {
            var car = abstractFactory.CreateCar();
            var truck = abstractFactory.CreateTruck();

            Console.WriteLine(car.Info());
            Console.WriteLine(truck.Info());
        } 
        static void Main(string[] args)
        {
            // abstract factory usage
            var mercedesFactory = new MercedesFactory();
            FactoryVehiclesInfo(mercedesFactory);
            Console.WriteLine();

            var volvoFactory = new VolvoFactory();
            FactoryVehiclesInfo(volvoFactory);
            // abstract factory usage


            //singleton usage
            Console.WriteLine("\nBuilding loop----");
            for (var i = 0; i < 5; i++)
            {
                //
                VehicleStorage.GetInstance().Add(volvoFactory.CreateCar());
            }
            Console.WriteLine($"\nYou have built {VehicleStorage.GetInstance().Count} cars in a loop\n");
            //singleton usage


            //facade usage
            Console.WriteLine("saving vehicles...");
            VehicleToFileLogger.SaveVehicles(VehicleStorage.GetInstance().GetAll());
            var savedVehicles = VehicleToFileLogger.GetVehicles();
            Console.WriteLine($"you have {savedVehicles?.Count()} vehicles saved");
            //facade usage


            Console.ReadKey();
        }
    }
}
