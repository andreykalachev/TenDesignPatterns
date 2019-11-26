using System;
using TenDesignPatterns.Factories;
using static TenDesignPatterns.Experiments;

namespace TenDesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Abstract Factory

            GetAllVehiclesInfo();

            #endregion

            #region Singleton

            AddCarsToStorage(new VolvoFactory(), 5);

            #endregion

            #region Facade

            SaveAllVehiclesToFile();
            GetAllVehiclesFromFile();

            #endregion

            #region Iterator

            PrintAllVehiclesInfoUsingIteratorPattern();

            #endregion

            Console.ReadKey();
        }
    }
}