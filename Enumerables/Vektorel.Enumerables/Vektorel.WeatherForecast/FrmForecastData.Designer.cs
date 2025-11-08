namespace Vektorel.WeatherForecast
{
    partial class FrmForecastData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            nudHeat = new NumericUpDown();
            nudHumidity = new NumericUpDown();
            label2 = new Label();
            nudWindSpeed = new NumericUpDown();
            label3 = new Label();
            nudUV = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)nudHeat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHumidity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWindSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Sıcaklık";
            // 
            // nudHeat
            // 
            nudHeat.DecimalPlaces = 2;
            nudHeat.Location = new Point(12, 27);
            nudHeat.Maximum = new decimal(new int[] { 85, 0, 0, 0 });
            nudHeat.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            nudHeat.Name = "nudHeat";
            nudHeat.Size = new Size(166, 23);
            nudHeat.TabIndex = 1;
            nudHeat.TextAlign = HorizontalAlignment.Right;
            // 
            // nudHumidity
            // 
            nudHumidity.DecimalPlaces = 2;
            nudHumidity.Location = new Point(12, 71);
            nudHumidity.Maximum = new decimal(new int[] { 85, 0, 0, 0 });
            nudHumidity.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            nudHumidity.Name = "nudHumidity";
            nudHumidity.Size = new Size(166, 23);
            nudHumidity.TabIndex = 3;
            nudHumidity.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Nem";
            // 
            // nudWindSpeed
            // 
            nudWindSpeed.DecimalPlaces = 2;
            nudWindSpeed.Location = new Point(12, 115);
            nudWindSpeed.Maximum = new decimal(new int[] { 85, 0, 0, 0 });
            nudWindSpeed.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            nudWindSpeed.Name = "nudWindSpeed";
            nudWindSpeed.Size = new Size(166, 23);
            nudWindSpeed.TabIndex = 5;
            nudWindSpeed.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 4;
            label3.Text = "Rüzgar Hızı";
            // 
            // nudUV
            // 
            nudUV.DecimalPlaces = 2;
            nudUV.Location = new Point(12, 159);
            nudUV.Maximum = new decimal(new int[] { 85, 0, 0, 0 });
            nudUV.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            nudUV.Name = "nudUV";
            nudUV.Size = new Size(166, 23);
            nudUV.TabIndex = 7;
            nudUV.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 6;
            label4.Text = "UV";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 8;
            label5.Text = "Durum";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(12, 203);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(166, 23);
            cmbStatus.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(103, 232);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmForecastData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(190, 264);
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(label5);
            Controls.Add(nudUV);
            Controls.Add(label4);
            Controls.Add(nudWindSpeed);
            Controls.Add(label3);
            Controls.Add(nudHumidity);
            Controls.Add(label2);
            Controls.Add(nudHeat);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmForecastData";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hava Durumu Bilgisi";
            Load += FrmForecastData_Load;
            ((System.ComponentModel.ISupportInitialize)nudHeat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHumidity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWindSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nudHeat;
        private NumericUpDown nudHumidity;
        private Label label2;
        private NumericUpDown nudWindSpeed;
        private Label label3;
        private NumericUpDown nudUV;
        private Label label4;
        private Label label5;
        private ComboBox cmbStatus;
        private Button btnSave;
    }
}