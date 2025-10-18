namespace Vektorel.BasicFormSample
{
    partial class JumpingText
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            btnLeft = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnRight = new Button();
            brnLeftAll = new Button();
            btnRightAll = new Button();
            btnAuto = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(175, 80);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(43, 23);
            btnLeft.TabIndex = 1;
            btnLeft.Text = "<";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 39);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(330, 39);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(224, 80);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(43, 23);
            btnRight.TabIndex = 5;
            btnRight.Text = ">";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // brnLeftAll
            // 
            brnLeftAll.Location = new Point(175, 109);
            brnLeftAll.Name = "brnLeftAll";
            brnLeftAll.Size = new Size(43, 23);
            brnLeftAll.TabIndex = 6;
            brnLeftAll.Text = "<<";
            brnLeftAll.UseVisualStyleBackColor = true;
            brnLeftAll.Click += brnLeftAll_Click;
            // 
            // btnRightAll
            // 
            btnRightAll.Location = new Point(224, 109);
            btnRightAll.Name = "btnRightAll";
            btnRightAll.Size = new Size(43, 23);
            btnRightAll.TabIndex = 7;
            btnRightAll.Text = ">>";
            btnRightAll.UseVisualStyleBackColor = true;
            btnRightAll.Click += btnRightAll_Click;
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(175, 138);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(92, 23);
            btnAuto.TabIndex = 8;
            btnAuto.Text = "Otomatik";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // JumpingText
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 185);
            Controls.Add(btnAuto);
            Controls.Add(btnRightAll);
            Controls.Add(brnLeftAll);
            Controls.Add(btnRight);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(btnLeft);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "JumpingText";
            Text = "İsim Zıplatmaca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnLeft;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnRight;
        private Button brnLeftAll;
        private Button btnRightAll;
        private Button btnAuto;
        private System.Windows.Forms.Timer timer1;
    }
}