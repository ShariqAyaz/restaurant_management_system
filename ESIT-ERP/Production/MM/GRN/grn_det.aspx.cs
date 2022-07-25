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
    public partial class grn_det : System.Web.UI.Page
    {
        protected string cs = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
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
            else if (Convert.ToString(Session["grnpstage"]) == "2")
            {
                Response.Redirect("/Production/MM/GRN/grn_exp_post.aspx?grnno=" + Session["grnno"]);
            }
            else if (Convert.ToString(Session["grnpstage"]) == "1")
            {
                //DropDownList1.Items.Insert(1,new ListItem("- Choose Item -"));
                //DropDownList1.SelectedIndex=(0);
                if (Convert.ToString(Request.QueryString["grnno"]) == Convert.ToString(Session["grnno"]))
                {
                    if (Request.QueryString["lid"] != null)
                    {
                        deletelineitem(Convert.ToInt32(Request.QueryString["lid"]));
                    }
                    if (itemsExist(Convert.ToString(Session["grnno"])) == true)
                    {
                        GI = GET_GI.returnItems(Convert.ToString(Session["grnno"]));
                        loaditm = true;
                    }
                    else
                    {
                        loaditm = false;
                    }
                }
                else
                {

                }
            }
        }

        public void deletelineitem(int a)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            cmd = new SqlCommand("delete from grn_items_det where id=" + a, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private bool retBool = false;
        static int i = 0;
        protected bool itemsExist(string get_grnno)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            cmd = new SqlCommand("select grn_no from grn_items_det where grn_no='" + get_grnno + "'", con);
            con.Open();
            i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i > 0)
                retBool = true;
            else retBool = false;
            con.Close();
            return retBool;
        }
        
        protected void btnNext_Click(object sender, EventArgs e)
        {
            Session["grnpstage"] = "2";
            Response.Redirect("/Production/MM/GRN/grn_exp_post.aspx?grnno=" + Session["grnno"]);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtbQty.Text != "" & txtbRate.Text != "" & txtBarcode.Text != "")
            {
                if (Convert.ToString(Session["grnno"]) != Convert.ToString(Request.QueryString["grnno"]))
                {
                    Response.Write("<script>alert('Session Expire pls reopen GRN NO.');</script>");
                    Response.Redirect("/Production/MM/GRN/grn_main.aspx");
                }
                // insert SHITS
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = null;
                cmd = new SqlCommand("insert into grn_items_det(grn_no,iid,irate,iqty) values('" + Convert.ToString(Session["grnno"]) + "',(select id from item_mast where ibarcode='" + txtBarcode.Text + "')," + Convert.ToDecimal(txtbRate.Text) + "," + Convert.ToDecimal(txtbQty.Text) + ")", con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {

                    Response.Write("<script>alert(" + ex + ")</script>");
                }
                Response.Redirect("/Production/MM/GRN/grn_det.aspx?grnno=" + Request.QueryString["grnno"]);
            }
            else
            {
                Response.Write("<script>alert('Please select Item details / Qty / Rate / etc');</script>");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBarcode.Text = DropDownList1.SelectedValue;
            btnAdd.Enabled = true;
        }
    }
}