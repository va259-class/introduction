using Vektorel.BasicFormSample.Helpers;

namespace Vektorel.BasicFormSample
{
    public partial class FrmTeamManagement : Form
    {
        public FrmTeamManagement()
        {
            InitializeComponent();
        }

        private void FrmTeamManagement_Load(object sender, EventArgs e)
        {
            var tm = new TeamManager();
            tm.CreateTeam("Galatasaray");
            tm.CreateTeam("Başakşehir");
        }
    }
}
