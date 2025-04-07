using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly string apiKey = ""; //Hier ApiKey von https://www.weatherapi.com/ einfügen

        private string requestURL = "http://api.weatherapi.com/v1/";
        public MainWindow()
        {
           


            InitializeComponent();
            WeatherMapResponse result = GetWeatherData("Hamburg"); //Nur Städte, keine Länder!

            string finalIMG = "Sun.png";
            string currentWeather = result.current.condition.text.ToLower(); //der Pfad 

            if (currentWeather.Contains("overcast"))
            {
                finalIMG = "Cloud.png";
            }
            else if (currentWeather.Contains("sun"))
            {
                finalIMG = "Sun.png";
            }
            else if (currentWeather.Contains("rain"))
            {
                finalIMG = "Rain.png";
            }
            else if (currentWeather.Contains("snow"))
            {
                finalIMG = "Snow.png";
            }
            ;

            backgroundIMG.ImageSource = new BitmapImage(new Uri($"Images/{finalIMG}", UriKind.Relative));
            labelTemperature.Content = result.current.temp_c.ToString("F1") + "°C";
            labelInfo.Content = result.current.condition.text;
           // labelCity.Content = result.location.region;

        }

        public WeatherMapResponse GetWeatherData(string city)
        {
            HttpClient httpClient = new HttpClient();
            var finalUri = $"{requestURL}current.json?key={apiKey}&q={city}";
            HttpResponseMessage httpResponse = httpClient.GetAsync(finalUri).Result;
            string response = httpResponse.Content.ReadAsStringAsync().Result;
            // Console.WriteLine(response); 
            WeatherMapResponse weatherMapResponse = JsonConvert.DeserializeObject<WeatherMapResponse>(response);
            return weatherMapResponse;

        }
    }
}