namespace TrackMyCar.Core.Models;

public class Car
{
    public int Id { get; set; }

    public string Brand { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public string LicensePlate { get; set; } = string.Empty;

    public int ProductionYear { get; set; }

    public int CurrentMileage { get; set; }

    public string DisplayName => $"{Brand} {Model}";

    public ICollection<FuelEntry> FuelEntries { get; set; } =
        new List<FuelEntry>();

    public ICollection<ServiceEntry> ServiceEntries { get; set; } =
        new List<ServiceEntry>();
}