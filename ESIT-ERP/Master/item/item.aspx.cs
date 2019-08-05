using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using postproceed;
using rdgrant;
using AppLogic;

namespace ESIT_ERP.Master.item
{
    public partial class item : System.Web.UI.Page
    {
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        postproceed.postproceed pp = new postproceed.postproceed();
        public int cur_actionid;
        static int appid = 8;
        public string retmessage = "";
        AppLogic.Item newItem = new AppLogic.Item();
        ModItem modifyitem = new ModItem();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);
            if (cur_actionid == 1) btnAdd2.Enabled = false;

            if (Request.QueryString["iid"] != null)
            {
                modifyitem = pp.getitem(Convert.ToInt32(Request.QueryString["iid"]));
                txtbitemname.Text = modifyitem.iname;
                txtbitemdesc.Text = modifyitem.idesc;
                txtbbarcode.Text = modifyitem.ibarcode;
                rblMainCat.SelectedValue = modifyitem.main_cat_id.ToString();
                rblSubCat.SelectedValue = modifyitem.sub_cat_id.ToString();
                rblPunit.SelectedValue = modifyitem.uom_purchase_id.ToString();
                rblCunit.SelectedValue = modifyitem.uom_consumption_id.ToString();
                rblAcc.SelectedValue = modifyitem.acc_id.ToString();
                txtbdivisibleuop.Text = modifyitem.divisible_uop.ToString();
                btnDel2.Enabled = true;
                btnUpdate2.Enabled = true;
                btnAdd2.Enabled = false;
            }
            #region NEW ITEM CREATING
            if (!string.IsNullOrEmpty(Request.Form["txtbitemname"]) & btnUpdate2.Enabled == false & btnDel2.Enabled == false)
            {
                if (cur_actionid == 1)
                {
                    Response.Write("<script>alert('You are authorized user for this action, Please coordinate IT Person!. Thank You!');</script>"); return;
                }
                if (Request.Form["rblMainCat"] != null & Request.Form["rblSubCat"] != null & Request.Form["rblPunit"] != null & Request.Form["rblCunit"] != null)
                {
                    newItem.iname = (Request.Form["txtbitemname"]);
                    newItem.idesc = (Request.Form["txtbitemdesc"]);
                    newItem.ibarcode = (Request.Form["txtbbarcode"]) == "" ? Request.Form["rblmainCat"] + Request.Form["rblSubCat"]+ Request.Form["txtbitemname"] : (Request.Form["txtbbarcode"]);
                    newItem.main_cat_id = Convert.ToInt32(Request.Form["rblmainCat"]);
                    newItem.sub_cat_id = Convert.ToInt32(Request.Form["rblSubCat"]);
                    newItem.uom_purchase_id = Convert.ToInt32(Request.Form["rblPunit"]);
                    newItem.uom_consumption_id = Convert.ToInt32(Request.Form["rblCunit"]);
                    newItem.acc_id = Convert.ToInt32(Request.Form["rblAcc"]);
                    newItem.divisible_uop = Request.Form["txtbdivisibleuop"] == "" ? Convert.ToDecimal(1) : Convert.ToDecimal(Request.Form["txtbdivisibleuop"]);
                    newItem.uid = Convert.ToInt32(Session["userlogin"]);
                    pp.postmaster_item(newItem);
                    if (pp.errTrue == true)
                        Response.Write("<script>alert('" + pp.repText + "')</script>");
                    Response.Write("<script>location.replace(location.pathname)</script>");
                }
                else Response.Write("<script>alert('Missing Fields, Please Fill Required Field!','ISAY');</script>");
            }
            #endregion NEW ITEM CREATING
        }

        protected void btnUpdate2_Click(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            if (!string.IsNullOrEmpty(Request.Form["txtbitemname"]) & btnAdd2.Enabled == false & btnDel2.Enabled == true)
            {
                if (cur_actionid == 3 | cur_actionid == 4)
                {
                    if (Request.Form["rblmainCat"] != null & Request.Form["rblSubCat"] != null)
                    {
                        newItem.iname = (Request.Form["txtbitemname"]);
                        newItem.idesc = (Request.Form["txtbitemdesc"]);
                        newItem.ibarcode = (Request.Form["txtbbarcode"]);
                        newItem.main_cat_id = Convert.ToInt32(Request.Form["rblmainCat"]);
                        newItem.sub_cat_id = Convert.ToInt32(Request.Form["rblSubCat"]);
                        newItem.uom_purchase_id = Convert.ToInt32(Request.Form["rblPunit"]);
                        newItem.uom_consumption_id = Convert.ToInt32(Request.Form["rblCunit"]);
                        newItem.acc_id = Convert.ToInt32(Request.Form["rblAcc"]);
                        newItem.divisible_uop = Convert.ToDecimal(Request.Form["txtbdivisibleuop"]);
                        newItem.uid = Convert.ToInt32(Session["userlogin"]);
                        pp.postmaster_item_update(newItem, Convert.ToInt32(Request.QueryString["iid"]));
                        if (pp.errTrue == true)
                            Response.Write("<script>alert('" + pp.repText + "')</script>");
                        Response.Redirect("/Master/item/item.aspx");
                    }
                    else Response.Write("<script>alert('Missing Fields, Please Fill Required Field!','ISAY');</script>");
                }
                else Response.Write("<script>alert('You are authorized user for this action, Please coordinate  IT Person!. Thank You!');</script>");
            }
        }

        protected void btnDel2_Click(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            if (!string.IsNullOrEmpty(Request.Form["txtbitemname"]) & btnAdd2.Enabled == false & btnDel2.Enabled == true)
            {
                if (cur_actionid == 4)
                {
                    if (Request.Form["rblmainCat"] != null & Request.Form["rblSubCat"] != null)
                    {
                        pp.postmaster_item_delete(Convert.ToInt32(Request.QueryString["iid"]));
                        if (pp.errTrue == true)
                            Response.Write("<script>alert('" + pp.repText + "')</script>");
                        Response.Redirect("/Master/item/item.aspx");
                    }
                    else Response.Write("<script>alert('Missing Fields, Please Fill Required Field!','ISAY');</script>");
                }
                else Response.Write("<script>alert('You are authorized user for this action, Please coordinate  IT Person!. Thank You!');</script>");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("/Master/item/item.aspx?iid=" + GridView1.SelectedValue.ToString());
        }
    }
}