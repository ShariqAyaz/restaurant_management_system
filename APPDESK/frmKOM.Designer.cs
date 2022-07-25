namespace APPDESK
{
    partial class frmKOM
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
            this.components = new System.ComponentModel.Container();
            this.btn_Sync = new MetroFramework.Controls.MetroTile();
            this.btnProdNaming = new MetroFramework.Controls.MetroTile();
            this.btnNewKitchen = new MetroFramework.Controls.MetroTile();
            this.grpKitchen = new System.Windows.Forms.GroupBox();
            this.flpKitchen = new System.Windows.Forms.FlowLayoutPanel();
            this.rbUrdu = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.btnKitchen = new MetroFramework.Controls.MetroButton();
            this.txtbR_CUR = new MetroFramework.Controls.MetroTextBox();
            this.txtbR_LAST = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFetch = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtbFF_CUR = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtbFF_LAST = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpKitchen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Sync
            // 
            this.btn_Sync.ActiveControl = null;
            this.btn_Sync.Location = new System.Drawing.Point(23, 63);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(303, 88);
            this.btn_Sync.Style = MetroFramework.MetroColorStyle.Lime;
            this.btn_Sync.TabIndex = 0;
            this.btn_Sync.Text = "SYNC PRODUCTS\r\nFASTFOOD && RESTAURANT";
            this.btn_Sync.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Sync.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sync.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_Sync.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Sync.UseSelectable = true;
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // btnProdNaming
            // 
            this.btnProdNaming.ActiveControl = null;
            this.btnProdNaming.Location = new System.Drawing.Point(332, 63);
            this.btnProdNaming.Name = "btnProdNaming";
            this.btnProdNaming.Size = new System.Drawing.Size(303, 88);
            this.btnProdNaming.Style = MetroFramework.MetroColorStyle.Green;
            this.btnProdNaming.TabIndex = 1;
            this.btnProdNaming.Text = "PRODUCT URDU NAMING";
            this.btnProdNaming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProdNaming.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdNaming.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnProdNaming.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnProdNaming.UseSelectable = true;
            // 
            // btnNewKitchen
            // 
            this.btnNewKitchen.ActiveControl = null;
            this.btnNewKitchen.Location = new System.Drawing.Point(641, 63);
            this.btnNewKitchen.Name = "btnNewKitchen";
            this.btnNewKitchen.Size = new System.Drawing.Size(303, 88);
            this.btnNewKitchen.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnNewKitchen.TabIndex = 2;
            this.btnNewKitchen.Text = "CREATE NEW KITCHEN";
            this.btnNewKitchen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewKitchen.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewKitchen.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnNewKitchen.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnNewKitchen.UseSelectable = true;
            this.btnNewKitchen.Click += new System.EventHandler(this.btnNewKitchen_Click);
            // 
            // grpKitchen
            // 
            this.grpKitchen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKitchen.Controls.Add(this.flpKitchen);
            this.grpKitchen.Location = new System.Drawing.Point(23, 392);
            this.grpKitchen.Name = "grpKitchen";
            this.grpKitchen.Size = new System.Drawing.Size(921, 188);
            this.grpKitchen.TabIndex = 3;
            this.grpKitchen.TabStop = false;
            // 
            // flpKitchen
            // 
            this.flpKitchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKitchen.Location = new System.Drawing.Point(3, 16);
            this.flpKitchen.Name = "flpKitchen";
            this.flpKitchen.Size = new System.Drawing.Size(915, 169);
            this.flpKitchen.TabIndex = 0;
            // 
            // rbUrdu
            // 
            this.rbUrdu.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbUrdu.AutoSize = true;
            this.rbUrdu.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbUrdu.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbUrdu.Location = new System.Drawing.Point(867, 362);
            this.rbUrdu.Name = "rbUrdu";
            this.rbUrdu.Size = new System.Drawing.Size(79, 25);
            this.rbUrdu.TabIndex = 4;
            this.rbUrdu.Text = "URDU";
            this.rbUrdu.UseSelectable = true;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Checked = true;
            this.metroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroRadioButton1.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.metroRadioButton1.Location = new System.Drawing.Point(757, 362);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(104, 25);
            this.metroRadioButton1.TabIndex = 5;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "ENGLISH";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // btnKitchen
            // 
            this.btnKitchen.Location = new System.Drawing.Point(23, 358);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(148, 35);
            this.btnKitchen.TabIndex = 6;
            this.btnKitchen.Text = "REFRESH KITCHEN";
            this.btnKitchen.UseSelectable = true;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // txtbR_CUR
            // 
            // 
            // 
            // 
            this.txtbR_CUR.CustomButton.Image = null;
            this.txtbR_CUR.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtbR_CUR.CustomButton.Name = "";
            this.txtbR_CUR.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtbR_CUR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbR_CUR.CustomButton.TabIndex = 1;
            this.txtbR_CUR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbR_CUR.CustomButton.UseSelectable = true;
            this.txtbR_CUR.CustomButton.Visible = false;
            this.txtbR_CUR.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtbR_CUR.Lines = new string[] {
        "0"};
            this.txtbR_CUR.Location = new System.Drawing.Point(244, 90);
            this.txtbR_CUR.MaxLength = 32767;
            this.txtbR_CUR.Name = "txtbR_CUR";
            this.txtbR_CUR.PasswordChar = '\0';
            this.txtbR_CUR.ReadOnly = true;
            this.txtbR_CUR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbR_CUR.SelectedText = "";
            this.txtbR_CUR.SelectionLength = 0;
            this.txtbR_CUR.SelectionStart = 0;
            this.txtbR_CUR.ShortcutsEnabled = true;
            this.txtbR_CUR.Size = new System.Drawing.Size(165, 31);
            this.txtbR_CUR.TabIndex = 10;
            this.txtbR_CUR.Text = "0";
            this.txtbR_CUR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbR_CUR.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbR_CUR.UseSelectable = true;
            this.txtbR_CUR.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbR_CUR.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtbR_LAST
            // 
            // 
            // 
            // 
            this.txtbR_LAST.CustomButton.Image = null;
            this.txtbR_LAST.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtbR_LAST.CustomButton.Name = "";
            this.txtbR_LAST.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtbR_LAST.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbR_LAST.CustomButton.TabIndex = 1;
            this.txtbR_LAST.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbR_LAST.CustomButton.UseSelectable = true;
            this.txtbR_LAST.CustomButton.Visible = false;
            this.txtbR_LAST.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtbR_LAST.Lines = new string[] {
        "0"};
            this.txtbR_LAST.Location = new System.Drawing.Point(244, 53);
            this.txtbR_LAST.MaxLength = 32767;
            this.txtbR_LAST.Name = "txtbR_LAST";
            this.txtbR_LAST.PasswordChar = '\0';
            this.txtbR_LAST.ReadOnly = true;
            this.txtbR_LAST.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbR_LAST.SelectedText = "";
            this.txtbR_LAST.SelectionLength = 0;
            this.txtbR_LAST.SelectionStart = 0;
            this.txtbR_LAST.ShortcutsEnabled = true;
            this.txtbR_LAST.Size = new System.Drawing.Size(165, 31);
            this.txtbR_LAST.TabIndex = 9;
            this.txtbR_LAST.Text = "0";
            this.txtbR_LAST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbR_LAST.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbR_LAST.UseSelectable = true;
            this.txtbR_LAST.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbR_LAST.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(19, 96);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(210, 25);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "CURRENT FETCH ORDER#";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(55, 53);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(174, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "LAST FETCH ORDER#";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnFetch);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtbFF_CUR);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtbFF_LAST);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtbR_CUR);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtbR_LAST);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(23, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 195);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnFetch
            // 
            this.btnFetch.ActiveControl = null;
            this.btnFetch.Location = new System.Drawing.Point(6, 138);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(142, 51);
            this.btnFetch.Style = MetroFramework.MetroColorStyle.Green;
            this.btnFetch.TabIndex = 17;
            this.btnFetch.Text = "FETCH NOW";
            this.btnFetch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFetch.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnFetch.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnFetch.UseSelectable = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(652, 16);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(104, 25);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "FASTFOOD";
            // 
            // txtbFF_CUR
            // 
            // 
            // 
            // 
            this.txtbFF_CUR.CustomButton.Image = null;
            this.txtbFF_CUR.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtbFF_CUR.CustomButton.Name = "";
            this.txtbFF_CUR.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtbFF_CUR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbFF_CUR.CustomButton.TabIndex = 1;
            this.txtbFF_CUR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbFF_CUR.CustomButton.UseSelectable = true;
            this.txtbFF_CUR.CustomButton.Visible = false;
            this.txtbFF_CUR.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtbFF_CUR.Lines = new string[] {
        "0"};
            this.txtbFF_CUR.Location = new System.Drawing.Point(713, 90);
            this.txtbFF_CUR.MaxLength = 32767;
            this.txtbFF_CUR.Name = "txtbFF_CUR";
            this.txtbFF_CUR.PasswordChar = '\0';
            this.txtbFF_CUR.ReadOnly = true;
            this.txtbFF_CUR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbFF_CUR.SelectedText = "";
            this.txtbFF_CUR.SelectionLength = 0;
            this.txtbFF_CUR.SelectionStart = 0;
            this.txtbFF_CUR.ShortcutsEnabled = true;
            this.txtbFF_CUR.Size = new System.Drawing.Size(165, 31);
            this.txtbFF_CUR.TabIndex = 15;
            this.txtbFF_CUR.Text = "0";
            this.txtbFF_CUR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbFF_CUR.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbFF_CUR.UseSelectable = true;
            this.txtbFF_CUR.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbFF_CUR.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(524, 53);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(174, 25);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "LAST FETCH ORDER#";
            // 
            // txtbFF_LAST
            // 
            // 
            // 
            // 
            this.txtbFF_LAST.CustomButton.Image = null;
            this.txtbFF_LAST.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtbFF_LAST.CustomButton.Name = "";
            this.txtbFF_LAST.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtbFF_LAST.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbFF_LAST.CustomButton.TabIndex = 1;
            this.txtbFF_LAST.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbFF_LAST.CustomButton.UseSelectable = true;
            this.txtbFF_LAST.CustomButton.Visible = false;
            this.txtbFF_LAST.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtbFF_LAST.Lines = new string[] {
        "0"};
            this.txtbFF_LAST.Location = new System.Drawing.Point(713, 53);
            this.txtbFF_LAST.MaxLength = 32767;
            this.txtbFF_LAST.Name = "txtbFF_LAST";
            this.txtbFF_LAST.PasswordChar = '\0';
            this.txtbFF_LAST.ReadOnly = true;
            this.txtbFF_LAST.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbFF_LAST.SelectedText = "";
            this.txtbFF_LAST.SelectionLength = 0;
            this.txtbFF_LAST.SelectionStart = 0;
            this.txtbFF_LAST.ShortcutsEnabled = true;
            this.txtbFF_LAST.Size = new System.Drawing.Size(165, 31);
            this.txtbFF_LAST.TabIndex = 14;
            this.txtbFF_LAST.Text = "0";
            this.txtbFF_LAST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbFF_LAST.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbFF_LAST.UseSelectable = true;
            this.txtbFF_LAST.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbFF_LAST.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(488, 96);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(210, 25);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "CURRENT FETCH ORDER#";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(145, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(130, 25);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "RESTAURANT";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmKOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKitchen);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.rbUrdu);
            this.Controls.Add(this.grpKitchen);
            this.Controls.Add(this.btnNewKitchen);
            this.Controls.Add(this.btnProdNaming);
            this.Controls.Add(this.btn_Sync);
            this.Name = "frmKOM";
            this.Text = "KITCHEN MANAGER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKOM_FormClosing);
            this.Load += new System.EventHandler(this.frmKOM_Load);
            this.grpKitchen.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_Sync;
        private MetroFramework.Controls.MetroTile btnProdNaming;
        private MetroFramework.Controls.MetroTile btnNewKitchen;
        private System.Windows.Forms.GroupBox grpKitchen;
        private System.Windows.Forms.FlowLayoutPanel flpKitchen;
        private MetroFramework.Controls.MetroRadioButton rbUrdu;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroButton btnKitchen;
        private MetroFramework.Controls.MetroTextBox txtbR_CUR;
        private MetroFramework.Controls.MetroTextBox txtbR_LAST;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtbFF_CUR;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtbFF_LAST;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile btnFetch;
        private System.Windows.Forms.Timer timer1;
    }
}