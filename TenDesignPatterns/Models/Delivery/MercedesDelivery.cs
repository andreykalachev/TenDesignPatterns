using System;
using TenDesignPatterns.Factories;
using TenDesignPatterns.Persistence;
using TenDesignPatterns.Services.EventManager;

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
            var logger = new ConsoleLogger();
            var storage = VehicleStorage.GetInstance();

            storage.EventManager.Subscribe(logger);

            while (!HaveEnoughTrucks())
            {
                var newTruck = factory.CreateTruck();
                storage.Add(newTruck);
            }

            storage.EventManager.Unsubscribe(logger);
        }

        public override void Report()
        {
            Console.WriteLine("Mercedes is the best");
        }
    }
}