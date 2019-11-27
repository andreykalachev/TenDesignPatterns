using static TenDesignPatterns.Experiments;
using TenDesignPatterns.Models.Strategy.Interfaces;

namespace TenDesignPatterns.Models.Strategy
{
    public class AbstractFactoryPatternTestStrategy : IStrategy
    {
        public void Execute()
        {
            GetAllVehiclesInfo();
        }
    }
}