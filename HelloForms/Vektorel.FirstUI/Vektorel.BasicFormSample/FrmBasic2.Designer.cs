namespace Vektorel.BasicFormSample
{
    partial class FrmBasic2
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnConcat = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtResult = new TextBox();
            label3 = new Label();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            btnSum = new Button();
            label2 = new Label();
            label1 = new Label();
            txtNumber2 = new TextBox();
            txtNumber1 = new TextBox();
            btnPow = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(6, 19);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(6, 48);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 1;
            // 
            // btnConcat
            // 
            btnConcat.Location = new Point(6, 77);
            btnConcat.Name = "btnConcat";
            btnConcat.Size = new Size(75, 23);
            btnConcat.TabIndex = 2;
            btnConcat.Text = "Birleştir";
            btnConcat.UseVisualStyleBackColor = true;
            btnConcat.Click += btnConcat_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConcat);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 113);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Metin Birleştirme";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPow);
            groupBox2.Controls.Add(txtResult);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnDivide);
            groupBox2.Controls.Add(btnMultiply);
            groupBox2.Controls.Add(btnSubtract);
            groupBox2.Controls.Add(btnSum);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtNumber2);
            groupBox2.Controls.Add(txtNumber1);
            groupBox2.Location = new Point(12, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 175);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mini Mini Birler";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(53, 80);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(95, 23);
            txtResult.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 82);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 8;
            label3.Text = "Sonuç";
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(121, 120);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(28, 23);
            btnDivide.TabIndex = 7;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(87, 120);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(28, 23);
            btnMultiply.TabIndex = 6;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(53, 120);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(28, 23);
            btnSubtract.TabIndex = 5;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(19, 120);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(28, 23);
            btnSum.TabIndex = 4;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 54);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Sayı 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 25);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Sayı 1";
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(53, 51);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(95, 23);
            txtNumber2.TabIndex = 1;
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(53, 22);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(95, 23);
            txtNumber1.TabIndex = 0;
            // 
            // btnPow
            // 
            btnPow.Location = new Point(155, 120);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(28, 23);
            btnPow.TabIndex = 10;
            btnPow.Text = "P";
            btnPow.UseVisualStyleBackColor = true;
            btnPow.Click += btnPow_Click;
            // 
            // FrmBasic2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 329);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBasic2";
            Text = "Kolay İşlemler Uygulaması";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnConcat;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSum;
        private Label label2;
        private Label label1;
        private TextBox txtNumber2;
        private TextBox txtNumber1;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private TextBox txtResult;
        private Label label3;
        private Button btnPow;
    }
}