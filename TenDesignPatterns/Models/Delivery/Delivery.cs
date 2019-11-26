using System;
using System.Linq;
using TenDesignPatterns.Models.Interfaces;
using TenDesignPatterns.Persistence;

namespace TenDesignPatterns.Models.Delivery
{
    public abstract class Delivery
    {
        public int Distance { get; set; }

        public int Capacity { get; set; }

        protected Delivery(int distance, int capacity)
        {
            Distance = distance;
            Capacity = capacity;
        }

        public void Deliver()
        {
            StartDelivery();

            if (!HaveEnoughTrucks())
            {
                BuildSomeTrucks();
            }

            DeliverCargo();
            Report();
            EndDelivery();
        }

        public virtual void StartDelivery()
        {
            Console.WriteLine($"Starting a delivery;\t distance is {Distance}");
        }

        public virtual bool HaveEnoughTrucks()
        {
            var storage = VehicleStorage.GetInstance();
            var totalTruckCapacity = storage.GetAll().Where(x => x is ITruck).Sum(x => ((ITruck) x).CarryingCapacity);

            return totalTruckCapacity > Capacity;
        }

        public abstract void BuildSomeTrucks();

        public virtual void DeliverCargo()
        {
            Console.WriteLine("delivering...");
        }

        public abstract void Report();

        public virtual void EndDelivery()
        {
            Console.WriteLine($"Delivery is completed");
        }
    }
}