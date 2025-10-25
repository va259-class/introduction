namespace Vektorel.UserManagement
{
    partial class FrmUsers
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            cmbCity = new ComboBox();
            label3 = new Label();
            dtpBirthDate = new DateTimePicker();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            dgvUsers = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbCity);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpBirthDate);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Location = new Point(14, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(606, 110);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 20);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 8;
            label4.Text = "Şehir";
            // 
            // cmbCity
            // 
            cmbCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(448, 43);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(141, 24);
            cmbCity.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 20);
            label3.Name = "label3";
            label3.Size = new Size(100, 17);
            label3.TabIndex = 6;
            label3.Text = "Doğum Tarihi";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(301, 43);
            dtpBirthDate.MaxDate = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            dtpBirthDate.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(141, 24);
            dtpBirthDate.TabIndex = 5;
            dtpBirthDate.Value = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(154, 43);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(141, 24);
            txtLastName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 21);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 3;
            label2.Text = "Soyadı";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(7, 43);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(141, 24);
            txtFirstName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 20);
            label1.Name = "label1";
            label1.Size = new Size(30, 17);
            label1.TabIndex = 1;
            label1.Text = "Adı";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(503, 73);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 0;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(14, 129);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(606, 265);
            dgvUsers.TabIndex = 1;
            dgvUsers.CellDoubleClick += dgvUsers_CellDoubleClick;
            // 
            // FrmUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 406);
            Controls.Add(dgvUsers);
            Controls.Add(groupBox1);
            Font = new Font("Verdana", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUsers";
            Text = "Kullanıcı Yönetimi";
            Load += FrmUsers_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private ComboBox cmbCity;
        private Label label3;
        private DateTimePicker dtpBirthDate;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
        private Button btnSave;
        private DataGridView dgvUsers;
    }
}
