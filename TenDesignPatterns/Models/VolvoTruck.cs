using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Models
{
    class VolvoTruck : ITruck
    {
        public void Drive()
        {
            Console.WriteLine("Drive Volvo Truck");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Volvo Truck");
        }

        public void Info()
        {
            Console.WriteLine("This is Volvo Truck");
        }

        public int Size { get; set; }
        public int CarryingCapacity { get; set; }
    }
}
