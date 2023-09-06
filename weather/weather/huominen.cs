using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace weather
{
    public class huominen
    {
        string apiKey = apikey.OpenWeatherMapApiKey;       

        public async Task<string> Haehuominensaa(string paikka)
        {
            if (!string.IsNullOrEmpty(paikka))
            {
                string apiUrl = $"https://api.openweathermap.org/data/2.5/forecast?q={paikka}&appid={apiKey}&units=metric";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(apiUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            string jsonResponse = await response.Content.ReadAsStringAsync();
                            JObject weatherData = JObject.Parse(jsonResponse);

                            JArray forecasts = (JArray)weatherData["list"];
                            DateTime huominen = DateTime.Today.AddDays(1);

                            foreach (var forecast in forecasts)
                            {
                                DateTime forecastDateTime = DateTimeOffset.FromUnixTimeSeconds((long)forecast["dt"]).DateTime;

                                if (forecastDateTime.Date == huominen.Date)
                                {

                                    double lampo = Convert.ToDouble(forecast["main"]["temp"]);
                                    int pyoristettylampotila = (int)Math.Round(lampo);
                                    double tuulenNopeus = Convert.ToDouble(forecast["wind"]["speed"]);
                                    double ilmanpaine = Convert.ToDouble(forecast["main"]["pressure"]);
                                    double ilmankosteus = Convert.ToDouble(forecast["main"]["humidity"]);

                                    return $"{pyoristettylampotila} °C " +
                                            $"{tuulenNopeus} m/s " +
                                            $"{ilmanpaine} mBar " +
                                            $"{ilmankosteus}%";

                                }
                            }
                            return "Tietoja ei saatavilla!";
                        }
                        else
                        {
                            return "Virhe säätiedoissa!";
                        }
                    }
                    catch (Exception ex)
                    {
                        return $"Error: {ex.Message}";
                    }
                }
            }
            else
            {
                return "Laita paikan nimi!";
            }
        }
    }
}
