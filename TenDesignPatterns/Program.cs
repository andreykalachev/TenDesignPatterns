using System;
using TenDesignPatterns.Factories;
using TenDesignPatterns.Models.Delivery;
using TenDesignPatterns.Persistence;
using TenDesignPatterns.Services.EventManager;
using static TenDesignPatterns.Experiments;

namespace TenDesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Observer

            //var vehicleStorage = VehicleStorage.GetInstance();
            //var observer = new ConsoleLogger();

            //vehicleStorage.EventManager.Subscribe(observer);

            #endregion

            #region Abstract Factory

            //GetAllVehiclesInfo();

            #endregion

            #region Singleton

            //AddCarsToStorage(new VolvoFactory(), 5);

            #endregion

            #region Facade

            //SaveAllVehiclesToFile();
            //GetAllVehiclesFromFile();

            #endregion

            #region Iterator

            //PrintAllVehiclesInfoUsingIteratorPattern();

            #endregion

            #region Template

            Delivery mercedesDelivery = new MercedesDelivery(40, 30);
            Delivery fordDelivery = new FordDelivery(10, 350);

            mercedesDelivery.Deliver();
            Console.WriteLine();
            fordDelivery.Deliver();

            #endregion

            Console.ReadKey();
        }
    }
}