using System.Net;
using Microsoft.AspNetCore.Mvc;
using Weather.Model;
using Weather.Model.Entities;

namespace Weather.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherController : ControllerBase
{
    private readonly IWeatherDataContext _weatherDataContext;

    // Task 3: Create an endpoint, that returns combined wind and temperature within same payload for given station
    // Example: [{ "dt": "2022-01-01", "wind": 100, "temperature": 200, ... },...]
    //public ...(int stationId)
    //{
    //}

    // Task 4: DataReader class in Data-project, contains information about humidity. Implement it through solution and return it from endpoint
    [HttpGet("humidity/{stationId:int}")]
    [ProducesResponseType(typeof(void), (int) HttpStatusCode.NotImplemented)]
    public async Task<IActionResult> GetHumidityForStation([FromRoute] int stationId)
    {
        return StatusCode((int)HttpStatusCode.NotImplemented);
    }
}