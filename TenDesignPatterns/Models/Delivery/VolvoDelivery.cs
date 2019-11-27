using System;
using TenDesignPatterns.Factories;
using TenDesignPatterns.Persistence;

namespace TenDesignPatterns.Models.Delivery
{
    public class VolvoDelivery : Delivery
    {
        public VolvoDelivery(int distance, int capacity) : base(distance, capacity)
        {
        }

        public override void BuildSomeTrucks()
        {
            var factory = new VolvoFactory();
            var storage = VehicleStorage.GetInstance();

            for (var i = 0; i < 10; i++)
            {
                var newTruck = factory.CreateTruck();
                storage.Add(newTruck);
            }

            while (!HaveEnoughTrucks())
            {
                var newTruck = factory.CreateTruck();
                storage.Add(newTruck);
            }
        }

        public override void Report()
        {
            Console.WriteLine("I love Volvo!");
        }

        public override void EndDelivery()
        {
            Console.WriteLine("Volvo is better then Mercedes!");
            base.EndDelivery();
        }
    }
}