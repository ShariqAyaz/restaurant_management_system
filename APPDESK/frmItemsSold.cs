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
    public partial class frmItemsSold : MetroForm
    {
        int bid, userid;
        int appid = 1030;
        protected string cs = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=ESITERP;integrated security=True;Max Pool Size=50000";
        protected string cs_R = @"data source=ABSERVER\SQLEXPRESS;initial catalog=SambaPOS3_RES;integrated security=True;Max Pool Size=50000";
        protected string cs_FS = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=SambaPOS3;integrated security=True;Max Pool Size=50000";
        private void frmItemsSold_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ESITERPDataSet.FF_ITEMSOLD_DT' table. You can move, or remove it, as needed.
            //this.FF_ITEMSOLD_TA.Fill(this.ESITERPDataSet.FF_ITEMSOLD_DT);
            // TODO: This line of code loads data into the 'ESITERPDataSet.RES_ITEMSOLD_DT' table. You can move, or remove it, as needed.
            //this.RES_ITEMSOLD_TA.Fill(this.ESITERPDataSet.RES_ITEMSOLD_DT);
            this.rp_res.RefreshReport();
        }

        public frmItemsSold(int get_bid, int get_userid)
        {
            InitializeComponent();
            bid = get_bid;
            userid = get_userid;
            loadProd(bid);
            loadWP(bid);
        }

        private void loadProd(int i)
        {
            if (i == 1)
            {
                SqlConnection con = new SqlConnection(cs_FS);
                SqlCommand cmd = new SqlCommand("select Name from MenuItems order by GroupCode", con);
                SqlDataReader rdr = null;
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read() == true)
                {
                    cboxProd.Items.Add((string)rdr["Name"]);
                }
                con.Close();
            }
            else if (i == 2)
            {
                SqlConnection con = new SqlConnection(cs_R);
                SqlCommand cmd = new SqlCommand("select Name from MenuItems order by GroupCode", con);
                SqlDataReader rdr = null;
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read() == true)
                {
                    cboxProd.Items.Add((string)rdr["Name"]);
                }
                con.Close();
            }
            else MessageBox.Show("FATAL ERROR: Please discuss with Mr. Shahzad or Mr. Shariq");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cboxProd.Text !="")
            {
                if (rbW.Checked==true)
                {
                    if (cboxWP.Text !="")
                    {
                        string[] arr = cboxWP.Text.Split('|');
                        var dt1 = arr[0];
                        var dt2 = arr[1];
                        if (bid==1)
                        {
                            this.rp_ff.Visible = true;
                            this.rp_res.Visible = false;
                            this.FF_ITEMSOLD_TA.Fill(this.ESITERPDataSet._FF_ITEMSOLD_DT,Convert.ToDateTime(dt1), Convert.ToDateTime(dt2), cboxProd.Text);
                            this.rp_ff.RefreshReport();
                        } else if (bid == 2)
                        {
                            this.rp_ff.Visible = false;
                            this.rp_res.Visible = true;
                            this.RES_ITEMSOLD_TA.Fill(this.ESITERPDataSet._RES_ITEMSOLD_DT, Convert.ToDateTime(dt1), Convert.ToDateTime(dt2), cboxProd.Text);
                            this.rp_res.RefreshReport();
                        }
                    }
                }
                else if (rbD.Checked == true)
                {
                    if (bid == 1)
                    {
                        try
                        {
                            this.rp_ff.Visible = true;
                            this.rp_res.Visible = false;
                            this.FF_ITEMSOLD_TA.Fill(this.ESITERPDataSet._FF_ITEMSOLD_DT, Convert.ToDateTime(dtp1.Value), Convert.ToDateTime(dtp1.Value), cboxProd.Text);
                            this.rp_ff.RefreshReport();
                        }
                        catch (Exception)
                        {
                            this.rp_ff.Visible = true;
                            this.rp_res.Visible = false;
                            this.FF_ITEMSOLD_TA.Fill(this.ESITERPDataSet._FF_ITEMSOLD_DT, Convert.ToDateTime(dtp1.Value), Convert.ToDateTime(dtp1.Value), cboxProd.Text);
                            this.rp_ff.RefreshReport();
                        }
                    }
                    else if (bid == 2)
                    {
                        this.rp_ff.Visible = false;
                        this.rp_res.Visible = true;
                        this.RES_ITEMSOLD_TA.Fill(this.ESITERPDataSet._RES_ITEMSOLD_DT, Convert.ToDateTime(dtp1.Value), Convert.ToDateTime(dtp1.Value), cboxProd.Text);
                        this.rp_res.RefreshReport();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadWP(int i)
        {
            if (i == 1)
            {
                SqlConnection con = new SqlConnection(cs_FS);
                SqlCommand cmd = new SqlCommand("select StartDate,EndDate from WorkPeriods order by id desc", con);
                SqlDataReader rdr = null;
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read() == true)
                {
                    cboxWP.Items.Add((DateTime)rdr["StartDate"]+"|"+ (DateTime)rdr["EndDate"]);
                }
                con.Close();
            }
            else if (i == 2)
            {
                SqlConnection con = new SqlConnection(cs_R);
                SqlCommand cmd = new SqlCommand("select StartDate,EndDate from WorkPeriods order by id desc", con);
                SqlDataReader rdr = null;
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read() == true)
                {
                    cboxWP.Items.Add((DateTime)rdr["StartDate"] + "|" + (DateTime)rdr["EndDate"]);
                }
                con.Close();
            }
            else MessageBox.Show("FATAL ERROR: Please discuss with Mr. Shahzad or Mr. Shariq");
        }

    }
}
