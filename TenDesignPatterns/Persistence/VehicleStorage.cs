using System.Collections;
using System.Collections.Generic;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Persistence
{
    public class VehicleStorage : IEnumerable
    {
        public List<IVehicle> Vehicles { get; set; }

        public int Count
        {
            get { return Vehicles.Count; }
        }

        private static VehicleStorage _instance;
        private static readonly object Lock = new object();

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
            if (_instance == null)
            {
                lock (Lock)
                {
                    if (_instance == null)
                    {
                        _instance = new VehicleStorage();
                    }
                }
            }
            return _instance;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public VehicleStorageEnumerator GetEnumerator()
        {
            return new VehicleStorageEnumerator(Vehicles);
        }
    }
}