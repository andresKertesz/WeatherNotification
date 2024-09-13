using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherNotification.Model;

namespace WeatherNotification.Controllers
{
    internal static class WeatherController
    {
        private const string BASE_API = "https://api.weatherapi.com/v1/current.json";
        private const string API_KEY = "ed867d6d6aa44475803221105241109";
        public static async Task<WeatherData?> GetWeatherDataAsync(double latitude, double longitude)
        {
            string latLong = $"{latitude.ToString()},{longitude.ToString()}";
            Uri requestUrl = BuildUri(latLong);
            HttpClient client = new HttpClient();
            HttpRequestMessage httpRequest = new()
            {
                Method = HttpMethod.Get,
                RequestUri = requestUrl
            };

            var response = await client.SendAsync(httpRequest);
            var stringData = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<WeatherData>(stringData);
        }

        private static Uri BuildUri(string latLong)
        {
            string urlString = $"{BASE_API}?key={API_KEY}&q={latLong}";
            return new(urlString);

        }
    }
}
