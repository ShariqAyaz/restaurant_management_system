using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Animation;
using MetroFramework.Drawing;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using MetroFramework.Fonts;
using Numerator;
using System.Data.SqlClient;
namespace APPDESK
{
    public partial class frmRestaurantPurchases : MetroForm
    {
        protected string cs = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=ESITERP;integrated security=True;Max Pool Size=50000";
        protected string cs_R = @"data source=ABSERVER2\SQLEXPRESS;initial catalog=OCCOTOPOS3_RES;integrated security=True;Max Pool Size=50000";
        protected string cs_FS = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=OCCOTOPOS3;integrated security=True;Max Pool Size=50000";
        //
        int bid, userid;
        Numerator.Numerator num = new Numerator.Numerator();
        getRestaurantTicket gt = new getRestaurantTicket();

        transactions.transactions tr = new transactions.transactions();
        int appid = 1028;
        public frmRestaurantPurchases(int get_bid, int get_userid)
        {
            InitializeComponent();
            bid = get_bid;
            userid = get_userid;
        }
        int st_t, end_t;
        private void btnFetchData_Click(object sender, EventArgs e)
        {
            if (bid == 1)
            {
                st_t = gt.getStartTicket(bid);
                end_t = gt.getEndTicket(bid);
                txtST_T.Text = Convert.ToString(st_t);
                txtbEndTicket.Text = Convert.ToString(end_t);
                if (st_t > end_t & st_t == 0)
                {
                    st_t = 0;
                    txtST_T.Text = st_t.ToString();
                }
                else if (st_t == end_t)
                {
                    MessageBox.Show("There is no new Tickets...!");
                    return;
                }

                try
                {
                    reportViewer1.Visible = true;
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    reportDataSource2.Name = "DataSet2";
                    reportDataSource2.Value = this.FFDT_RESPURCHASEBindingSource;
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "APPDESK.rp_Restaurant_Purchase.rdlc";
                    //
                    this.fFDT_RESPURCHASE_TA.ClearBeforeFill = true;
                    //this.eSITERPDataSet.Clear();
                    this.fFDT_RESPURCHASE_TA.Fill(this.eSITERPDataSet._FFDT_RESPURCHASE, Convert.ToInt32(txtST_T.Text));
                    reportViewer1.RefreshReport();
                    btnTransfer.Enabled = true;
                }
                catch (Exception)
                {
                    reportViewer1.Visible = true;
                    Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
                    reportDataSource2.Name = "DataSet2";
                    reportDataSource2.Value = this.FFDT_RESPURCHASEBindingSource;
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "APPDESK.rp_Restaurant_Purchase.rdlc";
                    //
                    this.fFDT_RESPURCHASE_TA.ClearBeforeFill = true;
                    //this.eSITERPDataSet.Clear();
                    this.fFDT_RESPURCHASE_TA.Fill(this.eSITERPDataSet._FFDT_RESPURCHASE, Convert.ToInt32(txtST_T.Text));
                    reportViewer1.RefreshReport();
                    btnTransfer.Enabled = true;
                }
            }
            else if (bid == 2)
            {
                MessageBox.Show("There is no applicable operation for restaurant user. if you are seeing this window. please discuss Mr. Shahzad");
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (get_acc_id == 0) { MessageBox.Show("Select Account"); return; }
            if (txtbAmt.Text == "" | txtbAmt.Text == "0") { MessageBox.Show("Select Amount"); return; }
            int tnumber = num.restaurant_transfer_no();
            //
            if (bid == 1)
            {
                try
                {
                    SqlConnection conSeek = new SqlConnection(cs_FS);
                    SqlCommand cmdSeek = new SqlCommand("SELECT MI.GroupCode, MI.Id AS MID, OO.MenuItemName, SUM(OO.Quantity) AS QTY, OO.Price * SUM(OO.Quantity) AS LINE_AMT FROM Tickets AS TT INNER JOIN Orders AS OO ON TT.Id = OO.TicketId INNER JOIN MenuItems AS MI ON MI.Id = OO.MenuItemId INNER JOIN MenuItemPortions AS MPO ON MI.Id = MPO.MenuItemId INNER JOIN MenuItemPrices AS MPRI ON MPO.Id = MPRI.MenuItemPortionId WHERE(OO.OrderStates NOT LIKE '%Void%') AND(MI.Tag = 'Restaurant') AND(CAST(TT.TicketNumber AS int) >= " + st_t + ") GROUP BY MI.GroupCode, MI.Id, OO.MenuItemName, MI.GroupCode, OO.Price ORDER BY MI.GroupCode", conSeek);
                    SqlDataReader rdrSeek = null;
                    conSeek.Open();
                    rdrSeek = cmdSeek.ExecuteReader();
                    while (rdrSeek.Read() == true)
                    {
                        try
                        {
                            SqlConnection conIns = new SqlConnection(cs);
                            SqlCommand cmdIns = new SqlCommand("INSERT INTO[dbo].[RESTAURANT_PURCHASES] ([start_T],[end_T],[transfer_no],[prod_date],[GroupCode],[MID],[MenuItemName],[QTY],[LINE_AMT],[acc_id],[paid_amt],[b_entity_id],[uid])VALUES(" + st_t + "," + end_t + "," + tnumber + ",'" + dtpPdate.Value + "','" + (string)rdrSeek["GroupCode"] + "'," + (int)rdrSeek["MID"] + ",'" + (string)rdrSeek["MenuItemName"] + "'," + (decimal)rdrSeek["QTY"] + "," + (decimal)rdrSeek["LINE_AMT"] + "," + get_acc_id + "," + Convert.ToDecimal(txtbAmt.Text) + "," + bid + "," + userid + ")", conIns);
                            conIns.Open();
                            cmdIns.ExecuteNonQuery();
                            conIns.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    conSeek.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //
                //updateRecord
                try
                {
                    SqlConnection conUPD = new SqlConnection(cs);
                    SqlCommand cmdUPD = new SqlCommand("update numerator set RESTAURANT_PURCHASE=" + (end_t + 1), conUPD);
                    conUPD.Open();
                    cmdUPD.ExecuteNonQuery();
                    conUPD.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //conUPD.Close();
                }
                tr.restaurant_purchase_pay_account_transaction(tnumber, userid, bid, dtpPdate.Value, get_acc_id, Convert.ToDecimal(txtbAmt.Text));
                MessageBox.Show("inserted");
            }
            else if (bid == 2)
            {
                MessageBox.Show("This is dedicate report/Option for fastfood. Pls Discuss with Information Technology OR Mr. Shahzad");
            }
        }
        int get_acc_id;

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmShopSale_Load(object sender, EventArgs e)
        {
            this.accountsTableAdapter.ClearBeforeFill = true;
            this.accountsTableAdapter.Fill(this.eSITERPDataSet.Accounts);
            this.accountsTableAdapter.Fill(this.eSITERPDataSet.Accounts);
        }
    }
}