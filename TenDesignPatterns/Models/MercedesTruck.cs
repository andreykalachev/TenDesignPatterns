using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenDesignPatterns.Models.Interfaces;

namespace TenDesignPatterns.Models
{
    class MercedesTruck : ITruck
    {
        public void Drive()
        {
            Console.WriteLine("Drive Mercedes Truck");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Mercedes Truck");
        }

        public void Info()
        {
            Console.WriteLine("This is Mercedes Truck");
        }

        public int Size { get; set; }
        public int CarryingCapacity { get; set; }
    }
}
