namespace TenDesignPatterns.Models.States
{
    public abstract class State
    {
        protected StateContext StateContext;

        public void SetContext(StateContext stateContext)
        {
            StateContext = stateContext;
        }

        public abstract void AddCarsToGarage();

        public abstract void AddTrucksToSGarage();

        public abstract void PrintFavorite();
    }
}