using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Factories
{
    public interface IAbstractVehicleFactory
    {
        ICar CreateCar();
        ITruck CreateTruck();
    }
}
