using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void Info()
        {
            Console.WriteLine($"This is MercedesCar Car;\t color: {Color};\t number of passengers: {NumberOfPassengers}");
        }
    }
}
