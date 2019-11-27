using System.Collections.Generic;
using TenDesignPatterns.Models.Commands.Interfaces;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Models.Commands
{
    public class BadPainter : IPainter
    {
        public List<string> AvailableColors { get; set; }

        public BadPainter()
        {
            AvailableColors = new List<string>();
            AvailableColors.Add("Blue");
        }

        public void Paint(ICar car, string color)
        {
            car.Color = "Yellow";
        }
    }
}