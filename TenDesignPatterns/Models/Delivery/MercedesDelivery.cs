using System;
using TenDesignPatterns.Factories;
using TenDesignPatterns.Persistence;

namespace TenDesignPatterns.Models.Delivery
{
    public class MercedesDelivery : Delivery
    {
        public MercedesDelivery(int distance, int capacity) : base(distance, capacity)
        {
        }

        public override void BuildSomeTrucks()
        {
            var factory = new MercedesFactory();
            var storage = VehicleStorage.GetInstance();

            while (!HaveEnoughTrucks())
            {
                var newTruck = factory.CreateTruck();
                storage.Add(newTruck);
            }
        }

        public override void Report()
        {
            Console.WriteLine("Mercedes is the best");
        }
    }
}