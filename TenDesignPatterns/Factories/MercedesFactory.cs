using System;
using TenDesignPatterns.Models;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Factories
{
    public class MercedesFactory : IAbstractVehicleFactory
    {
        public ICar CreateCar()
        {
            Console.WriteLine("Mercedes Car is built");
            return new MercedesCar();
        }

        public ITruck CreateTruck()
        {
            Console.WriteLine("Mercedes Truck is built");
            return new MercedesTruck();
        }
    }
}