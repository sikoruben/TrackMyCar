namespace TrackMyCar.Core.Models;

public class FuelEntry
{
    public int Id { get; set; }

    public int CarId { get; set; }

    public DateTime Date { get; set; } = DateTime.Today;

    public int Mileage { get; set; }

    public double Liters { get; set; }

    public decimal TotalPrice { get; set; }

    public decimal PricePerLiter =>
        Liters > 0 ? TotalPrice / (decimal)Liters : 0;
}