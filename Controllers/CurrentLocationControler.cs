using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherNotification.Model;

namespace WeatherNotification.Controllers
{
    public static class CurrentLocationControler
    {
        private static  GeolocationData? _currentPosition; 
        public static async Task<GeolocationData?> GetCurrentPosition()
        {
            
            if(_currentPosition == null)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new("http://ip-api.com/json/");
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get,client.BaseAddress.ToString());
                var response = await client.SendAsync(httpRequestMessage);
                string stringResponse = await response.Content.ReadAsStringAsync();
               _currentPosition =  JsonSerializer.Deserialize<GeolocationData>(stringResponse);
            }

            return _currentPosition;



        }

    }
}
