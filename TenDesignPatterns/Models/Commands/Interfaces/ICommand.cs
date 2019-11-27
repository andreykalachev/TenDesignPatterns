namespace TenDesignPatterns.Models.Commands.Interfaces
{
    public interface ICommand
    {
        bool CanExecute();

        void Execute();
    }
}