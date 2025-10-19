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
            tm.CreateTeam("Galatasaray", Color.Crimson, Color.Orange);
            tm.CreateTeam("Başakşehir");
            tm.CreateTeam("Trabzonspor");
            tm.CreateTeam("Antalyaspor", Color.Red, Color.White);
            tm.CreateTeam("Gençlerbirliği");

            var team4 = tm.GetTeams()[4];
            tm.SetTeamColor(team4, Color.Red, Color.Black);

            //ekrandaki listbox'ın veri kaynağı team manager'dan
            //gelen teams listesi olacak
            lstTeams.DataSource = tm.GetTeams();
            lstTeams.DisplayMember = nameof(Team.Name);
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            // object'ten esas tipe dönüşüm yöntemi
            // eğer dönüştürülmek istenen tip uyumsuz ise null döner
            var team = lstTeams.SelectedItem as Team;
            pnlColor1.BackColor = team.Color1;
            pnlColor2.BackColor = team.Color2;
        }
    }
}
