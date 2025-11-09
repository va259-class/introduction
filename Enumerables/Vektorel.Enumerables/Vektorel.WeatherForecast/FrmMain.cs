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
            //f.FormClosed += F_FormClosed;
            f.ShowDialog();
        }

        //private void F_FormClosed(object? sender, FormClosedEventArgs e)
        //{
        //    cmbCities.Items.Clear();
        //    foreach (var city in forecastManager.GetCities())
        //    {
        //        cmbCities.Items.Add(city);
        //    }
        //}

        private void btnAddForecast_Click(object sender, EventArgs e)
        {
            var f = new FrmForecastData(cmbCities.SelectedItem.ToString(), forecastManager);
            f.ShowDialog();
        }
    }
}
