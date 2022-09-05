using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Numerator;
using AppLogic;
using transactions;
using System.Data.SqlClient;
namespace ESIT_ERP.Production.BOM
{
    public partial class ViewBOM : System.Web.UI.Page
    {
        protected string cs = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
        AppLogic.LoadGRN load_grn = new AppLogic.LoadGRN();
        AppLogic.LoadGRN ins_grn = new AppLogic.LoadGRN();
        Numerator.Numerator num = new Numerator.Numerator();
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        postproceed.postproceed pp = new postproceed.postproceed();
        transactions.transactions vtran = new transactions.transactions();
        public int cur_actionid;
        static int appid = 1013;
        public string retmessage = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);

            if (Request.QueryString["bomid"] != null)
            {

            }

        }

        public string ppo(int rid)
        {
            string pname=null;
            string pid=null;
            string getcs = getcsstring(Session["bid"].ToString());
            ///
            SqlConnection gcon = new SqlConnection(cs);
            SqlCommand gcmd = new SqlCommand("select * from BOM where id="+rid+" AND b_entity_id='"+ Session["bid"].ToString() + "'", gcon);
            SqlDataReader grdr = null;
            gcon.Open();
            grdr = gcmd.ExecuteReader();
            if (grdr.Read()==true)
            {
                pid = Convert.ToString((int)grdr["fg_id"]);
            }
            gcon.Close();
            ///
            SqlConnection con = new SqlConnection(getcs);
            SqlCommand cmd = new SqlCommand("SELECT Name FROM Menuitems where id=" + pid + "", con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                pname = (string)rdr["Name"];
            }
            con.Close();
            return pname;
        }

        public string getcsstring(string bid)
        {
            string str = "";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select restaurant_sale_db from b_entity where id='" + bid + "'", con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                str=(string)rdr["restaurant_sale_db"];
            }
            con.Close();
            return @"data source=LENOVO\SQLEXPRESS;initial catalog=" + str + "; integrated security=True";
        }

        protected void btnAdd_Click(object sender,EventArgs e)
        {
            if (txtbiqty.Text!="")
            {
                if (Convert.ToString(Request.QueryString["bomid"]) != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(cs);
                        SqlCommand cmd = new SqlCommand("INSERT INTO BOM_det_raw(bom_id,iid,iqty) values('" + Convert.ToString(Request.QueryString["bomid"]) + "'," + DropDownList1.SelectedValue + "," + Convert.ToDecimal(txtbiqty.Text) + ")", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert(" + ex + ")</script>");
                    }
                    Response.Redirect("/Production/BOM/ViewBOM.aspx?bomid=" + Request.QueryString["bomid"]);
                }
            }
        }

        protected void btnFinish_Click(object sender,EventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }

        public bool itHasWip(int a)
        {
            bool b = false;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select hasWip from BOM where id=" + a, con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                b = (bool)rdr["hasWip"];
            }
            con.Close();
            return b;
        }

    }
}