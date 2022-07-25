namespace APPDESK
{
    partial class frmFastfoodsPurchases
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtST_T = new MetroFramework.Controls.MetroTextBox();
            this.txtbEndTicket = new MetroFramework.Controls.MetroTextBox();
            this.btnTransfer = new MetroFramework.Controls.MetroButton();
            this.dtpPdate = new MetroFramework.Controls.MetroDateTime();
            this.btnFetchData = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.gridACC = new MetroFramework.Controls.MetroGrid();
            this.id_acc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbAmt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.accountnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSITERPDataSet = new APPDESK.ESITERPDataSet();
            this.accountsTableAdapter = new APPDESK.ESITERPDataSetTableAdapters.AccountsTableAdapter();
            this.FFDT_FFPURCHASEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fFDTFFPURCHASEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fFDT_FFPURCHASE_TA = new APPDESK.ESITERPDataSetTableAdapters.FFDT_FFPURCHASE_TA();
            ((System.ComponentModel.ISupportInitialize)(this.gridACC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSITERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FFDT_FFPURCHASEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFDTFFPURCHASEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FFDT_FFPURCHASEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "APPDESK.rp_Fastfood_Purchase.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(8, 116);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(554, 364);
            this.reportViewer1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(8, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "First Ticket";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(233, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Last Ticket";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(573, 335);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(135, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Production Date";
            // 
            // txtST_T
            // 
            // 
            // 
            // 
            this.txtST_T.CustomButton.Image = null;
            this.txtST_T.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.txtST_T.CustomButton.Name = "";
            this.txtST_T.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtST_T.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtST_T.CustomButton.TabIndex = 1;
            this.txtST_T.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtST_T.CustomButton.UseSelectable = true;
            this.txtST_T.CustomButton.Visible = false;
            this.txtST_T.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtST_T.Lines = new string[] {
        "0"};
            this.txtST_T.Location = new System.Drawing.Point(104, 79);
            this.txtST_T.MaxLength = 32767;
            this.txtST_T.Name = "txtST_T";
            this.txtST_T.PasswordChar = '\0';
            this.txtST_T.ReadOnly = true;
            this.txtST_T.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtST_T.SelectedText = "";
            this.txtST_T.SelectionLength = 0;
            this.txtST_T.SelectionStart = 0;
            this.txtST_T.ShortcutsEnabled = true;
            this.txtST_T.Size = new System.Drawing.Size(123, 31);
            this.txtST_T.TabIndex = 4;
            this.txtST_T.Text = "0";
            this.txtST_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtST_T.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtST_T.UseSelectable = true;
            this.txtST_T.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtST_T.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtbEndTicket
            // 
            // 
            // 
            // 
            this.txtbEndTicket.CustomButton.Image = null;
            this.txtbEndTicket.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.txtbEndTicket.CustomButton.Name = "";
            this.txtbEndTicket.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtbEndTicket.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbEndTicket.CustomButton.TabIndex = 1;
            this.txtbEndTicket.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbEndTicket.CustomButton.UseSelectable = true;
            this.txtbEndTicket.CustomButton.Visible = false;
            this.txtbEndTicket.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtbEndTicket.Lines = new string[] {
        "0"};
            this.txtbEndTicket.Location = new System.Drawing.Point(328, 79);
            this.txtbEndTicket.MaxLength = 32767;
            this.txtbEndTicket.Name = "txtbEndTicket";
            this.txtbEndTicket.PasswordChar = '\0';
            this.txtbEndTicket.ReadOnly = true;
            this.txtbEndTicket.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbEndTicket.SelectedText = "";
            this.txtbEndTicket.SelectionLength = 0;
            this.txtbEndTicket.SelectionStart = 0;
            this.txtbEndTicket.ShortcutsEnabled = true;
            this.txtbEndTicket.Size = new System.Drawing.Size(123, 31);
            this.txtbEndTicket.TabIndex = 5;
            this.txtbEndTicket.Text = "0";
            this.txtbEndTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbEndTicket.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbEndTicket.UseSelectable = true;
            this.txtbEndTicket.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbEndTicket.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransfer.BackColor = System.Drawing.Color.Green;
            this.btnTransfer.Enabled = false;
            this.btnTransfer.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(573, 373);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(352, 59);
            this.btnTransfer.Style = MetroFramework.MetroColorStyle.Red;
            this.btnTransfer.TabIndex = 25;
            this.btnTransfer.Text = "SETTLE";
            this.btnTransfer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTransfer.UseCustomBackColor = true;
            this.btnTransfer.UseSelectable = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // dtpPdate
            // 
            this.dtpPdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPdate.Location = new System.Drawing.Point(718, 338);
            this.dtpPdate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpPdate.Name = "dtpPdate";
            this.dtpPdate.Size = new System.Drawing.Size(207, 29);
            this.dtpPdate.TabIndex = 26;
            // 
            // btnFetchData
            // 
            this.btnFetchData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFetchData.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnFetchData.Location = new System.Drawing.Point(573, 54);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(352, 59);
            this.btnFetchData.Style = MetroFramework.MetroColorStyle.Green;
            this.btnFetchData.TabIndex = 27;
            this.btnFetchData.Text = "FETCH DATA";
            this.btnFetchData.UseCustomBackColor = true;
            this.btnFetchData.UseSelectable = true;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.BackColor = System.Drawing.Color.Red;
            this.metroButton2.ForeColor = System.Drawing.Color.White;
            this.metroButton2.Location = new System.Drawing.Point(573, 433);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(352, 47);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 28;
            this.metroButton2.Text = "CLOSE";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // gridACC
            // 
            this.gridACC.AllowUserToAddRows = false;
            this.gridACC.AllowUserToDeleteRows = false;
            this.gridACC.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridACC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridACC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gridACC.AutoGenerateColumns = false;
            this.gridACC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridACC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridACC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridACC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridACC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridACC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridACC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_acc,
            this.accountnameDataGridViewTextBoxColumn});
            this.gridACC.DataSource = this.accountsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridACC.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridACC.EnableHeadersVisualStyles = false;
            this.gridACC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridACC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridACC.Location = new System.Drawing.Point(573, 165);
            this.gridACC.Name = "gridACC";
            this.gridACC.ReadOnly = true;
            this.gridACC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridACC.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridACC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridACC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridACC.Size = new System.Drawing.Size(352, 130);
            this.gridACC.TabIndex = 30;
            this.gridACC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridACC_CellClick);
            // 
            // id_acc
            // 
            this.id_acc.DataPropertyName = "id";
            this.id_acc.HeaderText = "id";
            this.id_acc.Name = "id_acc";
            this.id_acc.ReadOnly = true;
            this.id_acc.Width = 50;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(569, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "SELECT ACCOUNT";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(568, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "SETTLE AND RESET";
            // 
            // txtbAmt
            // 
            this.txtbAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtbAmt.CustomButton.Image = null;
            this.txtbAmt.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.txtbAmt.CustomButton.Name = "";
            this.txtbAmt.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtbAmt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbAmt.CustomButton.TabIndex = 1;
            this.txtbAmt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbAmt.CustomButton.UseSelectable = true;
            this.txtbAmt.CustomButton.Visible = false;
            this.txtbAmt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtbAmt.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtbAmt.Lines = new string[] {
        "0"};
            this.txtbAmt.Location = new System.Drawing.Point(718, 301);
            this.txtbAmt.MaxLength = 32767;
            this.txtbAmt.Name = "txtbAmt";
            this.txtbAmt.PasswordChar = '\0';
            this.txtbAmt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbAmt.SelectedText = "";
            this.txtbAmt.SelectionLength = 0;
            this.txtbAmt.SelectionStart = 0;
            this.txtbAmt.ShortcutsEnabled = true;
            this.txtbAmt.Size = new System.Drawing.Size(207, 31);
            this.txtbAmt.TabIndex = 32;
            this.txtbAmt.Text = "0";
            this.txtbAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbAmt.UseSelectable = true;
            this.txtbAmt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbAmt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(573, 304);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(110, 25);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Paid Amount";
            // 
            // accountnameDataGridViewTextBoxColumn
            // 
            this.accountnameDataGridViewTextBoxColumn.DataPropertyName = "Account_name";
            this.accountnameDataGridViewTextBoxColumn.HeaderText = "Account_name";
            this.accountnameDataGridViewTextBoxColumn.Name = "accountnameDataGridViewTextBoxColumn";
            this.accountnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.eSITERPDataSet;
            // 
            // eSITERPDataSet
            // 
            this.eSITERPDataSet.DataSetName = "ESITERPDataSet";
            this.eSITERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // FFDT_FFPURCHASEBindingSource
            // 
            this.FFDT_FFPURCHASEBindingSource.DataMember = "FFDT-FFPURCHASE";
            this.FFDT_FFPURCHASEBindingSource.DataSource = this.eSITERPDataSet;
            // 
            // fFDTFFPURCHASEBindingSource
            // 
            this.fFDTFFPURCHASEBindingSource.DataMember = "FFDT-FFPURCHASE";
            this.fFDTFFPURCHASEBindingSource.DataSource = this.eSITERPDataSet;
            // 
            // fFDT_FFPURCHASE_TA
            // 
            this.fFDT_FFPURCHASE_TA.ClearBeforeFill = true;
            // 
            // frmFastfoodsPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 503);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtbAmt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridACC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btnFetchData);
            this.Controls.Add(this.dtpPdate);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtbEndTicket);
            this.Controls.Add(this.txtST_T);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmFastfoodsPurchases";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "FASTFOODS PURCHASES";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmShopSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridACC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSITERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FFDT_FFPURCHASEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFDTFFPURCHASEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtST_T;
        private MetroFramework.Controls.MetroTextBox txtbEndTicket;
        private MetroFramework.Controls.MetroButton btnTransfer;
        private MetroFramework.Controls.MetroDateTime dtpPdate;
        private MetroFramework.Controls.MetroButton btnFetchData;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroGrid gridACC;
        private System.Windows.Forms.Label label1;
        private ESITERPDataSet eSITERPDataSet;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private ESITERPDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_acc;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtbAmt;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.BindingSource FFDT_FFPURCHASEBindingSource;
        private System.Windows.Forms.BindingSource fFDTFFPURCHASEBindingSource;
        private ESITERPDataSetTableAdapters.FFDT_FFPURCHASE_TA fFDT_FFPURCHASE_TA;
    }
}