using TenDesignPatterns.Models.Interfaces;
using ICommand = TenDesignPatterns.Models.Commands.Interfaces.ICommand;

namespace TenDesignPatterns.Models.Commands
{
    public class PaintInGreen : ICommand
    {
        private IVehicle _vehicle;

        public PaintInGreen(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public bool CanExecute()
        {
            return _vehicle is ICar;
        }

        public void Execute()
        {
            if (CanExecute())
            {
                ((ICar) _vehicle).Color = "Green";
            }
        }
    }
}