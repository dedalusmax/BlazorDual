using BlazorDual.Shared.Models;
using BlazorDual.Shared.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDual.BlazorWasm.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> GetAsync()
        {
            return await _weatherForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}