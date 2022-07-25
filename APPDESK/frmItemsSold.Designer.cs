namespace APPDESK
{
    partial class frmItemsSold
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rp_res = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboxProd = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rbW = new MetroFramework.Controls.MetroRadioButton();
            this.rbD = new MetroFramework.Controls.MetroRadioButton();
            this.cboxWP = new System.Windows.Forms.ComboBox();
            this.dtp1 = new MetroFramework.Controls.MetroDateTime();
            this.dtp2 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnView = new MetroFramework.Controls.MetroTile();
            this.btnPrint = new MetroFramework.Controls.MetroTile();
            this.btnClose = new MetroFramework.Controls.MetroTile();
            this.rp_ff = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FF_ITEMSOLD_DTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ESITERPDataSet = new APPDESK.ESITERPDataSet();
            this.RES_ITEMSOLD_DTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RES_ITEMSOLD_TA = new APPDESK.ESITERPDataSetTableAdapters.RES_ITEMSOLD_TA();
            this.FF_ITEMSOLD_TA = new APPDESK.ESITERPDataSetTableAdapters.FF_ITEMSOLD_TA();
            ((System.ComponentModel.ISupportInitialize)(this.FF_ITEMSOLD_DTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESITERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RES_ITEMSOLD_DTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rp_res
            // 
            this.rp_res.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rp_res.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.RES_ITEMSOLD_DTBindingSource;
            this.rp_res.LocalReport.DataSources.Add(reportDataSource7);
            this.rp_res.LocalReport.ReportEmbeddedResource = "APPDESK.RES_ITEMSOLD.rdlc";
            this.rp_res.Location = new System.Drawing.Point(23, 63);
            this.rp_res.Name = "rp_res";
            this.rp_res.Size = new System.Drawing.Size(538, 415);
            this.rp_res.TabIndex = 0;
            // 
            // cboxProd
            // 
            this.cboxProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProd.FormattingEnabled = true;
            this.cboxProd.Location = new System.Drawing.Point(717, 63);
            this.cboxProd.Name = "cboxProd";
            this.cboxProd.Size = new System.Drawing.Size(313, 29);
            this.cboxProd.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(581, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Product";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbW
            // 
            this.rbW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbW.AutoSize = true;
            this.rbW.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbW.Location = new System.Drawing.Point(581, 107);
            this.rbW.Name = "rbW";
            this.rbW.Size = new System.Drawing.Size(130, 50);
            this.rbW.TabIndex = 3;
            this.rbW.Text = "Work Period \r\nWise";
            this.rbW.UseSelectable = true;
            // 
            // rbD
            // 
            this.rbD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbD.AutoSize = true;
            this.rbD.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbD.Location = new System.Drawing.Point(581, 163);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(108, 25);
            this.rbD.TabIndex = 4;
            this.rbD.Text = "Date Wise";
            this.rbD.UseSelectable = true;
            // 
            // cboxWP
            // 
            this.cboxWP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxWP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxWP.FormattingEnabled = true;
            this.cboxWP.Location = new System.Drawing.Point(717, 107);
            this.cboxWP.Name = "cboxWP";
            this.cboxWP.Size = new System.Drawing.Size(313, 25);
            this.cboxWP.TabIndex = 5;
            // 
            // dtp1
            // 
            this.dtp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp1.Location = new System.Drawing.Point(717, 185);
            this.dtp1.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(202, 29);
            this.dtp1.TabIndex = 6;
            // 
            // dtp2
            // 
            this.dtp2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp2.Location = new System.Drawing.Point(717, 239);
            this.dtp2.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(202, 29);
            this.dtp2.TabIndex = 7;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(717, 163);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "From:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(717, 217);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(25, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "To:";
            // 
            // btnView
            // 
            this.btnView.ActiveControl = null;
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.Location = new System.Drawing.Point(581, 274);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(449, 65);
            this.btnView.Style = MetroFramework.MetroColorStyle.Green;
            this.btnView.TabIndex = 10;
            this.btnView.Text = "View";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnView.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnView.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnView.UseSelectable = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ActiveControl = null;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(581, 345);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(449, 67);
            this.btnPrint.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnPrint.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnPrint.UseSelectable = true;
            // 
            // btnClose
            // 
            this.btnClose.ActiveControl = null;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(581, 418);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(449, 60);
            this.btnClose.Style = MetroFramework.MetroColorStyle.Red;
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnClose.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rp_ff
            // 
            this.rp_ff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rp_ff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource8.Name = "DataSet1";
            reportDataSource8.Value = this.FF_ITEMSOLD_DTBindingSource;
            this.rp_ff.LocalReport.DataSources.Add(reportDataSource8);
            this.rp_ff.LocalReport.ReportEmbeddedResource = "APPDESK.FF_ITEMSOLD.rdlc";
            this.rp_ff.Location = new System.Drawing.Point(23, 63);
            this.rp_ff.Name = "rp_ff";
            this.rp_ff.Size = new System.Drawing.Size(538, 415);
            this.rp_ff.TabIndex = 13;
            // 
            // FF_ITEMSOLD_DTBindingSource
            // 
            this.FF_ITEMSOLD_DTBindingSource.DataMember = "FF_ITEMSOLD-DT";
            this.FF_ITEMSOLD_DTBindingSource.DataSource = this.ESITERPDataSet;
            // 
            // ESITERPDataSet
            // 
            this.ESITERPDataSet.DataSetName = "ESITERPDataSet";
            this.ESITERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RES_ITEMSOLD_DTBindingSource
            // 
            this.RES_ITEMSOLD_DTBindingSource.DataMember = "RES_ITEMSOLD-DT";
            this.RES_ITEMSOLD_DTBindingSource.DataSource = this.ESITERPDataSet;
            // 
            // RES_ITEMSOLD_TA
            // 
            this.RES_ITEMSOLD_TA.ClearBeforeFill = true;
            // 
            // FF_ITEMSOLD_TA
            // 
            this.FF_ITEMSOLD_TA.ClearBeforeFill = true;
            // 
            // frmItemsSold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1053, 501);
            this.Controls.Add(this.rp_ff);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.cboxWP);
            this.Controls.Add(this.rbD);
            this.Controls.Add(this.rbW);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cboxProd);
            this.Controls.Add(this.rp_res);
            this.Name = "frmItemsSold";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "ITEMS SALE REPORT";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmItemsSold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FF_ITEMSOLD_DTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESITERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RES_ITEMSOLD_DTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_res;
        private System.Windows.Forms.ComboBox cboxProd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton rbW;
        private MetroFramework.Controls.MetroRadioButton rbD;
        private System.Windows.Forms.ComboBox cboxWP;
        private MetroFramework.Controls.MetroDateTime dtp1;
        private MetroFramework.Controls.MetroDateTime dtp2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile btnView;
        private MetroFramework.Controls.MetroTile btnPrint;
        private MetroFramework.Controls.MetroTile btnClose;
        private Microsoft.Reporting.WinForms.ReportViewer rp_ff;
        private System.Windows.Forms.BindingSource RES_ITEMSOLD_DTBindingSource;
        private ESITERPDataSet ESITERPDataSet;
        private ESITERPDataSetTableAdapters.RES_ITEMSOLD_TA RES_ITEMSOLD_TA;
        private System.Windows.Forms.BindingSource FF_ITEMSOLD_DTBindingSource;
        private ESITERPDataSetTableAdapters.FF_ITEMSOLD_TA FF_ITEMSOLD_TA;
    }
}