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
        Direction direction = Direction.Right;

        private void tmr_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (value++).ToString();
            MovePlayer();
        }

        void MovePlayer()
        {
            if (direction == Direction.Right)
            {
                btnPlayer.Left += 5;
                // this bulunduğumuz class demek
                if (btnPlayer.Left >= this.Width - 20 - btnPlayer.Width)
                {
                    direction = Direction.Left;
                }
            }
            else
            {
                btnPlayer.Left -= 5;
                if (btnPlayer.Left <= 0)
                {
                    direction = Direction.Right;
                }
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if (tmr.Interval > 50)
            {
                tmr.Interval -= 50;
            }
            else
            {
                btnIncrease.Enabled = false;
            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            tmr.Interval += 50;
            btnIncrease.Enabled = true;
        }
    }

    enum Direction
    {
        Left,
        Right
    }
}
