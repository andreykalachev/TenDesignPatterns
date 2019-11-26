using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Persistence
{
    public class VehicleStorageEnumerator : IEnumerator<IVehicle>
    {
        private readonly IList<IVehicle> _vehicles;
        private int _position = -1;

        public VehicleStorageEnumerator(IList<IVehicle> vehicles)
        {
            _vehicles = vehicles;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _vehicles.Count;
        }

        public void Reset()
        {
            _position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public IVehicle Current
        {
            get
            {
                try
                {
                    return _vehicles.ElementAt(_position);
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        void IDisposable.Dispose() { }
    }
}