using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.OfflineChat.Managers;

namespace Vektorel.OfflineChat
{
    public partial class FrmChat : Form
    {
        private ChatHub chatHub;
        public FrmChat()
        {
            InitializeComponent();
            chatHub = ChatHub.Create();
            chatHub.OnUserRegistered += ChatHub_OnUserRegistered;
            chatHub.OnMessageSent += ChatHub_OnMessageSent;
        }

        private void ChatHub_OnMessageSent(string userName, string message)
        {
            var content = $"{DateTime.Now.ToString("HH:mm:ss")} - {userName}: {message}";
            rtbMessages.AppendText(Environment.NewLine + content);

            var contentStart = rtbMessages.TextLength - content.Length;
            rtbMessages.SelectionStart = contentStart;
            rtbMessages.SelectionLength = 10;
            rtbMessages.SelectionFont = new Font(rtbMessages.Font, FontStyle.Bold);
        }

        private void ChatHub_OnUserRegistered(string userName)
        {
            var message = $"{userName} sohbete katıldı";
            rtbMessages.AppendText(Environment.NewLine + message); // Yeni satırla birlikte metni ekle

            // Kullanıcı adını stilize et
            int userNameStart = rtbMessages.TextLength - message.Length;  // Kullanıcı adının başlangıç indexi
            int userNameLength = userName.Length; // Kullanıcı adının uzunluğu

            // Kullanıcı adını stilize et (kalın ve crimson rengi)
            rtbMessages.SelectionStart = userNameStart;  // Kullanıcı adının başlangıcına git
            rtbMessages.SelectionLength = userNameLength;  // Kullanıcı adının uzunluğu kadar seç
            rtbMessages.SelectionFont = new Font(rtbMessages.Font, FontStyle.Bold);  // Kalın font
            rtbMessages.SelectionColor = Color.Crimson;  // Crimson rengi
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
            chatHub.Register(txtUserName.Text);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void SendMessage()
        {
            chatHub.SendMessage(txtUserName.Text, txtMessage.Text);
            txtMessage.Clear();
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
            }
        }
    }
}
