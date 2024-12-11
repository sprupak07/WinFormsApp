using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsApp
{
    public partial class WeatherApp : Form
    {
        private const string ApiKey = "64fb0a4d26eec0b37b3189df8ed1ef47";
        private const string BaseUrl = "https://api.openweathermap.org/data/2.5/weather";

        public WeatherApp()
        {
            InitializeComponent();
        }

        private async void ButtonFetch_Click(object sender, EventArgs e)
        {
            string cityName = textBoxCity.Text.Trim();
            if (string.IsNullOrEmpty(cityName))
            {
                MessageBox.Show("Please enter a city name.", "Error");
                return;
            }

            try
            {
                await FetchWeatherDataAsync(cityName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching weather data: {ex.Message}", "Error");
            }
        }

        private async Task FetchWeatherDataAsync(string cityName)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{BaseUrl}?q={cityName}&appid={ApiKey}&units=metric";
                HttpResponseMessage response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Error: {response.ReasonPhrase}", "Error");
                    return;
                }

                string responseData = await response.Content.ReadAsStringAsync();
                var weatherData = JsonConvert.DeserializeObject<WeatherResponse>(responseData);

                // Update UI with weather data
                labelTemp.Text = $"Temperature: {weatherData.Main.Temp} °C";
                labelCondition.Text = $"Condition: {weatherData.Weather[0].Description}";
                labelHumidity.Text = $"Humidity: {weatherData.Main.Humidity} %";
                labelWind.Text = $"Wind Speed: {weatherData.Wind.Speed} m/s";

                // Load weather icon
                string iconUrl = $"https://openweathermap.org/img/wn/{weatherData.Weather[0].Icon}@2x.png";
                pictureBoxIcon.Load(iconUrl);
            }
        }

        private void WeatherApp_Load(object sender, EventArgs e)
        {

        }
    }

    public class WeatherResponse
    {
        public Main Main { get; set; }
        public Weather[] Weather { get; set; }
        public Wind Wind { get; set; }
    }

    public class Main
    {
        public float Temp { get; set; }
        public int Humidity { get; set; }
    }

    public class Weather
    {
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class Wind
    {
        public float Speed { get; set; }
    }
}
