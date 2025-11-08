using Vektorel.Common;

namespace Vektorel.WeatherForecast
{
    public partial class FrmMain : Form
    {
        private ForecastManager forecastManager;
        public FrmMain()
        {
            InitializeComponent();
            forecastManager = new ForecastManager();
            forecastManager.OnCityAdded += ForecastManager_OnCityAdded;
        }

        private void ForecastManager_OnCityAdded(string city)
        {
            cmbCities.Items.Add(city);
            cmbCities.SelectedItem = city;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var f = new FrmNewCity(forecastManager);
            f.ShowDialog();
        }

        private void btnAddForecast_Click(object sender, EventArgs e)
        {
            var f = new FrmForecastData();
            f.ShowDialog();
        }
    }
}
