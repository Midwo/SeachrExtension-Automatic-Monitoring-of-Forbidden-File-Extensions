namespace SearchExtension
{
    partial class EmailConfigurations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailConfigurations));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbEmailContent = new System.Windows.Forms.GroupBox();
            this.mtbPassword = new System.Windows.Forms.MaskedTextBox();
            this.tbSignature = new System.Windows.Forms.TextBox();
            this.tbNameAccount = new System.Windows.Forms.TextBox();
            this.lSignature = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lAccountName = new System.Windows.Forms.Label();
            this.gbServerContent = new System.Windows.Forms.GroupBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbSmtp = new System.Windows.Forms.TextBox();
            this.lPort = new System.Windows.Forms.Label();
            this.lSmtp = new System.Windows.Forms.Label();
            this.bTest = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbEmailContent.SuspendLayout();
            this.gbServerContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(198, 20);
            this.optionsToolStripMenuItem.Text = "Załaduj konfiguracje poczty gmail";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // gbEmailContent
            // 
            this.gbEmailContent.Controls.Add(this.mtbPassword);
            this.gbEmailContent.Controls.Add(this.tbSignature);
            this.gbEmailContent.Controls.Add(this.tbNameAccount);
            this.gbEmailContent.Controls.Add(this.lSignature);
            this.gbEmailContent.Controls.Add(this.lPassword);
            this.gbEmailContent.Controls.Add(this.lAccountName);
            this.gbEmailContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbEmailContent.Location = new System.Drawing.Point(4, 24);
            this.gbEmailContent.Name = "gbEmailContent";
            this.gbEmailContent.Size = new System.Drawing.Size(324, 129);
            this.gbEmailContent.TabIndex = 32;
            this.gbEmailContent.TabStop = false;
            this.gbEmailContent.Text = "Konfiguracja adresu e-mail";
            // 
            // mtbPassword
            // 
            this.mtbPassword.Location = new System.Drawing.Point(66, 59);
            this.mtbPassword.Name = "mtbPassword";
            this.mtbPassword.PasswordChar = '*';
            this.mtbPassword.Size = new System.Drawing.Size(252, 23);
            this.mtbPassword.TabIndex = 6;
            this.mtbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSignature
            // 
            this.tbSignature.Location = new System.Drawing.Point(66, 97);
            this.tbSignature.Name = "tbSignature";
            this.tbSignature.Size = new System.Drawing.Size(252, 23);
            this.tbSignature.TabIndex = 5;
            this.tbSignature.Text = "Your signature";
            this.tbSignature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNameAccount
            // 
            this.tbNameAccount.Location = new System.Drawing.Point(65, 22);
            this.tbNameAccount.Name = "tbNameAccount";
            this.tbNameAccount.Size = new System.Drawing.Size(253, 23);
            this.tbNameAccount.TabIndex = 3;
            this.tbNameAccount.Text = "xyz@gmail.com";
            this.tbNameAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lSignature
            // 
            this.lSignature.AutoSize = true;
            this.lSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lSignature.Location = new System.Drawing.Point(5, 100);
            this.lSignature.Name = "lSignature";
            this.lSignature.Size = new System.Drawing.Size(55, 17);
            this.lSignature.TabIndex = 2;
            this.lSignature.Text = "Podpis:";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lPassword.Location = new System.Drawing.Point(5, 62);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(48, 17);
            this.lPassword.TabIndex = 1;
            this.lPassword.Text = "Hasło:";
            // 
            // lAccountName
            // 
            this.lAccountName.AutoSize = true;
            this.lAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lAccountName.Location = new System.Drawing.Point(5, 25);
            this.lAccountName.Name = "lAccountName";
            this.lAccountName.Size = new System.Drawing.Size(54, 17);
            this.lAccountName.TabIndex = 0;
            this.lAccountName.Text = "Nazwa:";
            // 
            // gbServerContent
            // 
            this.gbServerContent.Controls.Add(this.tbPort);
            this.gbServerContent.Controls.Add(this.tbSmtp);
            this.gbServerContent.Controls.Add(this.lPort);
            this.gbServerContent.Controls.Add(this.lSmtp);
            this.gbServerContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbServerContent.Location = new System.Drawing.Point(334, 24);
            this.gbServerContent.Name = "gbServerContent";
            this.gbServerContent.Size = new System.Drawing.Size(214, 73);
            this.gbServerContent.TabIndex = 33;
            this.gbServerContent.TabStop = false;
            this.gbServerContent.Text = "Konfiguracja serwera";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(56, 44);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(152, 23);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "587";
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSmtp
            // 
            this.tbSmtp.Location = new System.Drawing.Point(56, 17);
            this.tbSmtp.Name = "tbSmtp";
            this.tbSmtp.Size = new System.Drawing.Size(152, 23);
            this.tbSmtp.TabIndex = 2;
            this.tbSmtp.Text = "smtp.gmail.com";
            this.tbSmtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(6, 46);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(38, 17);
            this.lPort.TabIndex = 1;
            this.lPort.Text = "Port:";
            // 
            // lSmtp
            // 
            this.lSmtp.AutoSize = true;
            this.lSmtp.Location = new System.Drawing.Point(6, 20);
            this.lSmtp.Name = "lSmtp";
            this.lSmtp.Size = new System.Drawing.Size(50, 17);
            this.lSmtp.TabIndex = 0;
            this.lSmtp.Text = "SMTP:";
            // 
            // bTest
            // 
            this.bTest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTest.Image = global::SearchExtension.Properties.Resources.icons8_report_card_50;
            this.bTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bTest.Location = new System.Drawing.Point(334, 100);
            this.bTest.Name = "bTest";
            this.bTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bTest.Size = new System.Drawing.Size(141, 53);
            this.bTest.TabIndex = 35;
            this.bTest.Text = "Test konfiguracji";
            this.bTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bTest.UseVisualStyleBackColor = false;
            this.bTest.Click += new System.EventHandler(this.BTest_Click);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bSave.Image = global::SearchExtension.Properties.Resources.icons8_checkmark_50;
            this.bSave.Location = new System.Drawing.Point(481, 100);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(67, 53);
            this.bSave.TabIndex = 34;
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // EmailConfigurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(552, 157);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbEmailContent);
            this.Controls.Add(this.gbServerContent);
            this.Controls.Add(this.bTest);
            this.Controls.Add(this.bSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmailConfigurations";
            this.Text = "MD - Konfiguracja konta E-mail nadawcy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbEmailContent.ResumeLayout(false);
            this.gbEmailContent.PerformLayout();
            this.gbServerContent.ResumeLayout(false);
            this.gbServerContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbEmailContent;
        private System.Windows.Forms.MaskedTextBox mtbPassword;
        private System.Windows.Forms.TextBox tbSignature;
        private System.Windows.Forms.TextBox tbNameAccount;
        private System.Windows.Forms.Label lSignature;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lAccountName;
        private System.Windows.Forms.GroupBox gbServerContent;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbSmtp;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.Label lSmtp;
        private System.Windows.Forms.Button bTest;
        private System.Windows.Forms.Button bSave;
    }
}