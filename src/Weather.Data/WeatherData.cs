namespace Weather.Data;

public class WeatherData
{
    public long StationId { get; set; }
    public double Temperature { get; set; }
    public double Wind { get; set; }
    public double Humidity { get; set; }
    public DateTime Timestamp { get; set; }
}