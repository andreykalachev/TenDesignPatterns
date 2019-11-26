using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Persistence
{
    public class VehicleStorage
    {
        public List<IVehicle> Vehicles { get; set; }
        public int Count => Vehicles.Count;

        private static VehicleStorage _instance;
 

        private VehicleStorage()
        {
            Vehicles = new List<IVehicle>();
        }

        public void Add(IVehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public void Remove(IVehicle vehicle)
        {
            Vehicles.Remove(vehicle);
        }

        public void Clear()
        {
            Vehicles.Clear();
        }

        public IEnumerable<IVehicle> GetAll()
        {
            return Vehicles;
        }

        public static VehicleStorage GetInstance()
        {
            return _instance ?? (_instance = new VehicleStorage());
        }
    }
}
