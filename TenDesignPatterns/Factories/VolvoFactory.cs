﻿using System;
using TenDesignPatterns.Models;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Factories
{
    public class VolvoFactory : IAbstractVehicleFactory
    {
        public ICar CreateCar()
        {
            Console.WriteLine("Volvo Car is built");
            return new VolvoCar();
        }

        public ITruck CreateTruck()
        {
            Console.WriteLine("Volvo Truck is built");
            return new VolvoTruck();
        }
    }
}