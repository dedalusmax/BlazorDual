using BlazorDual.Shared.Models;
using System;
using System.Threading.Tasks;

namespace BlazorDual.Shared.Services
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
    }
}
