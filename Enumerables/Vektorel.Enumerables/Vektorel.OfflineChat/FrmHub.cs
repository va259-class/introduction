using System.Runtime.InteropServices;
using Vektorel.OfflineChat.Managers;

namespace Vektorel.OfflineChat
{
    public partial class FrmHub : Form
    {
        private ChatHub hub;
        private int userCount;
        public FrmHub()
        {
            InitializeComponent();
            hub = ChatHub.Create();
            hub.OnUserRegistered += Hub_OnUserRegistered;
        }

        private void Hub_OnUserRegistered(string userName)
        {
            userCount++;
            lblCount.Text = $"Sohbette {userCount} kiþi var";
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var cf = new FrmChat();
            cf.Show();
        }
    }
}
