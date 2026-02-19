using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class WeatherData
{
    public const string API_KEY = "efc273b616e54c93b59113742261902";
    public const string BASE_URL = "http://api.weatherapi.com/v1/current.json?";

    public string City { get; set; }
    public double Temperature { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }

    public static async Task<WeatherData> GetWeather(string city)
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{BASE_URL}key={API_KEY}&q={city}&aqi=no";
                HttpResponseMessage response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                string json = await response.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(json);

                WeatherData weatherData = new WeatherData();
                weatherData.City = data["location"]["name"].ToString();
                weatherData.Temperature = double.Parse(data["current"]["temp_c"].ToString());
                weatherData.Description = data["current"]["condition"]["text"].ToString();
                weatherData.Icon = "https:" + data["current"]["condition"]["icon"].ToString();

                return weatherData;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
    }
}
