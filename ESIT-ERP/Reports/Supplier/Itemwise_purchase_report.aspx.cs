using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ESIT_ERP.Reports.Supplier
{
    public partial class Itemwise_purchase_report : System.Web.UI.Page
    {
        protected string cs = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
        //public GRN_ITEMS[] GI = null;
        transactions.transactions GET_GI = new transactions.transactions();
        public bool loaditm = false;
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        public int cur_actionid;
        static int appid = 18;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);

            if (Request.QueryString["iid"] == null)
                Response.Redirect("/Reports/Supplier/Itemwise_purchase_report.aspx?iid=3");// + DropDownList1.SelectedValue.ToString());

        }

        public decimal totalqty(string a_BID,string b_IID)
        {
            decimal val = 0;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select CAST(SUM(GRD.iqty) as decimal(18,0)) TQTY,CAST(SUM(GRD.irate*GRD.iqty) as decimal(18,0)) TAMT from grn_note GR INNER JOIN grn_items_det GRD ON GRD.grn_no=GR.grn_no INNER JOIN vendor_master VI ON VI.id=GR.vendor_id WHERE GR.isPosted=1 AND b_entity_id="+ a_BID + " AND iid="+b_IID, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.Read()==true)
            {
                val = (decimal)rdr["TQTY"];
            }
            con.Close();
            return val;
        }

        public decimal totalamt(string a_BID, string b_IID)
        {
            decimal val = 0;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select CAST(SUM(GRD.iqty) as decimal(18,0)) TQTY,CAST(SUM(GRD.irate*GRD.iqty) as decimal(18,0)) TAMT from grn_note GR INNER JOIN grn_items_det GRD ON GRD.grn_no=GR.grn_no INNER JOIN vendor_master VI ON VI.id=GR.vendor_id WHERE GR.isPosted=1 AND b_entity_id=" + a_BID + " AND iid=" + b_IID, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                val = (decimal)rdr["TAMT"];
            }
            con.Close();
            return val;
        } // getiname

        public string getiname(int b_IID)
        {
            string val = "";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select iname from item_mast where id=" + b_IID, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                val = (string)rdr["iname"];
            }
            con.Close();
            return val;
        } // getiname

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ///Request.QueryString["iid"] = DropDownList1.SelectedValue.ToString();
            Response.Redirect("/Reports/Supplier/Itemwise_purchase_report.aspx?iid=" + DropDownList1.SelectedValue.ToString());
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/");
        }
    }
}