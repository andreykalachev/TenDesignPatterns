using System.Collections;
using System.Collections.Generic;
using TenDesignPatterns.Models.Interfaces;
using TenDesignPatterns.Services.EventManager;

namespace TenDesignPatterns.Persistence
{
    public class VehicleStorage : IEnumerable<IVehicle>
    {
        public List<IVehicle> Vehicles { get; set; }

        public EventManager EventManager { get; set; }

        public int Count
        {
            get { return Vehicles.Count; }
        }

        private static VehicleStorage _instance;
        private static readonly object Lock = new object();

        private VehicleStorage()
        {
            Vehicles = new List<IVehicle>();
            EventManager = new EventManager();
        }

        public void Add(IVehicle vehicle)
        {
            Vehicles.Add(vehicle);
            EventManager.Notify("Adding");
        }

        public void Remove(IVehicle vehicle)
        {
            Vehicles.Remove(vehicle);
            EventManager.Notify("Removing");
        }

        public void Clear()
        {
            Vehicles.Clear();
            EventManager.Notify("Clearing");
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

        public IEnumerator<IVehicle> GetEnumerator()
        {
            return new VehicleStorageEnumerator(Vehicles);
        }
    }
}