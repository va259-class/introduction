using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.Common;

namespace Vektorel.WeatherForecast
{
    public partial class FrmNewCity : Form
    {
        private readonly ForecastManager forecastManager;

        public FrmNewCity(ForecastManager forecastManager)
        {
            InitializeComponent();
            this.forecastManager = forecastManager;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            forecastManager.AddCity(txtName.Text);
            Close();
        }
    }
}
