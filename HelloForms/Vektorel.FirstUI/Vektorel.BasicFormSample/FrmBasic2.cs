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
            txtResult.Text = Calculate(MathOption.Sum).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtResult.Text = Calculate(MathOption.Subtract).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtResult.Text = Calculate(MathOption.Multiply).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtResult.Text = Calculate(MathOption.Divide).ToString();
        }

        private double Calculate(MathOption option)
        {
            var number1 = double.Parse(txtNumber1.Text);
            var number2 = double.Parse(txtNumber2.Text);
            switch (option)
            {
                case MathOption.Sum:
                    return number1 + number2;
                case MathOption.Subtract:
                    return number1 - number2;
                case MathOption.Multiply:
                    return number1 * number2;
                case MathOption.Divide:
                    return number1 / number2;
                case MathOption.Pow:
                    return Math.Pow(number1, number2);
            }
            return 0;
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            txtResult.Text = Calculate(MathOption.Pow).ToString();
        }
    }
    enum MathOption
    {
        Sum,
        Subtract,
        Multiply,
        Divide,
        Pow
    }
}


