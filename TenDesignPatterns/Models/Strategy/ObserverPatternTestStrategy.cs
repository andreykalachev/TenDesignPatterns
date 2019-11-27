using TenDesignPatterns.Models.Strategy.Interfaces;
using TenDesignPatterns.Persistence;
using TenDesignPatterns.Services.EventManager;

namespace TenDesignPatterns.Models.Strategy
{
    public class ObserverPatternTestStrategy : IStrategy
    {
        public void Execute()
        {
            var vehicleStorage = VehicleStorage.GetInstance();
            var observer = new ConsoleLogger();

            vehicleStorage.EventManager.Subscribe(observer);
        }
    }
}