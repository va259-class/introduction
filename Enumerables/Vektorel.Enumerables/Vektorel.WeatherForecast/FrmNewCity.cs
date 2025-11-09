using Vektorel.Common;

namespace Vektorel.WeatherForecast
{
    public partial class FrmNewCity : Form
    {
        private readonly ForecastManager forecastManager;

        public FrmNewCity(ForecastManager forecastManager)
        {
            InitializeComponents();
            this.forecastManager = forecastManager;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            forecastManager.AddCity(txtName.Text);
            Close();
        }
    }
}
