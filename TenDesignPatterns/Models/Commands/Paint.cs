using TenDesignPatterns.Models.Commands.Interfaces;
using TenDesignPatterns.Models.Interfaces;
using ICommand = TenDesignPatterns.Models.Commands.Interfaces.ICommand;

namespace TenDesignPatterns.Models.Commands
{
    public class Paint : ICommand
    {
        private IPainter _painter;
        private IVehicle _vehicle;
        private string _color;

        public Paint(IVehicle vehicle, IPainter painter, string color)
        {
            _vehicle = vehicle;
            _painter = painter;
            _color = color;
        }

        public bool CanExecute()
        {
            return _vehicle is ICar && _painter.AvailableColors.Contains(_color);
        }

        public void Execute()
        {
            if (CanExecute())
            {
                _painter.Paint(((ICar)_vehicle), _color);
            }
        }
    }
}