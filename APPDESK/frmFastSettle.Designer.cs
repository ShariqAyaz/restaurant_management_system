namespace APPDESK
{
    partial class frmFastSettle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettle = new MetroFramework.Controls.MetroTile();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtbMessage = new System.Windows.Forms.TextBox();
            this.gridItem = new MetroFramework.Controls.MetroGrid();
            this.rESFETCHTICKETDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSITERPDataSet = new APPDESK.ESITERPDataSet();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtbTOT = new System.Windows.Forms.TextBox();
            this.txtbBcode = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rES_FETCHTICKET_TA = new APPDESK.ESITERPDataSetTableAdapters.RES_FETCHTICKET_TA();
            this.TTIP = new MetroFramework.Components.MetroToolTip();
            this.txtbTICKETNO = new System.Windows.Forms.TextBox();
            this.lblUser = new MetroFramework.Controls.MetroLabel();
            this.menuItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatingUserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESFETCHTICKETDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSITERPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.Location = new System.Drawing.Point(3, 476);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(273, 111);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Red;
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "CLOSE";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnClose.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.btnSettle);
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Controls.Add(this.lblUser);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(187, 637);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APPDESK.Properties.Resources.PicsArt_06_28_08_55_20;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 265);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSettle
            // 
            this.btnSettle.ActiveControl = null;
            this.btnSettle.Location = new System.Drawing.Point(3, 274);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(273, 196);
            this.btnSettle.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSettle.TabIndex = 1;
            this.btnSettle.Text = "SETTLE";
            this.btnSettle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSettle.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnSettle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnSettle.UseSelectable = true;
            this.btnSettle.Click += new System.EventHandler(this.btnSettle_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtbMessage);
            this.splitContainer1.Panel2.Controls.Add(this.txtbTICKETNO);
            this.splitContainer1.Panel2.Controls.Add(this.gridItem);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel2.Controls.Add(this.txtbTOT);
            this.splitContainer1.Panel2.Controls.Add(this.txtbBcode);
            this.splitContainer1.Size = new System.Drawing.Size(977, 637);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 3;
            // 
            // txtbMessage
            // 
            this.txtbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbMessage.BackColor = System.Drawing.Color.Yellow;
            this.txtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbMessage.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMessage.ForeColor = System.Drawing.Color.Black;
            this.txtbMessage.Location = new System.Drawing.Point(12, 580);
            this.txtbMessage.Multiline = true;
            this.txtbMessage.Name = "txtbMessage";
            this.txtbMessage.ReadOnly = true;
            this.txtbMessage.Size = new System.Drawing.Size(285, 54);
            this.txtbMessage.TabIndex = 4;
            this.txtbMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gridItem
            // 
            this.gridItem.AllowUserToAddRows = false;
            this.gridItem.AllowUserToDeleteRows = false;
            this.gridItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridItem.AutoGenerateColumns = false;
            this.gridItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuItemNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.creatingUserNameDataGridViewTextBoxColumn,
            this.entityNameDataGridViewTextBoxColumn});
            this.gridItem.DataSource = this.rESFETCHTICKETDTBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridItem.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridItem.EnableHeadersVisualStyles = false;
            this.gridItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridItem.Location = new System.Drawing.Point(3, 55);
            this.gridItem.Name = "gridItem";
            this.gridItem.ReadOnly = true;
            this.gridItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItem.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridItem.RowTemplate.Height = 35;
            this.gridItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItem.Size = new System.Drawing.Size(780, 519);
            this.gridItem.TabIndex = 3;
            // 
            // rESFETCHTICKETDTBindingSource
            // 
            this.rESFETCHTICKETDTBindingSource.DataMember = "RES-FETCHTICKET-DT";
            this.rESFETCHTICKETDTBindingSource.DataSource = this.eSITERPDataSet;
            // 
            // eSITERPDataSet
            // 
            this.eSITERPDataSet.DataSetName = "ESITERPDataSet";
            this.eSITERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(303, 596);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "TOTAL BILL: ";
            // 
            // txtbTOT
            // 
            this.txtbTOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbTOT.BackColor = System.Drawing.Color.Black;
            this.txtbTOT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbTOT.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTOT.ForeColor = System.Drawing.Color.White;
            this.txtbTOT.Location = new System.Drawing.Point(427, 580);
            this.txtbTOT.Name = "txtbTOT";
            this.txtbTOT.ReadOnly = true;
            this.txtbTOT.Size = new System.Drawing.Size(356, 54);
            this.txtbTOT.TabIndex = 1;
            this.txtbTOT.Text = "0.00";
            this.txtbTOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbBcode
            // 
            this.txtbBcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbBcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.txtbBcode.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtbBcode.Location = new System.Drawing.Point(3, 3);
            this.txtbBcode.Name = "txtbBcode";
            this.txtbBcode.Size = new System.Drawing.Size(399, 41);
            this.txtbBcode.TabIndex = 0;
            this.txtbBcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rES_FETCHTICKET_TA
            // 
            this.rES_FETCHTICKET_TA.ClearBeforeFill = true;
            // 
            // TTIP
            // 
            this.TTIP.AutoPopDelay = 2000;
            this.TTIP.InitialDelay = 500;
            this.TTIP.ReshowDelay = 100;
            this.TTIP.Style = MetroFramework.MetroColorStyle.Orange;
            this.TTIP.StyleManager = null;
            this.TTIP.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtbTICKETNO
            // 
            this.txtbTICKETNO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbTICKETNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtbTICKETNO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbTICKETNO.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.txtbTICKETNO.ForeColor = System.Drawing.Color.White;
            this.txtbTICKETNO.Location = new System.Drawing.Point(408, 3);
            this.txtbTICKETNO.Name = "txtbTICKETNO";
            this.txtbTICKETNO.ReadOnly = true;
            this.txtbTICKETNO.Size = new System.Drawing.Size(375, 46);
            this.txtbTICKETNO.TabIndex = 2;
            this.txtbTICKETNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUser.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUser.Location = new System.Drawing.Point(3, 590);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(67, 25);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "USER: ";
            // 
            // menuItemNameDataGridViewTextBoxColumn
            // 
            this.menuItemNameDataGridViewTextBoxColumn.DataPropertyName = "MenuItemName";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.menuItemNameDataGridViewTextBoxColumn.HeaderText = "ITEM NAME";
            this.menuItemNameDataGridViewTextBoxColumn.Name = "menuItemNameDataGridViewTextBoxColumn";
            this.menuItemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.menuItemNameDataGridViewTextBoxColumn.Width = 210;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.priceDataGridViewTextBoxColumn.HeaderText = "RATE";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 120;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "QUANTITY";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 120;
            // 
            // creatingUserNameDataGridViewTextBoxColumn
            // 
            this.creatingUserNameDataGridViewTextBoxColumn.DataPropertyName = "CreatingUserName";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatingUserNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.creatingUserNameDataGridViewTextBoxColumn.HeaderText = "USER";
            this.creatingUserNameDataGridViewTextBoxColumn.Name = "creatingUserNameDataGridViewTextBoxColumn";
            this.creatingUserNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.creatingUserNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // entityNameDataGridViewTextBoxColumn
            // 
            this.entityNameDataGridViewTextBoxColumn.DataPropertyName = "EntityName";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.entityNameDataGridViewTextBoxColumn.HeaderText = "TABLE / ENTITY";
            this.entityNameDataGridViewTextBoxColumn.Name = "entityNameDataGridViewTextBoxColumn";
            this.entityNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.entityNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // frmFastSettle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 707);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmFastSettle";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "DIRECT SETTLE - EATERY MANAGER - ESOL INTIME";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFastSettle_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESFETCHTICKETDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSITERPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroTile btnSettle;
        private System.Windows.Forms.TextBox txtbBcode;
        private System.Windows.Forms.TextBox txtbTOT;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroGrid gridItem;
        private System.Windows.Forms.BindingSource rESFETCHTICKETDTBindingSource;
        private ESITERPDataSet eSITERPDataSet;
        private ESITERPDataSetTableAdapters.RES_FETCHTICKET_TA rES_FETCHTICKET_TA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroToolTip TTIP;
        private System.Windows.Forms.TextBox txtbMessage;
        private System.Windows.Forms.TextBox txtbTICKETNO;
        private MetroFramework.Controls.MetroLabel lblUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatingUserNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entityNameDataGridViewTextBoxColumn;
    }
}