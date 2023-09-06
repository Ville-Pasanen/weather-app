using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace weather
{
    public class viikonsaa
    {
        string apiKey = apikey.OpenWeatherMapApiKey;


        public async Task<List<Saaennuste>> HaeViikonSaa(string paikka)
        {
            DateTime tamanhetkinenPaivamaara = DateTime.Today;
            DateTime viikonPaivamaara = tamanhetkinenPaivamaara.AddDays(4);
            return await HakuViikonSaa(paikka, tamanhetkinenPaivamaara, viikonPaivamaara);


        }

        public async Task<List<Saaennuste>> HakuViikonSaa(string paikka, DateTime aloitusPaivamaara, DateTime lopetusPaivamaara)
        {
            List<Saaennuste> viikonSaa = new List<Saaennuste>();

            string apiUrl = $"https://api.openweathermap.org/data/2.5/forecast?q={paikka}&appid={apiKey}&units=metric";


            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonres = await response.Content.ReadAsStringAsync();
                        JObject weatherData = JObject.Parse(jsonres);

                        JArray forecasts = (JArray)weatherData["list"];

                        foreach (var forecast in forecasts)
                        {
                            DateTime ennustepaivamaara = DateTimeOffset.FromUnixTimeSeconds((long)forecast["dt"]).DateTime;

                            if (ennustepaivamaara >= aloitusPaivamaara && ennustepaivamaara <= lopetusPaivamaara)
                            {
                                Saaennuste ennuste = new Saaennuste();

                                ennuste.Paivamaara = ennustepaivamaara;
                                double Lampotila = Convert.ToDouble(forecast["main"]["temp"]);
                                ennuste.Lampotila = (int)Math.Round(Lampotila);
                                ennuste.TuulenNopeus = Convert.ToDouble(forecast["wind"]["speed"]);


                                viikonSaa.Add(ennuste);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Virhe säätiedoissa!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

            return viikonSaa;
        }
    }

    public class Saaennuste
    {
        public DateTime Paivamaara { get; set; }
        public double Lampotila { get; set; }
        public double TuulenNopeus { get; set; }
    }
}

