using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.OfflineChat
{
    public partial class FrmChat : Form
    {
        public FrmChat()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length < 5)
            {
                MessageBox.Show("En az 5 karakter kullanmalısın!", 
                                "Kullanıcı Adı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            txtMessage.Enabled = true;
            btnSend.Enabled = true;
            btnRegister.Enabled = false;
            txtUserName.Enabled = false;
        }
    }
}
