using TenDesignPatterns.Factories;
using static TenDesignPatterns.Experiments;
using TenDesignPatterns.Models.Strategy.Interfaces;
using TenDesignPatterns.Services;

namespace TenDesignPatterns.Models.Strategy
{
    public class AdapterPatternStrategyTest : IStrategy
    {
        public void Execute()
        {
            var vehicleStorageToFileAdapter = new VehicleStorageToFileAdapter();

            AddCarsToStorage(new VolvoFactory(), 5);

            SaveVehicleStorageToFile(vehicleStorageToFileAdapter);
            GetAllVehiclesFromFile(vehicleStorageToFileAdapter);
        }
    }
}