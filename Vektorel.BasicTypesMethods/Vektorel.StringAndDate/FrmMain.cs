using System.Text;

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

        private void btnCustomFormat_Click(object sender, EventArgs e)
        {
            txtDateResult.Text = dtpRef.Value.ToString("dd\\/MM\\/yyyy HH:mm");
        }

        private void btnDateDiff_Click(object sender, EventArgs e)
        {
            var day = new DateTime(2025, 7, 13, 14, 0, 0);

            var diff = dtpRef.Value - day;
            txtDateResult.Text = diff.ToString();
        }

        private void btnDayCount_Click(object sender, EventArgs e)
        {
            var dayCount = DateTime.DaysInMonth(dtpRef.Value.Year, dtpRef.Value.Month);
            txtDateResult.Text = dayCount.ToString();
        }

        private void btnDayOfYear_Click(object sender, EventArgs e)
        {
            txtDateResult.Text = dtpRef.Value.DayOfYear.ToString();
        }

        private void btnKind_Click(object sender, EventArgs e)
        {
            var dt = new DateTime(2024, 12, 31, 22, 0, 0, DateTimeKind.Utc);

            txtDateResult.Text = dt.ToLocalTime().ToString();
        }

        private void btnTimeZone_Click(object sender, EventArgs e)
        {
            var dt = new DateTime(2024, 12, 31, 22, 0, 0, DateTimeKind.Utc);

            var chinaInfo = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");
            var date = TimeZoneInfo.ConvertTimeFromUtc(dt, chinaInfo);

            txtDateResult.Text = date.ToString();
        }

        private void btnNoA_Click(object sender, EventArgs e)
        {
            txtStringResult.Text = txtRef.Text.Replace("a", string.Empty, StringComparison.OrdinalIgnoreCase);
        }

        private void btnCrop3Words_Click(object sender, EventArgs e)
        {
            var croppedText = "I am in love";
            txtStringResult.Text = txtRef.Text.Substring(croppedText.Length);
        }

        private void btnWordCount_Click(object sender, EventArgs e)
        {
            var parts = txtRef.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            txtStringResult.Text = parts.Length.ToString();
        }

        private void btnSpellCount_Click(object sender, EventArgs e)
        {
            var count = 0;
            foreach (var part in txtRef.Text)
            {
                if (char.IsLetter(part))
                {
                    count++;
                }
            }
            txtStringResult.Text = count.ToString();
        }

        private void btnPadLeft_Click(object sender, EventArgs e)
        {
            txtStringResult.Text = $"AA{txtRef.Text.PadLeft(10, '0')}";
        }

        private void btnStartCheck_Click(object sender, EventArgs e)
        {
            if (txtRef.Text.StartsWith("CHK"))
            {
                txtStringResult.Text = "Kontrol aþamasýndan geçti";
            }
            else if (txtRef.Text.StartsWith("APR")) //EndsWith
            {
                txtStringResult.Text = "Onay aþamasýndan geçti";
            }
            else
            {
                txtStringResult.Text = "Süreç baþlamadý";
            }
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            txtStringResult.Text = txtRef.Text.Trim(' ', '.', '_');
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var names = new string[] { "Can", "Faruk", "Taha", "Kenan", "Onur" };

            txtStringResult.Text = string.Join(", ", names);

            txtStringResult.Text = string.Join(", ", names.Take(names.Length - 1)); // kaç tane öðe alýnsýn
            txtStringResult.Text += $" ve {names[names.Length - 1]}";
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            txtRef.Text = "Root/Users/Can/Home/Documents";

            var parts = txtRef.Text.Split('/');

            var order = 1;
            var builder = new StringBuilder(); // performans kazanýmý için
            foreach (var part in parts)
            {
                builder.AppendLine($"{order++}. {part}");
            }

            txtStringResult.Text = builder.ToString();
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            txtRef.Text = "canperk36@gmail.com";
            var index = txtRef.Text.IndexOf('@');
            txtStringResult.Text = txtRef.Text.Substring(0, index);
        }
    }
}
