using Vektorel.Common;
using Vektorel.Common.Models;

namespace Vektorel.WeatherForecast
{
    public partial class FrmForecastData : Form
    {
        private readonly ForecastManager forecastManager;
        private readonly string city;

        public FrmForecastData(string city, ForecastManager forecastManager)
        {
            InitializeComponent();
            this.city = city;
            this.forecastManager = forecastManager;
        }

        private void FrmForecastData_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Güneşli");
            cmbStatus.Items.Add("Sisli");
            cmbStatus.Items.Add("Bulutlu");
            cmbStatus.Items.Add("Sağanak Yağışlı");
            cmbStatus.Items.Add("Kar Yağışlı");
            cmbStatus.Items.Add("Hafif Yağmurlu");
            cmbStatus.Items.Add("Parçalı Bulutlu");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var forecast = new Forecast(nudHeat.Value, 
                                        nudUV.Value, 
                                        nudHumidity.Value, 
                                        nudWindSpeed.Value, 
                                        cmbStatus.SelectedItem.ToString());

            forecastManager.AddForecast(city, forecast);
            Close();
        }
    }
}
