using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Models
{
    public class VolvoCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Drive Volvo Car");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Volvo Car");
        }

        public void Info()
        {
            Console.WriteLine("This is Volvo Car");
        }

        public string Color { get; set; }
        public int NumberOfPassengers { get; set; }
    }
}
