namespace Vektorel.StringAndDate
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            txtStringResult.Text = txtRef.Text.ToUpper();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            txtStringResult.Text = txtRef.Text.ToLower();
        }

        private void btnAddDay_Click(object sender, EventArgs e)
        {
            txtDateResult.Text = dtpRef.Value.AddDays(3).ToString();
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            txtDateResult.Text = dtpRef.Value.AddDays(-1).ToString();
        }

        private void btn2MonthsLater_Click(object sender, EventArgs e)
        {
            txtDateResult.Text = dtpRef.Value.AddMonths(2).ToString();
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            txtDateResult.Text = DateTime.Now.ToString();
        }

        private void btnUtcNow_Click(object sender, EventArgs e)
        {
            txtDateResult.Text = DateTime.UtcNow.ToString();
        }

        private void btn1HourLater_Click(object sender, EventArgs e)
        {
            txtDateResult.Text = dtpRef.Value.AddHours(1).ToString();
        }
    }
}
