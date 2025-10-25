using System.Windows.Forms;
using Vektorel.UserManagement.Enums;
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
        private FakeDataProvider dp;
        private SaveMode saveMode;
        private void FrmUsers_Load(object sender, EventArgs e)
        {
            //cmbCity.Items.Add("Ankara");
            //cmbCity.Items.Add("Ýstanbul");
            //cmbCity.Items.Add("Ýzmir");
            //cmbCity.Items.Add("Bodrum");
            //return;
            dp = new FakeDataProvider();
            cmbCity.DataSource = dp.GetCities();
            cmbCity.DisplayMember = nameof(City.Name);

            //List'e nazaran tek bir kez baðlamak yeterli
            dgvUsers.DataSource = dp.GetUsers();
            saveMode = SaveMode.Add;
        }
        private int id = 3;
        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (saveMode)
            {
                case SaveMode.Add:
                    AddUser();
                    break;
                case SaveMode.Update:
                    UpdateUser();
                    break;
            }
        }

        private void AddUser()
        {
            var user = new User()
            {
                Id = ++id,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                BirthDate = DateOnly.FromDateTime(dtpBirthDate.Value),
                City = cmbCity.SelectedItem as City
            };
            dp.AddUser(user);
            // BindingList kullanýldýktan sonra gerek kalmadý
            //dgvUsers.DataSource = null; 
            //dgvUsers.DataSource = dp.GetUsers();

            //Form doldurulduktan sonra temizleme yapýlsýn
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbCity.SelectedIndex = 0;
            dtpBirthDate.Value = dtpBirthDate.MaxDate;
            txtFirstName.Focus();
        }

        public void UpdateUser()
        {
            var user = dgvUsers.SelectedRows[0].DataBoundItem as User;

            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.BirthDate = DateOnly.FromDateTime(dtpBirthDate.Value);
            user.City = cmbCity.SelectedItem as City;

            btnClear.PerformClick();
            dgvUsers.Refresh();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // grid satýrýna bind edilmiþ deðeri User tipine çevir
            // burada as sonrasý istediðiniz tipi kullanabilirsiniz
            // ancak dönüþüm gerçekleþmezse null deðeri alýrsýnýz
            // o sebeple bind edilen deðerin tipi bilmeniz þart
            var user = dgvUsers.SelectedRows[0].DataBoundItem as User;

            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;

            //DateTime saat barýndýrýr, DateOnly sadece Tarih barýndýrýr.
            //DateOnly DateTime'e çevrilirken saat eklemesi yapmak zorundayýz
            dtpBirthDate.Value = user.BirthDate.ToDateTime(new TimeOnly(0, 0, 0));
            cmbCity.SelectedItem = user.City;
            EnableEditMode();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbCity.SelectedIndex = 0;
            dtpBirthDate.Value = dtpBirthDate.MaxDate;
            txtFirstName.Focus();
            EnableAddMode();
        }

        private void EnableEditMode()
        {
            saveMode = SaveMode.Update;
            btnSave.Text = "Güncelle";
        }

        private void EnableAddMode()
        {
            saveMode = SaveMode.Add;
            btnSave.Text = "Ekle";
        }
    }
}
