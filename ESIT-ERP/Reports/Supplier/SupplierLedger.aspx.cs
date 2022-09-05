using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

namespace ESIT_ERP.Reports.Supplier
{
    public partial class SupplierLedger : System.Web.UI.Page
    {
        protected string cs = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
        //public GRN_ITEMS[] GI = null;
        transactions.transactions GET_GI = new transactions.transactions();
        public bool loaditm = false;
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        public int cur_actionid;
        static int appid = 19;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);

        }

        public string gsname(int a)
        {
            string val = "";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select vendorName from vendor_master where id="+a, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                val = (string)rdr["vendorName"];
            }
            con.Close();
            return val;
        }
        protected void DropDown_warehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("/Reports/Supplier/SupplierLedger.aspx?vid=" + Convert.ToString(DropDown_VLIST.SelectedValue));
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Reports/Supplier/SupplierLedger.aspx?vid=" + Convert.ToString(DropDown_VLIST.SelectedValue));
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/");
        }

        public decimal totalcr(string a_BID, string b_vID)
        {
            decimal val = 0;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SELECT sum(cr)+0 TAMT from vendor_transactions where ven_id=" + b_vID + " and b_entity_id=" + a_BID, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                val = rdr.IsDBNull(0) ? 0 : (decimal)rdr["TAMT"];
                // bool? result = dataReader.IsDbNull(dataReader["Bool_Flag"]) ? null : (bool)dataReader["Bool_Flag"]
                //val = 
            }
            con.Close();
            return val;
        }

        public string getvname(int b_IID)
        {
            string val = "";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select VendorName from vendor_master where id=" + b_IID, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                val = (string)rdr["VendorName"];
            }
            con.Close();
            return val;
        } // getiname

        public decimal totaldr(string a_BID, string b_vID)
        {
            decimal val = 0;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SELECT sum(dr) TAMT from vendor_transactions where ven_id=" + b_vID+" and b_entity_id="+a_BID, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                val = rdr.IsDBNull(0) ? 0 : (decimal)rdr["TAMT"];
            }
            con.Close();
            return val;
        }

    }
}