namespace TrackMyCar.Core.Models;

public class ServiceEntry
{
    public int Id { get; set; }

    public int CarId { get; set; }

    public DateTime Date { get; set; } = DateTime.Today;

    public int Mileage { get; set; }

    public string Description { get; set; } = string.Empty;

    public decimal Cost { get; set; }

    public int? NextServiceMileage { get; set; }
}