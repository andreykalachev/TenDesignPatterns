using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenDesignPatterns.Models;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Factories
{
    class MercedesFactory : IAbstractVehicleFactory
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
