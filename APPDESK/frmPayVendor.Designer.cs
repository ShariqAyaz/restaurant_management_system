namespace APPDESK
{
    partial class frmPayVendor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vendor_Payslip_DTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendor_DS = new APPDESK.vendor_DS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vendor_Payslip_DTTableAdapter = new APPDESK.vendor_DSTableAdapters.vendor_Payslip_DTTableAdapter();
            this.vendormasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSITERPDataSet = new APPDESK.ESITERPDataSet();
            this.txtbVSearch = new System.Windows.Forms.TextBox();
            this.lblSUP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NUPDAmt = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbRemarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrintOnly = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.vTRANDTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendor_masterTableAdapter = new APPDESK.ESITERPDataSetTableAdapters.vendor_masterTableAdapter();
            this.vendormasterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountsTableAdapter = new APPDESK.ESITERPDataSetTableAdapters.AccountsTableAdapter();
            this.vTRANDTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxTNO = new MetroFramework.Controls.MetroComboBox();
            this.gridSupplier = new MetroFramework.Controls.MetroGrid();
            this.gridACC = new MetroFramework.Controls.MetroGrid();
            this.id_acc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSavePrint = new MetroFramework.Controls.MetroButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vendor_Payslip_DTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendor_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendormasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSITERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUPDAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTRANDTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendormasterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTRANDTBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridACC)).BeginInit();
            this.SuspendLayout();
            // 
            // vendor_Payslip_DTBindingSource
            // 
            this.vendor_Payslip_DTBindingSource.DataMember = "vendor_Payslip_DT";
            this.vendor_Payslip_DTBindingSource.DataSource = this.vendor_DS;
            // 
            // vendor_DS
            // 
            this.vendor_DS.DataSetName = "vendor_DS";
            this.vendor_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.vendor_Payslip_DTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "APPDESK.rp_VendorPay.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(260, 460);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.reportViewer1_RenderingComplete);
            // 
            // vendor_Payslip_DTTableAdapter
            // 
            this.vendor_Payslip_DTTableAdapter.ClearBeforeFill = true;
            // 
            // vendormasterBindingSource
            // 
            this.vendormasterBindingSource.DataMember = "vendor_master";
            this.vendormasterBindingSource.DataSource = this.eSITERPDataSet;
            // 
            // eSITERPDataSet
            // 
            this.eSITERPDataSet.DataSetName = "ESITERPDataSet";
            this.eSITERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbVSearch
            // 
            this.txtbVSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbVSearch.Location = new System.Drawing.Point(411, 132);
            this.txtbVSearch.Name = "txtbVSearch";
            this.txtbVSearch.Size = new System.Drawing.Size(186, 35);
            this.txtbVSearch.TabIndex = 4;
            this.txtbVSearch.TextChanged += new System.EventHandler(this.txtbVSearch_TextChanged);
            // 
            // lblSUP
            // 
            this.lblSUP.AutoSize = true;
            this.lblSUP.BackColor = System.Drawing.Color.Transparent;
            this.lblSUP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSUP.ForeColor = System.Drawing.Color.Black;
            this.lblSUP.Location = new System.Drawing.Point(275, 139);
            this.lblSUP.Name = "lblSUP";
            this.lblSUP.Size = new System.Drawing.Size(126, 19);
            this.lblSUP.TabIndex = 6;
            this.lblSUP.Text = "SEARCH SUPPLIER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(275, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "SELECT ACCOUNT";
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.eSITERPDataSet;
            // 
            // NUPDAmt
            // 
            this.NUPDAmt.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUPDAmt.Location = new System.Drawing.Point(366, 457);
            this.NUPDAmt.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUPDAmt.Name = "NUPDAmt";
            this.NUPDAmt.Size = new System.Drawing.Size(231, 29);
            this.NUPDAmt.TabIndex = 11;
            this.NUPDAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(279, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "AMOUNT";
            // 
            // txtbRemarks
            // 
            this.txtbRemarks.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRemarks.Location = new System.Drawing.Point(366, 492);
            this.txtbRemarks.Name = "txtbRemarks";
            this.txtbRemarks.Size = new System.Drawing.Size(231, 35);
            this.txtbRemarks.TabIndex = 13;
            this.txtbRemarks.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(279, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "REMARKS";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(415, 533);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrintOnly
            // 
            this.btnPrintOnly.Location = new System.Drawing.Point(12, 533);
            this.btnPrintOnly.Name = "btnPrintOnly";
            this.btnPrintOnly.Size = new System.Drawing.Size(75, 28);
            this.btnPrintOnly.TabIndex = 16;
            this.btnPrintOnly.Text = "PRINT";
            this.btnPrintOnly.UseVisualStyleBackColor = true;
            this.btnPrintOnly.Click += new System.EventHandler(this.btnPrintOnly_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(275, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "TRANS. NO";
            // 
            // vTRANDTBindingSource1
            // 
            this.vTRANDTBindingSource1.DataMember = "VTRAN-DT";
            this.vTRANDTBindingSource1.DataSource = this.eSITERPDataSet;
            // 
            // vendor_masterTableAdapter
            // 
            this.vendor_masterTableAdapter.ClearBeforeFill = true;
            // 
            // vendormasterBindingSource1
            // 
            this.vendormasterBindingSource1.DataMember = "vendor_master";
            this.vendormasterBindingSource1.DataSource = this.eSITERPDataSet;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // vTRANDTBindingSource2
            // 
            this.vTRANDTBindingSource2.DataMember = "VTRAN-DT";
            this.vTRANDTBindingSource2.DataSource = this.eSITERPDataSet;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Location = new System.Drawing.Point(367, 98);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(230, 31);
            this.dtp.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(275, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Date";
            // 
            // cboxTNO
            // 
            this.cboxTNO.FormattingEnabled = true;
            this.cboxTNO.ItemHeight = 23;
            this.cboxTNO.Location = new System.Drawing.Point(366, 63);
            this.cboxTNO.Name = "cboxTNO";
            this.cboxTNO.Size = new System.Drawing.Size(231, 29);
            this.cboxTNO.TabIndex = 21;
            this.cboxTNO.UseSelectable = true;
            // 
            // gridSupplier
            // 
            this.gridSupplier.AllowUserToAddRows = false;
            this.gridSupplier.AllowUserToDeleteRows = false;
            this.gridSupplier.AllowUserToResizeRows = false;
            this.gridSupplier.AutoGenerateColumns = false;
            this.gridSupplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSupplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridSupplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.VendorName,
            this.goods_desc});
            this.gridSupplier.DataSource = this.vendormasterBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSupplier.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridSupplier.EnableHeadersVisualStyles = false;
            this.gridSupplier.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridSupplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridSupplier.Location = new System.Drawing.Point(279, 173);
            this.gridSupplier.Name = "gridSupplier";
            this.gridSupplier.ReadOnly = true;
            this.gridSupplier.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSupplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridSupplier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSupplier.Size = new System.Drawing.Size(318, 142);
            this.gridSupplier.TabIndex = 22;
            this.gridSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSupplier_CellClick_1);
            // 
            // gridACC
            // 
            this.gridACC.AllowUserToAddRows = false;
            this.gridACC.AllowUserToDeleteRows = false;
            this.gridACC.AllowUserToResizeRows = false;
            this.gridACC.AutoGenerateColumns = false;
            this.gridACC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridACC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridACC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridACC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridACC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridACC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridACC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_acc,
            this.Account_name});
            this.gridACC.DataSource = this.accountsBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridACC.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridACC.EnableHeadersVisualStyles = false;
            this.gridACC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridACC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridACC.Location = new System.Drawing.Point(279, 340);
            this.gridACC.Name = "gridACC";
            this.gridACC.ReadOnly = true;
            this.gridACC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridACC.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridACC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridACC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridACC.Size = new System.Drawing.Size(318, 111);
            this.gridACC.TabIndex = 23;
            this.gridACC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridACC_CellClick);
            // 
            // id_acc
            // 
            this.id_acc.DataPropertyName = "id";
            this.id_acc.HeaderText = "id";
            this.id_acc.Name = "id_acc";
            this.id_acc.ReadOnly = true;
            // 
            // Account_name
            // 
            this.Account_name.DataPropertyName = "Account_name";
            this.Account_name.HeaderText = "Account_name";
            this.Account_name.Name = "Account_name";
            this.Account_name.ReadOnly = true;
            this.Account_name.Width = 150;
            // 
            // btnSavePrint
            // 
            this.btnSavePrint.Location = new System.Drawing.Point(496, 533);
            this.btnSavePrint.Name = "btnSavePrint";
            this.btnSavePrint.Size = new System.Drawing.Size(101, 28);
            this.btnSavePrint.TabIndex = 24;
            this.btnSavePrint.Text = "Save && Print";
            this.btnSavePrint.UseSelectable = true;
            this.btnSavePrint.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // VendorName
            // 
            this.VendorName.DataPropertyName = "VendorName";
            this.VendorName.HeaderText = "VendorName";
            this.VendorName.Name = "VendorName";
            this.VendorName.ReadOnly = true;
            this.VendorName.Width = 150;
            // 
            // goods_desc
            // 
            this.goods_desc.DataPropertyName = "goods_desc";
            this.goods_desc.HeaderText = "goods_desc";
            this.goods_desc.Name = "goods_desc";
            this.goods_desc.ReadOnly = true;
            this.goods_desc.Width = 80;
            // 
            // frmPayVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 574);
            this.Controls.Add(this.btnSavePrint);
            this.Controls.Add(this.gridACC);
            this.Controls.Add(this.gridSupplier);
            this.Controls.Add(this.cboxTNO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPrintOnly);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbRemarks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUPDAmt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSUP);
            this.Controls.Add(this.txtbVSearch);
            this.Controls.Add(this.reportViewer1);
            this.MaximumSize = new System.Drawing.Size(612, 574);
            this.MinimumSize = new System.Drawing.Size(612, 574);
            this.Name = "frmPayVendor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "VENDOR PAYMENT";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmPayVendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendor_Payslip_DTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendor_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendormasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSITERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUPDAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTRANDTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendormasterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTRANDTBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridACC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vendor_Payslip_DTBindingSource;
        private vendor_DS vendor_DS;
        private vendor_DSTableAdapters.vendor_Payslip_DTTableAdapter vendor_Payslip_DTTableAdapter;
        private System.Windows.Forms.TextBox txtbVSearch;
        private System.Windows.Forms.Label lblSUP;
        private ESITERPDataSet eSITERPDataSet;
        private System.Windows.Forms.BindingSource vendormasterBindingSource;
        private ESITERPDataSetTableAdapters.vendor_masterTableAdapter vendor_masterTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vendormasterBindingSource1;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private ESITERPDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.NumericUpDown NUPDAmt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbRemarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrintOnly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource vTRANDTBindingSource1;
        private System.Windows.Forms.BindingSource vTRANDTBindingSource2;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cboxTNO;
        private MetroFramework.Controls.MetroGrid gridSupplier;
        private MetroFramework.Controls.MetroGrid gridACC;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_acc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_name;
        private MetroFramework.Controls.MetroButton btnSavePrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_desc;
    }
}