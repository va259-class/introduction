namespace Vektorel.BasicFormSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox txt1;
        TextBox txt2;
        void Form1_Load(object sender, EventArgs e)
        {
            txt1 = new TextBox();
            txt1.Width = 120;
            txt1.Height = 30;
            txt1.Left = 50;
            txt1.Top = 50;

            txt2 = new TextBox();
            txt2.Width = 120;
            txt2.Height = 30;
            txt2.Left = 50;
            txt2.Top = 90;

            var btn = new Button();
            btn.Text = "Birleþtir";
            btn.Left = 50;
            btn.Top = 130;
            btn.Click += ConcatValues;

            Controls.Add(txt1);
            Controls.Add(txt2);
            Controls.Add(btn);
        }

        void ConcatValues(object sender, EventArgs e)
        {
            MessageBox.Show(txt1.Text + " " + txt2.Text);
            MessageBox.Show(string.Format("{0} {1}", txt1.Text, txt2.Text));
            MessageBox.Show($"{txt1.Text} {txt2.Text}");
        }
    }
}
