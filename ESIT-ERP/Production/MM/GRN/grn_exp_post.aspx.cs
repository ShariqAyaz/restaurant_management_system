using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using AppLogic;
using transactions;


namespace ESIT_ERP.Production.MM.GRN
{
    public partial class grn_exp_post : System.Web.UI.Page
    {
        protected string cs = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
        public GRN_ITEMS[] GI = null;
        transactions.transactions GET_GI = new transactions.transactions();
        public bool loaditm = false;
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        public int cur_actionid;
        static int appid = 12;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);

            if (Convert.ToString(Session["grnpstage"]) == "0")
            {
                Response.Redirect("/Production/MM/GRN/grn_main.aspx");
            }
            else if (Convert.ToString(Session["grnpstage"]) == "1")
            {
                Response.Redirect("/Production/MM/GRN/grn_det.aspx?grnno=" + Session["grnno"]);
            }
            else if (Convert.ToString(Session["grnpstage"]) == "2")
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("select * from grn_expense_det where grn_no='" + Convert.ToString(Session["grnno"]) + "'", con);
                SqlDataReader rdr = null;
                con.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    txtbDesc.Text = (string)rdr["expense_desc"];
                    txtbExpAmt.Text = Convert.ToString((decimal)rdr["exp_amt"]);
                }
                con.Close();
            }
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            if (txtbExpAmt.Text!="")
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = null;
                try
                {
                    cmd = new SqlCommand("INSERT INTO grn_expense_det(grn_no,expense_desc,exp_amt) values('" + Convert.ToString(Session["grnno"]) + "','" + txtbDesc.Text + "'," + Convert.ToDecimal(txtbExpAmt.Text) + ")", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {

                }
            }
            if (GET_GI.isAlreadyPosted(Convert.ToString(Session["grnno"])) == false)
            {
                GET_GI.postGRN(Convert.ToString(Session["grnno"]), Convert.ToInt32(Session["userlogin"]), Convert.ToInt32(Session["bid"]));

                Session.Remove("grnno");
                Session.Remove("grnpstage");
                Session.Remove("GRNisPosted");
                Response.Redirect("/Production/MM/GRN/grn_main.aspx");
            }
        }

    }
}