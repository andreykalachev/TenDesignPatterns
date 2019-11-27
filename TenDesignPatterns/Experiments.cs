using System;
using System.Linq;
using TenDesignPatterns.Factories;
using TenDesignPatterns.Models.Delivery;
using TenDesignPatterns.Persistence;
using TenDesignPatterns.Services;

namespace TenDesignPatterns
{
    public static class Experiments
    {
        public static void Print(string s = null)
        {
            Console.WriteLine(s ?? string.Empty);
        }

        private static void GetFactoryVehiclesInfo(IAbstractVehicleFactory abstractFactory)
        {
            var car = abstractFactory.CreateCar();
            var truck = abstractFactory.CreateTruck();

            Print(car.GetInfo());
            Print(truck.GetInfo());
            Print();
        }

        public static void GetAllVehiclesInfo()
        {
            var mercedesFactory = new MercedesFactory();
            var volvoFactory = new VolvoFactory();

            GetFactoryVehiclesInfo(mercedesFactory);
            GetFactoryVehiclesInfo(volvoFactory);
        }

        public static void AddCarsToStorage(IAbstractVehicleFactory factory, int numberOfCars)
        {
            Print("\nBuilding loop----");
            for (var i = 0; i < 5; i++)
            {
                var car = factory.CreateCar();
                var storage = VehicleStorage.GetInstance();
                storage.Add(car);
            }
            Print($"\nYou have built {VehicleStorage.GetInstance().Count} cars in a loop\n");
        }

        public static void SaveAllVehiclesToFile(VehicleToFileLogger vehicleToFileLogger)
        {
            Print("saving vehicles...");
            var allVehicles = VehicleStorage.GetInstance().GetAll().ToList();

            vehicleToFileLogger.Vehicles = allVehicles;
            vehicleToFileLogger.SaveVehicles();
        }

        public static void GetAllVehiclesFromFile(VehicleToFileLogger vehicleToFileLogger)
        {
            vehicleToFileLogger.GetVehicles();
            Print($"you have {vehicleToFileLogger.Vehicles?.Count()} vehicles saved");
        }

        public static void SaveVehicleStorageToFile(VehicleStorageToFileAdapter vehicleStorageToFileAdapter)
        {
            Print("saving vehicles...");
            vehicleStorageToFileAdapter.SaveVehicles();
        }

        public static void GetAllVehiclesFromFile(VehicleStorageToFileAdapter vehicleStorageToFileAdapter)
        {
            vehicleStorageToFileAdapter.GetVehicles();
            Print($"you have {vehicleStorageToFileAdapter.Vehicles?.Count()} vehicles saved");
        }

        public static void PrintAllVehiclesInfoUsingIteratorPattern()
        {
            var vehicleStorage = VehicleStorage.GetInstance();

            Print("\nforeach loop through all vehicles");
            foreach (var vehicle in vehicleStorage)
            {
                Print(vehicle.GetInfo());
            }
        }

        public static void TestDeliveryTemplate()
        {
            var mercedesDelivery = new MercedesDelivery(40, 30);
            var volvoDelivery = new VolvoDelivery(10, 350);

            TestDeliveryTemplate(mercedesDelivery);
            TestDeliveryTemplate(volvoDelivery);
        }

        private static void TestDeliveryTemplate(Delivery delivery)
        {
            delivery.Deliver();
            Console.WriteLine();
        }
    }
}