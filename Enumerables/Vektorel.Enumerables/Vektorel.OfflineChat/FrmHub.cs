using System.Runtime.InteropServices;
using Vektorel.OfflineChat.Managers;

namespace Vektorel.OfflineChat
{
    public partial class FrmHub : Form
    {
        private ChatHub hub;
        public FrmHub()
        {
            InitializeComponent();
            hub = ChatHub.Create();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var cf = new FrmChat();
            cf.Show();
        }
    }
}
