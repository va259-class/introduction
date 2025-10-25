using Vektorel.UserManagement.Helpers;
using Vektorel.UserManagement.Models;

namespace Vektorel.UserManagement
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            //cmbCity.Items.Add("Ankara");
            //cmbCity.Items.Add("Ýstanbul");
            //cmbCity.Items.Add("Ýzmir");
            //cmbCity.Items.Add("Bodrum");
            //return;
            var dp = new FakeDataProvider();
            cmbCity.DataSource = dp.GetCities();
            cmbCity.DisplayMember = nameof(City.Name);

            dgvUsers.DataSource = dp.GetUsers();
        }
        private int id = 3;
        private void btnSave_Click(object sender, EventArgs e)
        {
            var user = new User()
            {
                Id = ++id,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                BirthDate = DateOnly.FromDateTime(dtpBirthDate.Value),
                City = cmbCity.SelectedItem as City
            };
        }
    }
}
