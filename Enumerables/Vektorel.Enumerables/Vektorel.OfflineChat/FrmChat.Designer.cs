namespace Vektorel.OfflineChat
{
    partial class FrmChat
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
            txtMessage = new TextBox();
            btnSend = new Button();
            rtbMessages = new RichTextBox();
            btnRegister = new Button();
            txtUserName = new TextBox();
            SuspendLayout();
            // 
            // txtMessage
            // 
            txtMessage.Enabled = false;
            txtMessage.Location = new Point(12, 384);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(326, 54);
            txtMessage.TabIndex = 0;
            txtMessage.KeyDown += txtMessage_KeyDown;
            // 
            // btnSend
            // 
            btnSend.Enabled = false;
            btnSend.Location = new Point(344, 384);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 54);
            btnSend.TabIndex = 1;
            btnSend.Text = "Gönder";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // rtbMessages
            // 
            rtbMessages.Location = new Point(12, 37);
            rtbMessages.Name = "rtbMessages";
            rtbMessages.ReadOnly = true;
            rtbMessages.Size = new Size(407, 341);
            rtbMessages.TabIndex = 2;
            rtbMessages.Text = "";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(340, 8);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(12, 8);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(322, 23);
            txtUserName.TabIndex = 4;
            // 
            // FrmChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 450);
            Controls.Add(txtUserName);
            Controls.Add(btnRegister);
            Controls.Add(rtbMessages);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmChat";
            Text = "Offline Chat Penceresi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMessage;
        private Button btnSend;
        private RichTextBox rtbMessages;
        private Button btnRegister;
        private TextBox txtUserName;
    }
}