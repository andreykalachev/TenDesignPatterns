using System.Collections.Generic;
using System.Linq;
using TenDesignPatterns.Models.Interfaces;
using TenDesignPatterns.Persistence;

namespace TenDesignPatterns.Services
{
    public class VehicleStorageToFileAdapter
    {
        public IEnumerable<IVehicle> Vehicles
        {
            get
            {
                return _vehicleStorage.Vehicles;
            }
            set
            {
                _vehicleStorage.Vehicles = value.ToList();
            }
        }

        private readonly VehicleStorage _vehicleStorage;
        private readonly VehicleToFileLogger _vehicleToFileLogger;

        public VehicleStorageToFileAdapter()
        {
            _vehicleStorage = VehicleStorage.GetInstance();
            _vehicleToFileLogger = new VehicleToFileLogger(_vehicleStorage.Vehicles);
        }

        public void SaveVehicles()
        {
            _vehicleToFileLogger.Vehicles = Vehicles;
            _vehicleToFileLogger.SaveVehicles();
        }

        public void GetVehicles()
        {
            _vehicleToFileLogger.GetVehicles();
            Vehicles = _vehicleToFileLogger.Vehicles;
        }
    }
}