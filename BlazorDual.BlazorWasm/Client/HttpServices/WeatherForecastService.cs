using BlazorDual.Shared.Models;
using BlazorDual.Shared.Services;
using System.Net.Http.Json;

namespace BlazorDual.BlazorWasm.Client.Services
{
    public class WeatherForecastHttpService : IWeatherForecastService
    {
        private readonly HttpClient _httpClient;

        public WeatherForecastHttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return await _httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
    }
}