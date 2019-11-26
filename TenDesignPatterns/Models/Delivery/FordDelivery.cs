using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenDesignPatterns.Factories;
using TenDesignPatterns.Persistence;

namespace TenDesignPatterns.Models.Delivery
{
    public class FordDelivery : Delivery
    {
        public FordDelivery(int distance, int capacity) : base(distance, capacity)
        {
        }

        public override void BuildSomeTrucks()
        {
            var factory = new MercedesFactory();
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
            Console.WriteLine("I love Ford!");
        }

        public override void EndDelivery()
        {
            Console.WriteLine("Ford is better then Mercedes!");
            base.EndDelivery();
        }
    }
}