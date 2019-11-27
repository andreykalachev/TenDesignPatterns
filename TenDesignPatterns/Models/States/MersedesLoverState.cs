using System;
using TenDesignPatterns.Factories;

namespace TenDesignPatterns.Models.States
{
    public class MercedesLoverState : State
    {
        private IAbstractVehicleFactory _factory = new MercedesFactory();

        public override void AddCarsToGarage()
        {
            Experiments.AddCarsToStorage(_factory, 3);
            Console.WriteLine("\nMercedes cars are good\n");
        }

        public override void AddTrucksToSGarage()
        {
            Experiments.AddTrucksToStorage(_factory, 3);
            Console.WriteLine("\nhmm, i don't like Mercedes trucks, i'd rather choose Volvo\n");
            StateContext.ChangeStateTo(new VolvoLover());
        }

        public override void PrintFavorite()
        {
            Console.WriteLine("\nMy favorite is Mercedes");
        }
    }
}
