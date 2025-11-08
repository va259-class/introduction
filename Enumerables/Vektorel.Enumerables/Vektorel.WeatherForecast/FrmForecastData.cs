using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.WeatherForecast
{
    public partial class FrmForecastData : Form
    {
        public FrmForecastData()
        {
            InitializeComponent();
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
    }
}
