namespace Weather.Model.Entities.Base;

public abstract class TimeSeries : ITimeSeries
{
    public DateTime Timestamp { get; set; }
    public double Value { get; set; }
}

public interface ITimeSeries
{
    public DateTime Timestamp { get; set; }
    public double Value { get; set; }
}