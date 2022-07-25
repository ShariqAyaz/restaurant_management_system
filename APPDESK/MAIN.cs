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

namespace APPDESK
{
    public partial class MAIN : MetroForm
    {
        int bid, userid;
        public MAIN(int get_bid,int get_userid)
        {
            InitializeComponent();
            bid = get_bid;
            userid = get_userid;
        }

        private void btn_Pay_Supplier_Click(object sender, EventArgs e)
        {
            frmPayVendor frm = new frmPayVendor(bid,userid);
            frm.ShowDialog();
        }

        private void metroGrid1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int curRow = -1;
                //MessageBox.Show(importgrid.CurrentRow.Index.ToString());
                if (metroGrid1.CurrentRow.Index != curRow)
                {
                    curRow = metroGrid1.CurrentRow.Index;

                    ////// (string)postedGrid["workerDataGridViewTextBoxColumn", curRow].Value == ""
                    ////// gridPGWorkertxtb gridPGLoadertxtb gridPGStripMakertxtb gridPGDNCtxtb gridPGrfdotxtb gridPGenotxtb
                    //// cboxGroup.Text = (string)metroGrid1["gvtxtbgroup", curRow].Value;
                    //// cboxWo.Text = (string)metroGrid1["gvtxtbworker", curRow].Value;
                    //// cboxShift.Text = (string)metroGrid1["gvtxtbshift", curRow].Value;
                    //// cboxLoader1.Text = (string)metroGrid1["gvtxtbloader", curRow].Value;
                    //// updkey = ((Int32)metroGrid1["gvtxtbeno", curRow].Value).ToString();
                    //// DTP.Value = (DateTime)metroGrid1["gvtxtbdate", curRow].Value;
                    //// btnSaveNext.Text = "Update";
                    //// btnDel.Text = "Delete " + ((Int32)metroGrid1["gvtxtbeno", curRow].Value).ToString() + " ?";
                    //// btnSaveNext.Enabled = true;
                    //// btnClose.Enabled = false;
                    //// btnDel.Enabled = true;
                    //// btnDel.Visible = true;
                    //// isEdit = true;
                    runApp((Int32)metroGrid1["gdtxtappid", curRow].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void runApp(int a)
        {
            if (a == 13)
            {
                frmPayVendor frm = new frmPayVendor(bid,userid);
                frm.ShowDialog();
            }
            else if (a == 1026)
            {
                frmShopSale frm = new frmShopSale(bid, userid);
                frm.ShowDialog();
            }
            else if (a == 1027)
            {
                frmFastSettle frm = new frmFastSettle(bid, userid);
                frm.ShowDialog();
            }
            else if (a == 1028)
            {
                frmRestaurantPurchases frm = new frmRestaurantPurchases(bid, userid);
                frm.ShowDialog();
            }
            else if (a == 1029)
            {
                frmFastfoodsPurchases frm = new frmFastfoodsPurchases(bid, userid);
                frm.ShowDialog();
            }
            else if (a == 1030)
            {
                frmItemsSold frm = new frmItemsSold(bid, userid);
                frm.ShowDialog();
            }
            else if (a == 1032)
            {
                frmKOM frm = new frmKOM(bid,userid);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is no application installed or implemented currently. Please contact Mr.Shahzad");
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                int curRow = -1;
                //MessageBox.Show(importgrid.CurrentRow.Index.ToString());
                if (metroGrid1.CurrentRow.Index != curRow)
                {
                    curRow = metroGrid1.CurrentRow.Index;
                    runApp((Int32)metroGrid1["gdtxtappid", curRow].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select Your Application First");
            }
        }
 
        private void MAIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();this.Hide();
        }
 
        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
        private void MAIN_Load(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.Fill(this.eSITERPDataSet.DataTable1, userid, bid);
        }
    }
}