namespace TenDesignPatterns.Models.Interfaces
{
    public interface ITruck : IVehicle 
    {
        int Size { get; set; }

        int CarryingCapacity { get; set; }
    }
}