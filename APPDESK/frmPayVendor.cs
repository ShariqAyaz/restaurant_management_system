using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Animation;
using MetroFramework.Drawing;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using MetroFramework.Fonts;
using AppLogic;
using rdgrant;

namespace APPDESK
{
    public partial class frmPayVendor : MetroForm
    {
        transactions.transactions vtran = new transactions.transactions();
        AppLogic.Vendor_payment vp = new AppLogic.Vendor_payment();
        protected string cs = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
        Numerator.Numerator num = new Numerator.Numerator();
        int bid, userid;
        public frmPayVendor(int get_bid, int get_userid)
        {
            InitializeComponent();
            bid = get_bid;
            userid = get_userid;
        }

        private void frmPayVendor_Load(object sender, EventArgs e)
        {
            this.accountsTableAdapter.Fill(this.eSITERPDataSet.Accounts);
            this.vendor_masterTableAdapter.Fill(this.eSITERPDataSet.vendor_master);
            loadtran(1);
        }

        protected void loadtran(int a)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SELECT VPD.vpno FROM vendor_payment_doc AS VPD INNER JOIN vendor_transactions AS VT ON VT.ref_doc_no = VPD.vpno WHERE(VT.ttype = 'VENPAYMENT') AND(VT.b_entity_id = "+a+") AND(VPD.isPosted = 1)", con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read()==true)
            {
                cboxTNO.Items.Add(rdr["vpno"]);
            }
            con.Close();
        }
        
        private void txtbVSearch_TextChanged(object sender, EventArgs e)
        {
            this.vendor_masterTableAdapter.FillBySearch(this.eSITERPDataSet.vendor_master,"%"+txtbVSearch.Text+"%");
        }

        private void btnPrintOnly_Click(object sender, EventArgs e)
        {
            this.vendor_Payslip_DTTableAdapter.Fill(this.vendor_DS.vendor_Payslip_DT,Convert.ToInt32(cboxTNO.Text));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_RenderingComplete(object sender, Microsoft.Reporting.WinForms.RenderingCompleteEventArgs e)
        {
            reportViewer1.PrintDialog();
        }
        
        int get_sup_id = 0;
        int get_acc_id=0;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (NUPDAmt.Value < 1)
            {
                MessageBox.Show("Amount Pls"); return;
            }
            if (get_sup_id == 0) { MessageBox.Show("Select Supplier"); return; }
            if (get_acc_id == 0) { MessageBox.Show("Select Account"); return; }

            int vno = num.vpno();
            vp.vpno = vno;
            vp.vendor_id = get_sup_id;
            vp.uid = userid;
            vp.b_entity_id = bid;
            vp.vDate = dtp.Value;
            vp.remarks = txtbRemarks.Text;
            vp.dramt = Convert.ToDecimal(NUPDAmt.Value);
            vp.isPosted = true;
            vp.cr_acc_id = get_acc_id;
            if (vtran.insertVPay(vp) == true)
            {
                vtran.postVendorPayment(Convert.ToString(vno), userid, bid);
                MessageBox.Show("Inserted...!");
                this.vendor_Payslip_DTTableAdapter.Fill(this.vendor_DS.vendor_Payslip_DT, vno);
                this.reportViewer1.RefreshReport();
            }
            cboxTNO.Text = vno.ToString();
            NUPDAmt.Value = 0;
            gridACC.ClearSelection();
            gridSupplier.ClearSelection();
            get_acc_id = 0;
            get_sup_id = 0;
        }

        private void gridSupplier_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int curRow = -1;
                //MessageBox.Show(importgrid.CurrentRow.Index.ToString());
                if (gridSupplier.CurrentRow.Index != curRow)
                {
                    curRow = gridSupplier.CurrentRow.Index;
                    get_sup_id = (int)gridSupplier["id", curRow].Value;
                    btnSavePrint.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridACC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int curRow = -1;
                //MessageBox.Show(importgrid.CurrentRow.Index.ToString());
                if (gridACC.CurrentRow.Index != curRow)
                {
                    curRow = gridACC.CurrentRow.Index;
                    get_acc_id = (int)gridACC["id_acc", curRow].Value;
                    btnSavePrint.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}