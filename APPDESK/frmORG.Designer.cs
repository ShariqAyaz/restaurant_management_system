namespace APPDESK
{
    partial class frmORG
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
            this.lstbORG = new System.Windows.Forms.ListBox();
            this.btnMAIN = new MetroFramework.Controls.MetroTile();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lstbORG
            // 
            this.lstbORG.BackColor = System.Drawing.Color.White;
            this.lstbORG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbORG.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbORG.ForeColor = System.Drawing.Color.Tomato;
            this.lstbORG.FormattingEnabled = true;
            this.lstbORG.ItemHeight = 30;
            this.lstbORG.Location = new System.Drawing.Point(23, 63);
            this.lstbORG.Name = "lstbORG";
            this.lstbORG.Size = new System.Drawing.Size(254, 180);
            this.lstbORG.TabIndex = 0;
            // 
            // btnMAIN
            // 
            this.btnMAIN.ActiveControl = null;
            this.btnMAIN.Location = new System.Drawing.Point(23, 251);
            this.btnMAIN.Name = "btnMAIN";
            this.btnMAIN.Size = new System.Drawing.Size(254, 58);
            this.btnMAIN.Style = MetroFramework.MetroColorStyle.Green;
            this.btnMAIN.TabIndex = 1;
            this.btnMAIN.Text = "GO";
            this.btnMAIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMAIN.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnMAIN.UseSelectable = true;
            this.btnMAIN.Click += new System.EventHandler(this.btnMAIN_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.BackColor = System.Drawing.Color.Red;
            this.metroButton2.ForeColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(23, 309);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(254, 51);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 29;
            this.metroButton2.Text = "CLOSE";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // frmORG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 372);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btnMAIN);
            this.Controls.Add(this.lstbORG);
            this.Name = "frmORG";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "SELECT UNIT";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmORG_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbORG;
        private MetroFramework.Controls.MetroTile btnMAIN;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}