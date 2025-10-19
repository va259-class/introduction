namespace Vektorel.BasicFormSample
{
    partial class FrmTeamManagement
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
            lstTeams = new ListBox();
            pnlColor1 = new Panel();
            pnlColor2 = new Panel();
            SuspendLayout();
            // 
            // lstTeams
            // 
            lstTeams.FormattingEnabled = true;
            lstTeams.ItemHeight = 15;
            lstTeams.Location = new Point(12, 12);
            lstTeams.Name = "lstTeams";
            lstTeams.Size = new Size(137, 289);
            lstTeams.TabIndex = 0;
            lstTeams.SelectedIndexChanged += lstTeams_SelectedIndexChanged;
            // 
            // pnlColor1
            // 
            pnlColor1.Location = new Point(155, 12);
            pnlColor1.Name = "pnlColor1";
            pnlColor1.Size = new Size(76, 81);
            pnlColor1.TabIndex = 1;
            // 
            // pnlColor2
            // 
            pnlColor2.Location = new Point(237, 12);
            pnlColor2.Name = "pnlColor2";
            pnlColor2.Size = new Size(76, 81);
            pnlColor2.TabIndex = 2;
            // 
            // FrmTeamManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 311);
            Controls.Add(pnlColor2);
            Controls.Add(pnlColor1);
            Controls.Add(lstTeams);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTeamManagement";
            Text = "Takım Yönetimi";
            Load += FrmTeamManagement_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstTeams;
        private Panel pnlColor1;
        private Panel pnlColor2;
    }
}