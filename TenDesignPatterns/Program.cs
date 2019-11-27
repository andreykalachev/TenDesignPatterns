using System;
using static TenDesignPatterns.Experiments;

namespace TenDesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Observer

            //commented out to demonstrate template method

            //var vehicleStorage = VehicleStorage.GetInstance();
            //var observer = new ConsoleLogger();

            //vehicleStorage.EventManager.Subscribe(observer);

            #endregion

            #region Abstract Factory

            //commented out to demonstrate template method

            //GetAllVehiclesInfo();

            #endregion

            #region Singleton

            //commented out to demonstrate template method

            //AddCarsToStorage(new VolvoFactory(), 5);

            #endregion

            #region Facade

            //commented out to demonstrate template method

            //SaveAllVehiclesToFile();
            //GetAllVehiclesFromFile();

            #endregion

            #region Iterator

            //commented out to demonstrate template method

            //PrintAllVehiclesInfoUsingIteratorPattern();

            #endregion

            #region Template

            TestDeliveryTemplate();

            #endregion

            Console.ReadKey();
        }
    }
}