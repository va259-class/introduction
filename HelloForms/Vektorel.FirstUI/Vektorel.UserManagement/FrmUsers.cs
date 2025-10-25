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
            //cmbCity.Items.Add("�stanbul");
            //cmbCity.Items.Add("�zmir");
            //cmbCity.Items.Add("Bodrum");
            //return;
            dp = new FakeDataProvider();
            cmbCity.DataSource = dp.GetCities();
            cmbCity.DisplayMember = nameof(City.Name);

            //List'e nazaran tek bir kez ba�lamak yeterli
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
            // BindingList kullan�ld�ktan sonra gerek kalmad�
            //dgvUsers.DataSource = null; 
            //dgvUsers.DataSource = dp.GetUsers();

            //Form doldurulduktan sonra temizleme yap�ls�n
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
            // grid sat�r�na bind edilmi� de�eri User tipine �evir
            // burada as sonras� istedi�iniz tipi kullanabilirsiniz
            // ancak d�n���m ger�ekle�mezse null de�eri al�rs�n�z
            // o sebeple bind edilen de�erin tipi bilmeniz �art
            var user = dgvUsers.SelectedRows[0].DataBoundItem as User;

            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;

            //DateTime saat bar�nd�r�r, DateOnly sadece Tarih bar�nd�r�r.
            //DateOnly DateTime'e �evrilirken saat eklemesi yapmak zorunday�z
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
            btnSave.Text = "G�ncelle";
        }

        private void EnableAddMode()
        {
            saveMode = SaveMode.Add;
            btnSave.Text = "Ekle";
        }
    }
}
