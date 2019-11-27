using TenDesignPatterns.Models.Commands.Interfaces;

namespace TenDesignPatterns.Models.Commands
{
    public class Invoker
    {
        private ICommand _commandForGoodClients;
        private ICommand _commandForAverageClients;
        private ICommand _commandForBadClients;

        public Invoker(ICommand commandForGoodClients, ICommand commandForBadClients, ICommand commandForAverageClients)
        {
            _commandForGoodClients = commandForGoodClients;
            _commandForBadClients = commandForBadClients;
            _commandForAverageClients = commandForAverageClients;
        }

        public void PaintCars()
        {
            _commandForGoodClients.Execute();
            _commandForBadClients.Execute();
            _commandForAverageClients.Execute();
        }
    }
}