namespace Vektorel.BasicFormSample
{
    partial class FormSlider
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
            btnDecrease = new Button();
            btnIncrease = new Button();
            btnPlayer = new Button();
            tmr = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnDecrease
            // 
            btnDecrease.Location = new Point(187, 222);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(75, 23);
            btnDecrease.TabIndex = 0;
            btnDecrease.Text = "Hız Azalt";
            btnDecrease.UseVisualStyleBackColor = true;
            btnDecrease.Click += btnDecrease_Click;
            // 
            // btnIncrease
            // 
            btnIncrease.Location = new Point(268, 222);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(75, 23);
            btnIncrease.TabIndex = 0;
            btnIncrease.Text = "Hız Artır";
            btnIncrease.UseVisualStyleBackColor = true;
            btnIncrease.Click += btnIncrease_Click;
            // 
            // btnPlayer
            // 
            btnPlayer.Location = new Point(0, 26);
            btnPlayer.Name = "btnPlayer";
            btnPlayer.Size = new Size(75, 23);
            btnPlayer.TabIndex = 1;
            btnPlayer.UseVisualStyleBackColor = true;
            // 
            // tmr
            // 
            tmr.Enabled = true;
            tmr.Interval = 1000;
            tmr.Tick += tmr_Tick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // FormSlider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 257);
            Controls.Add(textBox1);
            Controls.Add(btnPlayer);
            Controls.Add(btnIncrease);
            Controls.Add(btnDecrease);
            Name = "FormSlider";
            Text = "FormSlider";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDecrease;
        private Button btnIncrease;
        private Button btnPlayer;
        private System.Windows.Forms.Timer tmr;
        private TextBox textBox1;
    }
}