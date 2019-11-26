namespace TenDesignPatterns.Models.Interfaces
{
    public interface ICar : IVehicle
    {
        string Color { get; set; }

        int NumberOfPassengers { get; set; }
    }
}