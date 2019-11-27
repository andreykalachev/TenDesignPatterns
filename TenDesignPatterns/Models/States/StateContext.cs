using System;

namespace TenDesignPatterns.Models.States
{
    public class StateContext
    {
        private State _state;

        public StateContext(State state)
        {
            _state = state;
            state.SetContext(this);
        }

        public void ChangeStateTo(State state)
        {
            Console.WriteLine("State is changed");
            _state = state;
            state.SetContext(this);
        }

        public void BuySomeCars()
        {
            _state.AddCarsToGarage();
        }

        public void BuySomeTrucks()
        {
            _state.AddTrucksToSGarage();
        }

        public void PrintYourOpinion()
        {
            _state.PrintFavorite();
        }
    }
}