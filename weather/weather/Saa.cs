using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace weather
{
    public partial class Saa : Form
    {
        string ApiKey = apikey.OpenWeatherMapApiKey; 
        private const string ApiUrl = "http://api.openweathermap.org/data/2.5/weather?q="; 


        public Saa()
        {
            InitializeComponent();
        }

        private async void btnHaku_Click(object sender, EventArgs e)
        {
            lbLampo.Text = "";
            lbTuuli.Text = "";
            lbIlmanpaine.Text = "";
            lbIlmankosteus.Text = "";
            lbpv1.Text = "";
            lbpv2.Text = "";
            lbpv3.Text = "";
            lbpv4.Text = "";
            lbpv5.Text = "";


            string kaupunkinm = txtboxHaku.Text;
            if (string.IsNullOrWhiteSpace(kaupunkinm))
            {
                MessageBox.Show("Laita paikan nimi ennen hakua!", "Virhe haussa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HttpClient client = new HttpClient();
            {
                string apiUrl = $"{ApiUrl}{kaupunkinm}&appid={ApiKey}&units=metric";
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    weatherinfo.Root weatherData = JsonConvert.DeserializeObject<weatherinfo.Root>(json);

                    double lampotila = weatherData.main.temp;
                    int pyoristettylampotila = (int)Math.Round(lampotila);
                    lbLampo.Text = $"{pyoristettylampotila} °C";

                    string iconUrl = $"http://openweathermap.org/img/w/{weatherData.weather[0].icon}.png";
                    picboxicon.Load(iconUrl);

                    double tuulenNopeus = weatherData.wind.speed;
                    lbTuuli.Text = $"{tuulenNopeus} m/s";

                    double ilmanpaine = weatherData.main.pressure;
                    lbIlmanpaine.Text = $"{ilmanpaine} mBar";

                    double ilmankosteus = weatherData.main.humidity;
                    lbIlmankosteus.Text = $"{ilmankosteus}%";

                }
                else
                {
                    MessageBox.Show("Virhe haussa!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private async void btnHuominenSaa_Click(object sender, EventArgs e)
        {
            lbLampo.Text = "";
            lbTuuli.Text = "";
            lbIlmanpaine.Text = "";
            lbIlmankosteus.Text = "";
            picboxicon.Image = null;
            lbpv1.Text = "";
            lbpv2.Text = "";
            lbpv3.Text = "";
            lbpv4.Text = "";
            lbpv5.Text = "";


            string paikka = txtboxHaku.Text;
            huominen huominen = new huominen();
            string huomisentiedot = await huominen.Haehuominensaa(paikka);


            string[] tiedotriveinä = huomisentiedot.Split();
            lbLampo.Text = $"{tiedotriveinä[0]} {tiedotriveinä[1]}";
            lbTuuli.Text = $"{tiedotriveinä[2]} {tiedotriveinä[3]}";
            lbIlmanpaine.Text = $"{tiedotriveinä[4]} {tiedotriveinä[5]}";
            lbIlmankosteus.Text = $"{tiedotriveinä[6]}";

        }

        private async void btn5pvEnnuste_Click(object sender, EventArgs e)
        {
            lbpv1.Text = "";
            lbpv2.Text = "";
            lbpv3.Text = "";
            lbpv4.Text = "";
            lbpv5.Text = "";
            lbLampo.Text = "";
            lbTuuli.Text = "";
            lbIlmanpaine.Text = "";
            lbIlmankosteus.Text = "";
            picboxicon.Image = null;


            viikonsaa viikonSaaHakija = new viikonsaa();
            string paikka = txtboxHaku.Text;
            List<Saaennuste> viikonsaa = await viikonSaaHakija.HaeViikonSaa(paikka);


            if (viikonsaa.Count > 0)
            {
                int labelIndex = 1;
                Dictionary<DateTime, string> ennusteet = new Dictionary<DateTime, string>();

                foreach (var ennuste in viikonsaa)
                {
                    DateTime paivamaara = ennuste.Paivamaara.Date;

                    string paivamaaraTeksti = paivamaara.ToString("dd.MM.yyyy");
                    string lampotila = ennuste.Lampotila + " °C";
                    string tuuli = ennuste.TuulenNopeus + " m/s";


                    string ennusteTeksti = $"Lämpötila: {lampotila}, Tuuli: {tuuli}";

                    if (!ennusteet.ContainsKey(paivamaara))
                    {
                        ennusteet[paivamaara] = $"{paivamaaraTeksti}: {ennusteTeksti}";
                    }

                    if (ennusteet.Count >= 5)
                    {
                        break;
                    }
                }

                foreach (var kvp in ennusteet)
                {
                    Label label = this.Controls.Find($"lbpv{labelIndex}", true).FirstOrDefault() as Label;

                    if (label != null)
                    {
                        label.Text = kvp.Value;
                        labelIndex++;
                    }
                }
            }   
        }
    }
}