namespace Weather.Model.Entities.Base;

public abstract class StationSeries : TimeSeries
{
    public long StationId { get; set; }
}