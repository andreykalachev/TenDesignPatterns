using System.Collections.Generic;
using TenDesignPatterns.Models.Commands.Interfaces;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Models.Commands
{
    public class GoodPainter : IPainter
    {
        public List<string> AvailableColors { get; set; }

        public GoodPainter()
        {
            AvailableColors = new List<string> {"Green", "Red", "Blue", "Orange"};
        }

        public void Paint(ICar car, string color)
        {
            car.Color = color;
        }
    }
}