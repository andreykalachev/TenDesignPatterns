using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Factories
{
    public interface IAbstractVehicleFactory
    {
        ICar CreateCar();

        ITruck CreateTruck();
    }
}
