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
    public partial class FormSlider : Form
    {
        public FormSlider()
        {
            InitializeComponent();
        }

        int value = 0;

        private void tmr_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (value++).ToString();
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if (tmr.Interval > 100)
            {
                tmr.Interval -= 100;
            }
            else
            {
                btnIncrease.Enabled = false;
            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            tmr.Interval += 100;
            btnIncrease.Enabled = true;
        }
    }
}
