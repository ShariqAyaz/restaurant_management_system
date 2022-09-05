using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using AppLogic;
using transactions;

namespace ESIT_ERP.Production.MM.MTN
{
    public partial class Prod_issue_det : System.Web.UI.Page
    {
        protected string cs = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
        public GRN_ITEMS[] GI = null;
        transactions.transactions GET_GI = new transactions.transactions();
        public bool loaditm = false;
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        public int cur_actionid;
        static int appid = 16;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);

            if (Session["pinno"] == null)
            {
                Response.Redirect("/Production/MM/MTN/Prod_issue_note.aspx");
            }

            if (Convert.ToString(Request.QueryString["pinno"]) == Convert.ToString(Session["pinno"]))
            {
                //if (Request.QueryString["lid"] != null)
                //{
                //    deletelineitem(Convert.ToInt32(Request.QueryString["lid"]));
                //}
                //if (itemsExist(Convert.ToString(Session["pinno"])) == true)
                //{
                //    GI = GET_GI.returnItems(Convert.ToString(Session["grnno"]));
                //    loaditm = true;
                //}
                //else
                //{
                //    loaditm = false;
                //}
            }
            else
            {

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


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtbConsumeQty.Text != "" & txtbProduceQty.Text != "")
            {
                if (Convert.ToString(Session["pinno"]) != Convert.ToString(Request.QueryString["pinno"]))
                {
                    Response.Write("<script>alert('Session Expire pls reopen Production Issuance Note.');</script>");
                    Response.Redirect("/Production/MM/MTN/Prod_issue_note.aspx");
                }
                // insert SHITS
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = null;
                cmd = new SqlCommand("insert into semi_production_details(doc_id,sp_item,produce_qty,consume_qty,Issue_produce_qty) values(" + Convert.ToInt32(Session["pinno"]) + ","+Convert.ToInt32(DropDown_spitem.SelectedValue)+","+Convert.ToDecimal(txtbProduceQty.Text)+","+ Convert.ToDecimal(txtbConsumeQty.Text) + ",0)", con);
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
                Response.Redirect("/Production/MM/MTN/Prod_issue_note.aspx");
            }
            else
            {
                Response.Write("<script>alert('Please select Item details / Qty / Rate / etc');</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Remove("pinno");
            Session.Remove("pinnoisPosted");
            Response.Redirect("/Production/MM/MTN/Prod_issue_note.aspx");
        }
    }
}