using System;
using TenDesignPatterns.Factories;

namespace TenDesignPatterns.Models.States
{
    public class VolvoLover : State
    {
        private IAbstractVehicleFactory _factory = new VolvoFactory();

        public override void AddCarsToGarage()
        {
            Experiments.AddCarsToStorage(_factory, 3);
            Console.WriteLine("\nI think Mercedes makes better cars\n");
            StateContext.ChangeStateTo(new MercedesLoverState());
        }

        public override void AddTrucksToSGarage()
        {
            Experiments.AddCarsToStorage(_factory, 3);
            Console.WriteLine("\nAlways buy Volvo trucks\n");
        }

        public override void PrintFavorite()
        {
            Console.WriteLine("\nMy favorite is Volvo");
        }
    }
}
