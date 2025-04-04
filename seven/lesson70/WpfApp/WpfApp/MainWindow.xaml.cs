﻿using System.Net.Http;
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
        // /current.json?key=YOUR_API_KEY&q=LOCATION


            InitializeComponent();
            WeatherMapResponse result = GetWeatherData("Berlin");


            backgroundIMG.ImageSource = new BitmapImage(new Uri("Images/Rain.png",UriKind.Relative));


        }

        public WeatherMapResponse GetWeatherData(string city)
        {
            HttpClient httpClient = new HttpClient();
            var finalUri = $"{requestURL}current.json?key={apiKey}&q={city}";
            HttpResponseMessage httpResponse = httpClient.GetAsync(finalUri).Result;
            string response = httpResponse.Content.ReadAsStringAsync().Result;
            WeatherMapResponse weatherMapResponse = JsonConvert.DeserializeObject<WeatherMapResponse>(response);
            return weatherMapResponse;
        }
    }
}