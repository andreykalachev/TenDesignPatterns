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
        public int Size { get; set; }
        public int CarryingCapacity { get; set; }

        public MercedesTruck()
        {
            Size = 10;
            CarryingCapacity = 10;
        }

        public void Drive()
        {
            Console.WriteLine("Drive Mercedes Truck");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Mercedes Truck");
        }

        public string Info()
        {
            return $"This is Mercedes Truck;\t size: {Size};\t carrying capacity: {CarryingCapacity}";
        }

    }
}
