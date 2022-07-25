namespace APPDESK
{
    partial class frmNewKitchen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.kid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kITDETDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSITERPDataSet = new APPDESK.ESITERPDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbProd = new System.Windows.Forms.GroupBox();
            this.btnDel = new MetroFramework.Controls.MetroTile();
            this.cboxProd = new System.Windows.Forms.ComboBox();
            this.kITCHENMENUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnSaveNext = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnCreateNew = new MetroFramework.Controls.MetroButton();
            this.cboxORG = new System.Windows.Forms.ComboBox();
            this.bentityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboxKitchen = new System.Windows.Forms.ComboBox();
            this.kMSKitchenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.kMS_KitchenTableAdapter = new APPDESK.ESITERPDataSetTableAdapters.KMS_KitchenTableAdapter();
            this.b_entityTableAdapter = new APPDESK.ESITERPDataSetTableAdapters.b_entityTableAdapter();
            this.kITDETTA = new APPDESK.ESITERPDataSetTableAdapters.KITDETTA();
            this.kITCHENMENUTableAdapter = new APPDESK.ESITERPDataSetTableAdapters.KITCHENMENUTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kITDETDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSITERPDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kITCHENMENUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bentityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kMSKitchenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.metroGrid1);
            this.groupBox2.Location = new System.Drawing.Point(23, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 293);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kid,
            this.fgid,
            this.pname,
            this.prodid,
            this.location});
            this.metroGrid1.DataSource = this.kITDETDTBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 16);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(865, 274);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.DoubleClick += new System.EventHandler(this.metroGrid1_DoubleClick);
            // 
            // kid
            // 
            this.kid.DataPropertyName = "KID";
            this.kid.HeaderText = "KID";
            this.kid.Name = "kid";
            this.kid.ReadOnly = true;
            // 
            // fgid
            // 
            this.fgid.DataPropertyName = "FGID";
            this.fgid.HeaderText = "FGID";
            this.fgid.Name = "fgid";
            this.fgid.ReadOnly = true;
            // 
            // pname
            // 
            this.pname.DataPropertyName = "PNAME";
            this.pname.HeaderText = "PNAME";
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            // 
            // prodid
            // 
            this.prodid.DataPropertyName = "PRODID";
            this.prodid.HeaderText = "PRODID";
            this.prodid.Name = "prodid";
            this.prodid.ReadOnly = true;
            // 
            // location
            // 
            this.location.DataPropertyName = "LOCATION";
            this.location.HeaderText = "LOCATION";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // kITDETDTBindingSource
            // 
            this.kITDETDTBindingSource.DataMember = "KITDETDT";
            this.kITDETDTBindingSource.DataSource = this.eSITERPDataSet;
            // 
            // eSITERPDataSet
            // 
            this.eSITERPDataSet.DataSetName = "ESITERPDataSet";
            this.eSITERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.gbProd);
            this.groupBox1.Controls.Add(this.btnCreateNew);
            this.groupBox1.Controls.Add(this.cboxORG);
            this.groupBox1.Controls.Add(this.cboxKitchen);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // gbProd
            // 
            this.gbProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProd.Controls.Add(this.cboxProd);
            this.gbProd.Controls.Add(this.btnClose);
            this.gbProd.Controls.Add(this.btnSaveNext);
            this.gbProd.Controls.Add(this.metroLabel3);
            this.gbProd.Location = new System.Drawing.Point(6, 53);
            this.gbProd.Name = "gbProd";
            this.gbProd.Size = new System.Drawing.Size(859, 65);
            this.gbProd.TabIndex = 10;
            this.gbProd.TabStop = false;
            // 
            // btnDel
            // 
            this.btnDel.ActiveControl = null;
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(701, 14);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(163, 43);
            this.btnDel.Style = MetroFramework.MetroColorStyle.Red;
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "Delete";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDel.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnDel.UseSelectable = true;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cboxProd
            // 
            this.cboxProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxProd.DataSource = this.kITCHENMENUBindingSource;
            this.cboxProd.DisplayMember = "name";
            this.cboxProd.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F);
            this.cboxProd.FormattingEnabled = true;
            this.cboxProd.Location = new System.Drawing.Point(109, 22);
            this.cboxProd.Name = "cboxProd";
            this.cboxProd.Size = new System.Drawing.Size(440, 33);
            this.cboxProd.TabIndex = 9;
            this.cboxProd.ValueMember = "id";
            // 
            // kITCHENMENUBindingSource
            // 
            this.kITCHENMENUBindingSource.DataMember = "KITCHENMENU";
            this.kITCHENMENUBindingSource.DataSource = this.eSITERPDataSet;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(739, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 31);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Green;
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveNext
            // 
            this.btnSaveNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNext.Location = new System.Drawing.Point(634, 22);
            this.btnSaveNext.Name = "btnSaveNext";
            this.btnSaveNext.Size = new System.Drawing.Size(99, 33);
            this.btnSaveNext.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSaveNext.TabIndex = 11;
            this.btnSaveNext.Text = "Add";
            this.btnSaveNext.UseSelectable = true;
            this.btnSaveNext.Click += new System.EventHandler(this.btnSaveNext_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(13, 28);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 25);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "PRODUCT";
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(596, 14);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(99, 33);
            this.btnCreateNew.Style = MetroFramework.MetroColorStyle.Green;
            this.btnCreateNew.TabIndex = 9;
            this.btnCreateNew.Text = "Create";
            this.btnCreateNew.UseSelectable = true;
            this.btnCreateNew.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cboxORG
            // 
            this.cboxORG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxORG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxORG.DataSource = this.bentityBindingSource;
            this.cboxORG.DisplayMember = "entity_name";
            this.cboxORG.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F);
            this.cboxORG.FormattingEnabled = true;
            this.cboxORG.Location = new System.Drawing.Point(417, 14);
            this.cboxORG.Name = "cboxORG";
            this.cboxORG.Size = new System.Drawing.Size(173, 33);
            this.cboxORG.TabIndex = 2;
            this.cboxORG.ValueMember = "id";
            // 
            // bentityBindingSource
            // 
            this.bentityBindingSource.DataMember = "b_entity";
            this.bentityBindingSource.DataSource = this.eSITERPDataSet;
            // 
            // cboxKitchen
            // 
            this.cboxKitchen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxKitchen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxKitchen.DataSource = this.kMSKitchenBindingSource;
            this.cboxKitchen.DisplayMember = "Kitchen Name";
            this.cboxKitchen.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F);
            this.cboxKitchen.FormattingEnabled = true;
            this.cboxKitchen.Location = new System.Drawing.Point(130, 14);
            this.cboxKitchen.Name = "cboxKitchen";
            this.cboxKitchen.Size = new System.Drawing.Size(227, 33);
            this.cboxKitchen.TabIndex = 1;
            this.cboxKitchen.ValueMember = "id";
            this.cboxKitchen.SelectedIndexChanged += new System.EventHandler(this.cboxKitchen_SelectedIndexChanged);
            // 
            // kMSKitchenBindingSource
            // 
            this.kMSKitchenBindingSource.DataMember = "KMS_Kitchen";
            this.kMSKitchenBindingSource.DataSource = this.eSITERPDataSet;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(6, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Kitchen Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(363, 18);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "ORG";
            // 
            // kMS_KitchenTableAdapter
            // 
            this.kMS_KitchenTableAdapter.ClearBeforeFill = true;
            // 
            // b_entityTableAdapter
            // 
            this.b_entityTableAdapter.ClearBeforeFill = true;
            // 
            // kITDETTA
            // 
            this.kITDETTA.ClearBeforeFill = true;
            // 
            // kITCHENMENUTableAdapter
            // 
            this.kITCHENMENUTableAdapter.ClearBeforeFill = true;
            // 
            // frmNewKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNewKitchen";
            this.Text = "NEW KITCHEN";
            this.Load += new System.EventHandler(this.frmNewKitchen_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kITDETDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSITERPDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbProd.ResumeLayout(false);
            this.gbProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kITCHENMENUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bentityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kMSKitchenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxORG;
        private System.Windows.Forms.ComboBox cboxKitchen;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnCreateNew;
        private System.Windows.Forms.GroupBox gbProd;
        private MetroFramework.Controls.MetroTile btnDel;
        private System.Windows.Forms.ComboBox cboxProd;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnSaveNext;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private ESITERPDataSet eSITERPDataSet;
        private System.Windows.Forms.BindingSource kMSKitchenBindingSource;
        private ESITERPDataSetTableAdapters.KMS_KitchenTableAdapter kMS_KitchenTableAdapter;
        private System.Windows.Forms.BindingSource bentityBindingSource;
        private ESITERPDataSetTableAdapters.b_entityTableAdapter b_entityTableAdapter;
        private System.Windows.Forms.BindingSource kITDETDTBindingSource;
        private ESITERPDataSetTableAdapters.KITDETTA kITDETTA;
        private System.Windows.Forms.BindingSource kITCHENMENUBindingSource;
        private ESITERPDataSetTableAdapters.KITCHENMENUTableAdapter kITCHENMENUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
    }
}