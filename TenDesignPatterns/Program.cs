using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenDesignPatterns.Factories;

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
            FactoryVehiclesInfo(new MercedesFactory());
            Console.WriteLine();
            FactoryVehiclesInfo(new VolvoFactory());
            Console.ReadKey();
        }
    }
}
