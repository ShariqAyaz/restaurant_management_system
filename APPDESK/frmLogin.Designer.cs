namespace APPDESK
{
    partial class frmLogin
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
            this.txtbUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtbPass = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbUsername
            // 
            // 
            // 
            // 
            this.txtbUsername.CustomButton.Image = null;
            this.txtbUsername.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txtbUsername.CustomButton.Name = "";
            this.txtbUsername.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbUsername.CustomButton.TabIndex = 1;
            this.txtbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbUsername.CustomButton.UseSelectable = true;
            this.txtbUsername.CustomButton.Visible = false;
            this.txtbUsername.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtbUsername.Lines = new string[0];
            this.txtbUsername.Location = new System.Drawing.Point(122, 70);
            this.txtbUsername.MaxLength = 32767;
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.PasswordChar = '\0';
            this.txtbUsername.PromptText = "Username";
            this.txtbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbUsername.SelectedText = "";
            this.txtbUsername.SelectionLength = 0;
            this.txtbUsername.SelectionStart = 0;
            this.txtbUsername.ShortcutsEnabled = true;
            this.txtbUsername.Size = new System.Drawing.Size(240, 35);
            this.txtbUsername.TabIndex = 0;
            this.txtbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbUsername.UseSelectable = true;
            this.txtbUsername.WaterMark = "Username";
            this.txtbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbUsername_KeyDown);
            // 
            // txtbPass
            // 
            // 
            // 
            // 
            this.txtbPass.CustomButton.Image = null;
            this.txtbPass.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txtbPass.CustomButton.Name = "";
            this.txtbPass.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtbPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbPass.CustomButton.TabIndex = 1;
            this.txtbPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbPass.CustomButton.UseSelectable = true;
            this.txtbPass.CustomButton.Visible = false;
            this.txtbPass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtbPass.Lines = new string[0];
            this.txtbPass.Location = new System.Drawing.Point(122, 118);
            this.txtbPass.MaxLength = 32767;
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.PasswordChar = 'X';
            this.txtbPass.PromptText = "Password";
            this.txtbPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbPass.SelectedText = "";
            this.txtbPass.SelectionLength = 0;
            this.txtbPass.SelectionStart = 0;
            this.txtbPass.ShortcutsEnabled = true;
            this.txtbPass.Size = new System.Drawing.Size(240, 35);
            this.txtbPass.TabIndex = 1;
            this.txtbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbPass.UseSelectable = true;
            this.txtbPass.WaterMark = "Password";
            this.txtbPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbUsername_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.ForeColor = System.Drawing.Color.PaleGreen;
            this.btnLogin.Location = new System.Drawing.Point(368, 118);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 35);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.Red;
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogin.UseCustomForeColor = true;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(88, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DESIGNED && DEVELOPED BY SHARIQ AYAZ - ESOLINTIME";
            // 
            // metroLink1
            // 
            this.metroLink1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLink1.Location = new System.Drawing.Point(385, 89);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLink1.TabIndex = 4;
            this.metroLink1.Text = "Close";
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APPDESK.Properties.Resources.PicsArt_06_28_08_55_20;
            this.pictureBox1.Location = new System.Drawing.Point(14, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 178);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtbPass);
            this.Controls.Add(this.txtbUsername);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(642, 178);
            this.Name = "frmLogin";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "EATERY MANAGER - LOGIN";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtbUsername;
        private MetroFramework.Controls.MetroTextBox txtbPass;
        private MetroFramework.Controls.MetroButton btnLogin;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}