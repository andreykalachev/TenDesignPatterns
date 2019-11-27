using TenDesignPatterns.Factories;
using TenDesignPatterns.Models.Strategy.Interfaces;
using TenDesignPatterns.Persistence;
using TenDesignPatterns.Services.EventManager;
using static TenDesignPatterns.Experiments;

namespace TenDesignPatterns.Models.Strategy
{
    public class AllPatternsTestStrategy : IStrategy
    {
        public void Execute()
        {
            #region Observer

            var vehicleStorage = VehicleStorage.GetInstance();
            var observer = new ConsoleLogger();

            vehicleStorage.EventManager.Subscribe(observer);

            #endregion

            #region Abstract Factory

            GetAllVehiclesInfo();

            #endregion

            #region Singleton

            AddCarsToStorage(new VolvoFactory(), 5);

            #endregion

            #region Facade

            SaveAllVehiclesToFile();
            GetAllVehiclesFromFile();

            #endregion

            #region Iterator

            PrintAllVehiclesInfoUsingIteratorPattern();

            #endregion

            #region Template

            TestDeliveryTemplate();

            #endregion
        }
    }
}