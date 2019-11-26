using System;
using TenDesignPatterns.Factories;
using static TenDesignPatterns.Experiments;

namespace TenDesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // abstract factory usage - start
            GetAllVehiclesInfo();
            // abstract factory usage - end

            //singleton usage - start
            AddCarsToStorage(new VolvoFactory(), 5);
            //singleton usage - end

            //facade usage - start
            SaveAllVehiclesToFile();
            GetAllVehiclesFromFile();
            //facade usage - end

            Console.ReadKey();
        }
    }
}
