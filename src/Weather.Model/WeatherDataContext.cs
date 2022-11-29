using Weather.Data;
using Weather.Model.Entities;

namespace Weather.Model;

public interface IWeatherDataContext
{
    /// <summary>
    ///     Provides stations
    /// </summary>
    Task<IQueryable<Station>> StationsAsync { get; }

    /// <summary>
    ///     Provides temperatures
    /// </summary>
    Task<IQueryable<Temperature>> TemperatureAsync { get; }

    /// <summary>
    ///     Provides wind data
    /// </summary>
    Task<IQueryable<Wind>> WindAsync { get; }

    /// <summary>
    ///     Adds stations to station queryable
    /// </summary>
    /// <param name="station"></param>
    /// <returns></returns>
    Task AddStationAsync(Station station);
}

public class WeatherDataContext : IWeatherDataContext
{
    public WeatherDataContext()
    {
        var weatherData = DataReader.GetWeatherData();
        var stationData = DataReader.GetStations();

        StationsAsync = Task.FromResult(stationData
            .Select(
                s => new Station
                {
                    Id = s.Id,
                    City = s.City,
                    ConstructionYear = s.ConstructionYear,
                    Name = s.Name,
                })
            .AsQueryable());

        TemperatureAsync = Task.FromResult(weatherData.Select(
                w => new Temperature
                {
                    StationId = w.StationId,
                    Timestamp = w.Timestamp,
                    Value = w.Temperature,
                })
            .AsQueryable());

        WindAsync = Task.FromResult(weatherData.Select(
                w => new Wind
                {
                    StationId = w.StationId,
                    Timestamp = w.Timestamp,
                    Value = w.Temperature,
                })
            .AsQueryable());
    }

    public Task<IQueryable<Station>> StationsAsync { get; private set; }
    public Task<IQueryable<Temperature>> TemperatureAsync { get; }
    public Task<IQueryable<Wind>> WindAsync { get; }
    public async Task AddStationAsync(Station station)
    {
        var stationsQueryable = await StationsAsync;
        var stationList = stationsQueryable.ToList();
        stationList.Add(station);
        StationsAsync = Task.FromResult(stationList.AsQueryable());
    }
}