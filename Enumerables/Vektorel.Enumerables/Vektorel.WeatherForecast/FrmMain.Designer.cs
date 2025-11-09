namespace Vektorel.WeatherForecast
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNew = new Button();
            cmbCities = new ComboBox();
            label1 = new Label();
            dgvForecast = new DataGridView();
            btnAddForecast = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvForecast).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Location = new Point(152, 27);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(87, 23);
            btnNew.TabIndex = 0;
            btnNew.Text = "Şehir Ekle";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // cmbCities
            // 
            cmbCities.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCities.FormattingEnabled = true;
            cmbCities.Location = new Point(12, 27);
            cmbCities.Name = "cmbCities";
            cmbCities.Size = new Size(134, 23);
            cmbCities.TabIndex = 1;
            cmbCities.SelectedIndexChanged += cmbCities_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Şehirler";
            // 
            // dgvForecast
            // 
            dgvForecast.AllowUserToAddRows = false;
            dgvForecast.AllowUserToDeleteRows = false;
            dgvForecast.AllowUserToResizeColumns = false;
            dgvForecast.AllowUserToResizeRows = false;
            dgvForecast.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvForecast.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvForecast.Location = new Point(12, 56);
            dgvForecast.Name = "dgvForecast";
            dgvForecast.ReadOnly = true;
            dgvForecast.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvForecast.Size = new Size(417, 300);
            dgvForecast.TabIndex = 3;
            // 
            // btnAddForecast
            // 
            btnAddForecast.Location = new Point(245, 27);
            btnAddForecast.Name = "btnAddForecast";
            btnAddForecast.Size = new Size(87, 23);
            btnAddForecast.TabIndex = 4;
            btnAddForecast.Text = "Tahmin Ekle";
            btnAddForecast.UseVisualStyleBackColor = true;
            btnAddForecast.Click += btnAddForecast_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 368);
            Controls.Add(btnAddForecast);
            Controls.Add(dgvForecast);
            Controls.Add(label1);
            Controls.Add(cmbCities);
            Controls.Add(btnNew);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            Text = "Hava Tahmini Yayını";
            ((System.ComponentModel.ISupportInitialize)dgvForecast).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNew;
        private ComboBox cmbCities;
        private Label label1;
        private DataGridView dgvForecast;
        private Button btnAddForecast;
    }
}
