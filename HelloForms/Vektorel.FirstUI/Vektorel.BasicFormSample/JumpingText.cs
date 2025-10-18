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
    public partial class JumpingText : Form
    {
        public JumpingText()
        {
            InitializeComponent();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            // textbox 1 içinde metin yazıyorsa
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
                return;
            }
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                textBox3.Text = textBox2.Text;
                textBox2.Clear();
                return;
            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                textBox4.Text = textBox3.Text;
                textBox3.Clear();
                return;
            }
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                textBox1.Text = textBox4.Text;
                textBox4.Clear();
                return;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            // textbox 1 içinde metin yazıyorsa
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                textBox3.Text = textBox4.Text;
                textBox4.Clear();
                return;
            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                textBox2.Text = textBox3.Text;
                textBox3.Clear();
                return;
            }
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                textBox1.Text = textBox2.Text;
                textBox2.Clear();
                return;
            }
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox4.Text = textBox1.Text;
                textBox1.Clear();
                return;
            }
        }

        private void brnLeftAll_Click(object sender, EventArgs e)
        {
            var t1 = textBox1.Text;
            var t2 = textBox2.Text;
            var t3 = textBox3.Text;
            var t4 = textBox4.Text;

            textBox1.Text = t2;
            textBox2.Text = t3;
            textBox3.Text = t4;
            textBox4.Text = t1;
        }

        private void btnRightAll_Click(object sender, EventArgs e)
        {
            var t1 = textBox1.Text;
            var t2 = textBox2.Text;
            var t3 = textBox3.Text;
            var t4 = textBox4.Text;

            textBox4.Text = t3;
            textBox3.Text = t2;
            textBox2.Text = t1;
            textBox1.Text = t4;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnRight.PerformClick();
        }
    }
}
