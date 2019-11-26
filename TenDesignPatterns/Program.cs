using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenDesignPatterns.Factories;
using TenDesignPatterns.Persistence;

namespace TenDesignPatterns
{
    class Program
    {
        public static void FactoryVehiclesInfo(IAbstractVehicleFactory abstractFactory)
        {
            var car = abstractFactory.CreateCar();
            var truck = abstractFactory.CreateTruck();

            car.Info();
            truck.Info();
        } 
        static void Main(string[] args)
        {
            var mercedesFactory = new MercedesFactory();
            FactoryVehiclesInfo(mercedesFactory);
            Console.WriteLine();

            var volvoFactory = new VolvoFactory();
            FactoryVehiclesInfo(volvoFactory);

            Console.WriteLine("\nBuilding loop----");
            for (var i = 0; i < 5; i++)
            {
                VehicleStorage.GetInstance().Add(volvoFactory.CreateCar());
            }
            Console.WriteLine($"\nYou have built {VehicleStorage.GetInstance().Count} cars in a loop\n");

            Console.ReadKey();
        }
    }
}
