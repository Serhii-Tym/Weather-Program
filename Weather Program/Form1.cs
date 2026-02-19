using System;
using System.Windows.Forms;

namespace Weather_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            WeatherData weather = await WeatherData.GetWeather(txtCity.Text);

            if (weather == null)
            {
                MessageBox.Show("City Not Found");
                return;
            }

            lblTemperature.Text = $"{weather.Temperature}°C";
            lblWeatherDescription.Text = weather.Description;
            picWeatherIcon.ImageLocation = weather.Icon;
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblTemperature_Click(object sender, EventArgs e)
        {
        }

        private void lblWeatherDescription_Click(object sender, EventArgs e)
        {
        }

        private void picWeatherIcon_Click(object sender, EventArgs e)
        {
        }
    }
}
