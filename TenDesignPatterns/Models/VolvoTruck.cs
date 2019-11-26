using System;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Models
{
    public class VolvoTruck : ITruck
    {
        public int Size { get; set; }

        public int CarryingCapacity { get; set; }

        public VolvoTruck()
        {
            Size = 20;
            CarryingCapacity = 15;
        }

        public void Drive()
        {
            Console.WriteLine("Drive Volvo Truck");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Volvo Truck");
        }

        public string GetInfo()
        {
            return $"This is Volvo Truck;\t size: {Size};\t carrying capacity: {CarryingCapacity}";
        }
    }
}