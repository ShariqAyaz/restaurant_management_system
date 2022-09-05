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
using MetroFramework.Components;
using MetroFramework.Controls;
using System.Data.SqlClient;
using Numerator;

namespace APPDESK
{
    public partial class frmKOM : MetroForm
    {
        protected string cs = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=ESITERP;integrated security=True;Max Pool Size=50000";
        protected string cs_R = @"data source=ABSERVER\SQLEXPRESS;initial catalog=SambaPOS3_RES;integrated security=True;Max Pool Size=50000";
        protected string cs_FS = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=SambaPOS3;integrated security=True;Max Pool Size=50000";
        private int user_id, bid;
        int st_t, end_t;
        Numerator.Numerator num = new Numerator.Numerator();
        getOrderNumberKMS gt = new getOrderNumberKMS();
        transactions.transactions tr = new transactions.transactions();


        public frmKOM(int get_bid, int get_userid)
        {
            InitializeComponent();
            bid = get_bid;
            user_id = get_userid;
        }


        private void btn_Sync_Click(object sender, EventArgs e)
        {
            syncProd("R");
            syncProd("F");
            MessageBox.Show("SYNC COMPLETED");
        }

        private void syncProd(string s)
        {
            if (s == "R")
            {
                //  - SYNC RESTAURANT MENU
                SqlConnection con = new SqlConnection(cs_R);
                SqlCommand cmd = new SqlCommand("select id,tag,name from menuitems", con);
                SqlDataReader rdr = null;
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read() == true)
                {
                    SqlConnection conWrite = new SqlConnection(cs);
                    SqlCommand cmdWrite = new SqlCommand("INSERT INTO KITCHENMENU(fg_id,tag,name,urduname,b_entity_id) VALUES(" + (int)rdr["id"] + ",'" + (string)rdr["tag"] + "',N'" + (string)rdr["name"] + "',N'" + (string)rdr["name"] + "',2)", conWrite);
                    conWrite.Open();
                    cmdWrite.ExecuteNonQuery();
                    conWrite.Close();
                }
                con.Close();
            }
            else if (s == "F")
            {
                //  - SYNC RESTAURANT MENU
                SqlConnection con = new SqlConnection(cs_FS);
                SqlCommand cmd = new SqlCommand("select id,tag,name from menuitems", con);
                SqlDataReader rdr = null;
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read() == true)
                {
                    SqlConnection conWrite = new SqlConnection(cs);
                    SqlCommand cmdWrite = new SqlCommand("INSERT INTO KITCHENMENU(fg_id,tag,name,urduname,b_entity_id) VALUES(" + (int)rdr["id"] + ",'" + (string)rdr["tag"] + "',N'" + (string)rdr["name"] + "',N'" + (string)rdr["name"] + "',1)", conWrite);
                    conWrite.Open();
                    cmdWrite.ExecuteNonQuery();
                    conWrite.Close();
                }
                con.Close();
            }
        }

        private void btnNewKitchen_Click(object sender, EventArgs e)
        {
            frmNewKitchen frm = new frmNewKitchen(user_id);
            frm.ShowDialog();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SELECT id,[Kitchen Name] AS KNAME FROM KMS_Kitchen", con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                btnK((int)rdr["id"], (string)rdr["KNAME"]);
            }
            con.Close();
        }

        private void btnK(int i, string s)
        {
            Button btnK = new Button();
            btnK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            btnK.BackColor = System.Drawing.Color.Yellow;
            btnK.Location = new System.Drawing.Point(810, 2);
            btnK.Name = "btnK" + i;
            btnK.Tag = i;
            btnK.Size = new System.Drawing.Size(100, 90);
            btnK.Text = s;
            btnK.UseVisualStyleBackColor = false;
            btnK.Click += new EventHandler(btnK_Click);
            flpKitchen.Controls.Add(btnK);
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int kid = Convert.ToInt16(btn.Tag);
            frmKitchenManagement frm = new frmKitchenManagement(kid, user_id, rbUrdu.Checked == true ? "UR" : "EN",bid);
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnFetch.PerformClick();
        }

        private void frmKOM_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void frmKOM_Load(object sender, EventArgs e)
        {

        }

        private void fetchR()
        {
            st_t = gt.getStartOrderNumber(bid);
            end_t = gt.getEndOrderNumber(bid);
            txtbR_LAST.Text = Convert.ToString(st_t);
            txtbR_CUR.Text = Convert.ToString(end_t);
            if (st_t > end_t & st_t == 0)
            {
                st_t = 0;
                txtbR_LAST.Text = st_t.ToString();
            }
            else if (st_t == end_t | st_t+1 == end_t)
            {
                //MessageBox.Show("There is no new Tickets...!");
                return;
            }

            SqlConnection con = new SqlConnection(cs_R);
            SqlCommand cmd = new SqlCommand(@"SELECT CAST(TT.TicketNumber as int) TicketNumber,CAST(OO.OrderNumber as int) OrderNumber,TT.TicketTags as [TicketTags],CAST(OO.CreatedDateTime as nvarchar) CreatedDateTime,CAST(MI.Id AS int) MID,OO.MenuItemName, CAST(OO.Quantity as decimal) AS QTY,CreatingUserName username ,CAST((select top 1 TicketEntities.EntityName from TicketEntities WHERE TicketEntities.Ticket_Id = TT.id) as nvarchar) ENAME FROM Tickets AS TT INNER JOIN Orders AS OO ON TT.Id = OO.TicketId INNER JOIN MenuItems AS MI ON MI.Id = OO.MenuItemId INNER JOIN MenuItemPortions MPO ON Mi.Id = MPO.MenuItemId INNER JOIN MenuItemPrices MPRI ON MPO.Id = MPRI.MenuItemPortionId  WHERE(OO.OrderStates NOT LIKE '%Void%') AND OO.OrderNumber BETWEEN " + st_t + " AND " + end_t + " AND ORDER BY OO.OrderNumber", con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                try
                {
                    string ttag = rdr["TicketTags"] != System.DBNull.Value ? (string)rdr["TicketTags"] : string.Empty;
                    string ename = rdr["ENAME"] != System.DBNull.Value ? (string)rdr["ENAME"] : string.Empty;
                    string[] arr = (ttag).Split('"');
                    int L = arr.Length;
                    ttag = arr[L - 2];
                    SqlConnection conWrite = new SqlConnection(cs);
                    SqlCommand cmdWrite = new SqlCommand("INSERT INTO[dbo].[ORDER_FETCH] ([otime],[order_no],[ticket_number],[TABLE],[ticket_tag],[fg_id],[fg_name],[qty],[b_entity_id],[status])VALUES(CAST('" + (string)rdr["CreatedDateTime"] + "' as datetime)," + (int)rdr["OrderNumber"] + "," + (int)rdr["TicketNumber"] + ",N'" + ename + "',N'" + ttag + "','" + (int)rdr["MID"] + "',N'" + (string)rdr["MenuItemName"] + "', " + (decimal)rdr["QTY"] + ",2,N'N')", conWrite);
                    conWrite.Open();
                    cmdWrite.ExecuteNonQuery();
                    conWrite.Close();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            }
            con.Close();
            //MessageBox.Show("ORDER SYNC DONE");
            try
            {
                SqlConnection conUPD = new SqlConnection(cs);
                SqlCommand cmdUPD = new SqlCommand("update numerator set RES_KMS_RESTAURANT_LASTORDER=" + (end_t), conUPD);
                conUPD.Open();
                cmdUPD.ExecuteNonQuery();
                conUPD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //conUPD.Close();
            }
        }
        private void fetchF()
        {
            st_t = gt.getStartOrderNumber(1);
            end_t = gt.getEndOrderNumber(1);
            txtbR_LAST.Text = Convert.ToString(st_t);
            txtbR_CUR.Text = Convert.ToString(end_t);
            if (st_t > end_t & st_t == 0)
            {
                st_t = 0;
                txtbR_LAST.Text = st_t.ToString();
            }
            else if (st_t+1 == end_t)
            {
                //MessageBox.Show("There is no new Tickets...!");
                return;
            }

            SqlConnection con = new SqlConnection(cs_FS);
            SqlCommand cmd = new SqlCommand(@"SELECT CAST(TT.TicketNumber as int) TicketNumber,CAST(OO.OrderNumber as int) OrderNumber,TT.TicketTags as [TicketTags],CAST(OO.CreatedDateTime as nvarchar) CreatedDateTime,CAST(MI.Id AS int) MID,OO.MenuItemName, CAST(OO.Quantity as decimal) AS QTY,CreatingUserName username ,CAST((select top 1 TicketEntities.EntityName from TicketEntities WHERE TicketEntities.Ticket_Id = TT.id) as nvarchar) ENAME FROM Tickets AS TT INNER JOIN Orders AS OO ON TT.Id = OO.TicketId INNER JOIN MenuItems AS MI ON MI.Id = OO.MenuItemId INNER JOIN MenuItemPortions MPO ON Mi.Id = MPO.MenuItemId INNER JOIN MenuItemPrices MPRI ON MPO.Id = MPRI.MenuItemPortionId  WHERE(OO.OrderStates NOT LIKE '%Void%') AND OO.OrderNumber BETWEEN " + st_t + " AND " + end_t + " ORDER BY OO.OrderNumber", con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                try
                {
                    string ttag = rdr["TicketTags"] != System.DBNull.Value ? (string)rdr["TicketTags"] : string.Empty;
                    string ename = rdr["ENAME"] != System.DBNull.Value ? (string)rdr["ENAME"] : string.Empty;
                    string[] arr = (ttag).Split('"');
                    int L = arr.Length;
                    ttag = arr[L - 2];
                    SqlConnection conWrite = new SqlConnection(cs);
                    SqlCommand cmdWrite = new SqlCommand("INSERT INTO[dbo].[ORDER_FETCH] ([otime],[order_no],[ticket_number],[TABLE],[ticket_tag],[fg_id],[fg_name],[qty],[b_entity_id],[status])VALUES(CAST('" + (string)rdr["CreatedDateTime"] + "' as datetime)," + (int)rdr["OrderNumber"] + "," + (int)rdr["TicketNumber"] + ",N'" + ename + "',N'" + ttag + "','" + (int)rdr["MID"] + "',N'" + (string)rdr["MenuItemName"] + "', " + (decimal)rdr["QTY"] + ",1,N'N')", conWrite);
                    conWrite.Open();
                    cmdWrite.ExecuteNonQuery();
                    conWrite.Close();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            }
            con.Close();
            //MessageBox.Show("ORDER SYNC DONE");
            try
            {
                SqlConnection conUPD = new SqlConnection(cs);
                SqlCommand cmdUPD = new SqlCommand("update numerator set FF_KMS_RESTAURANT_LASTORDER=" + (end_t), conUPD);
                conUPD.Open();
                cmdUPD.ExecuteNonQuery();
                conUPD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //conUPD.Close();
            }
        }
        
        private void btnFetch_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 9000;
            fetchF();fetchR();
        }
    }
}
