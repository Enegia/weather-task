namespace Weather.Data;

public static class DataReader
{
    public static IReadOnlyList<StationData> GetStations()
    {
        return new List<StationData>
        {
            new()
            {
                Id = 1,
                Name = "Kaisaniemi Station",
                City = "Helsinki",
                ConstructionYear = 1970,
            },
            new()
            {
                Id = 2,
                Name = "Airport",
                City = "Jyväskylä",
                ConstructionYear = 1990,
            },
            new()
            {
                Id = 3,
                Name = "Santa Claus",
                City = "Rovaniemi",
                ConstructionYear = 2020,
            },
        };
    }

    public static IReadOnlyList<WeatherData> GetWeatherData()
    {
        var result = new List<WeatherData>();
        for (var i = 1; i < 4; i++)
        {
            var start = new DateTime(2021, 12, 31, 22, 0, 0, DateTimeKind.Utc);
            var end = new DateTime(2022, 1, 31, 22, 0, 0, DateTimeKind.Utc);
            while (end > start)
            {
                result.Add(
                    new WeatherData
                    {
                        StationId = i,
                        Humidity = Math.Round(
                            Random.Shared.NextDouble(),
                            2,
                            MidpointRounding.AwayFromZero),
                        Wind = Random.Shared.Next(0, 25),
                        Temperature = Random.Shared.Next(0, 35),
                        Timestamp = start,
                    });
                start = start.AddHours(1);
            }
        }

        return result;
    }
}