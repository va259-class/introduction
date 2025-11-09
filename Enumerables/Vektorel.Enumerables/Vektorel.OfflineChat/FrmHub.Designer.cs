namespace Vektorel.OfflineChat
{
    partial class FrmHub
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
            btnJoin = new Button();
            lblCount = new Label();
            SuspendLayout();
            // 
            // btnJoin
            // 
            btnJoin.Location = new Point(162, 131);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(75, 23);
            btnJoin.TabIndex = 0;
            btnJoin.Text = "Katıl";
            btnJoin.UseVisualStyleBackColor = true;
            btnJoin.Click += btnJoin_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(150, 172);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(102, 15);
            lblCount.TabIndex = 1;
            lblCount.Text = "Sohbette 0 kişi var";
            // 
            // FrmHub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 315);
            Controls.Add(lblCount);
            Controls.Add(btnJoin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmHub";
            Text = "Chat Hub";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJoin;
        private Label lblCount;
    }
}
