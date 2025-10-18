using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.BasicFormSample
{
    public partial class FrmBasic2 : Form
    {
        public FrmBasic2()
        {
            InitializeComponent();
        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0} {1}", txtFirstName.Text, txtLastName.Text));
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            var n1 = double.Parse(txtNumber1.Text);
            var n2 = double.Parse(txtNumber2.Text);
            txtResult.Text = (n1 + n2).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            var n1 = double.Parse(txtNumber1.Text);
            var n2 = double.Parse(txtNumber2.Text);
            txtResult.Text = (n1 - n2).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            var n1 = double.Parse(txtNumber1.Text);
            var n2 = double.Parse(txtNumber2.Text);
            txtResult.Text = (n1 * n2).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            var n1 = double.Parse(txtNumber1.Text);
            var n2 = double.Parse(txtNumber2.Text);
            txtResult.Text = (n1 / n2).ToString();
        }

        private double Calculate(double number1, double number2)
        {
            return 12;
        }
    }
}
