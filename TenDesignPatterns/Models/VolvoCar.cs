using System;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Models
{
    public class VolvoCar : ICar
    {
        public string Color { get; set; }

        public int NumberOfPassengers { get; set; }

        public VolvoCar()
        {
            Color = "Blue";
            NumberOfPassengers = 6;
        }

        public void Drive()
        {
            Console.WriteLine("Drive Volvo Car");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Volvo Car");
        }

        public string GetInfo()
        {
            return $"This is Volvo Car;\t color: {Color};\t number of passengers: {NumberOfPassengers}";
        }
    }
}