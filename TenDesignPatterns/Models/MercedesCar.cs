using System;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Models
{
    public class MercedesCar : ICar
    {
        public string Color { get; set; }
        public int NumberOfPassengers { get; set; }

        public MercedesCar()
        {
            Color = "Red";
            NumberOfPassengers = 2;
        }

        public void Drive()
        {
            Console.WriteLine("Drive MercedesCar Car");
        }

        public void Stop()
        {
            Console.WriteLine("Stop MercedesCar Car");
        }

        public string GetInfo()
        {
            return $"This is MercedesCar Car;\t color: {Color};\t number of passengers: {NumberOfPassengers}";
        }
    }
}