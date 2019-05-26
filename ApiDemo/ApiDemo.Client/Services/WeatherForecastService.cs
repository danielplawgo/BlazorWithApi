using ApiDemo.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiDemo.Client.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _client;

        public WeatherForecastService(HttpClient client)
        {
            _client = client;
        }

        public async Task<WeatherForecast[]> GetAsync()
        {
            return await _client.GetJsonAsync<WeatherForecast[]>("api/SampleData/WeatherForecasts");
        }
    }

    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetAsync();
    }
}
