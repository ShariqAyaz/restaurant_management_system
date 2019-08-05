using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using postproceed;
using rdgrant;
using AppLogic;

namespace ESIT_ERP.Master.vendor
{
    public partial class vendor : System.Web.UI.Page
    {
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        postproceed.postproceed pp = new postproceed.postproceed();
        public int cur_actionid;
        static int appid = 10;
        public string retmessage = "";
        AppLogic.Vendor newvendor = new AppLogic.Vendor();
        ModVendor modifyvendor = new ModVendor();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);
            if (cur_actionid == 1)
            {
                btnAdd2.Enabled = false;
            }
            if (Request.QueryString["vid"] != null)
            {
                modifyvendor = pp.getvid(Request.QueryString["vid"]);

                //Response.Write(Request.QueryString["whid"]);
                txtbdept_name.Text = modifyvendor.VendorName;
                txtbvendorpersonname.Text = modifyvendor.Contact_Person_name;
                txtbvendorpersonphone.Text = modifyvendor.Contact_Person_Phone;
                txtbvendoraddress.Text = modifyvendor.Address;
                txtbvendordescription.Text = modifyvendor.goods_desc;
                btnDel2.Enabled = true;
                btnUpdate2.Enabled = true;
                btnAdd2.Enabled = false;
            }
            #region NEW VENDOR CREATING
            if (!string.IsNullOrEmpty(Request.Form["txtbvendorpersonname"]) & btnUpdate2.Enabled == false & btnDel2.Enabled == false)
            {
                if (cur_actionid == 1)
                {
                    Response.Write("<script>alert('You are authorized user for this action, Please coordinate IT Person!. Thank You!');</script>"); return;
                }
                if (Request.Form["txtbvendorpersonname"] != null & Request.Form["txtbvendorpersonphone"] != null & Request.Form["txtbvendordescription"] != null)
                {
                    newvendor.VendorName = (Request.Form["txtbdept_name"]);
                    newvendor.Contact_Person_name = (Request.Form["txtbvendorpersonname"]);
                    newvendor.Contact_Person_Phone = (Request.Form["txtbvendorpersonphone"]);
                    newvendor.Address = (Request.Form["txtbvendoraddress"]);
                    newvendor.goods_desc = (Request.Form["txtbvendordescription"]);
                    pp.postmaster_vendor(newvendor);


                    if (pp.errTrue == true)
                        Response.Write("<script>alert('" + pp.repText + "')</script>");
                    Response.Write("<script>location.replace(location.pathname)</script>");
                }
                else Response.Write("<script>alert('Missing Fields, Please Fill Required Field!','ISAY');</script>");
            }
            #endregion NEW WAREHOUSE CREATING
        }

        protected void btnDel2_Click(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            if (!string.IsNullOrEmpty(Request.Form["txtbdept_name"]) & btnAdd2.Enabled == false & btnDel2.Enabled == true)
            {
                if (cur_actionid == 4)
                {
                    if (Request.Form["txtbvendorpersonname"] != null & Request.Form["txtbvendorpersonphone"] != null & Request.Form["txtbvendordescription"] != null)
                    {
                        pp.postmaster_vendor_delete(Convert.ToInt32(Request.QueryString["vid"]));
                        if (pp.errTrue == true)
                            Response.Write("<script>alert('" + pp.repText + "')</script>");
                        Response.Redirect("/Master/vendor/vendor.aspx");
                    }
                    else Response.Write("<script>alert('Missing Fields, Please Fill Required Field!','ISAY');</script>");
                }
                else Response.Write("<script>alert('You are authorized user for this action, Please coordinate  IT Person!. Thank You!');</script>");
            }

        }

        protected void btnUpdate2_Click(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            if (!string.IsNullOrEmpty(Request.Form["txtbdept_name"]) & btnAdd2.Enabled == false & btnDel2.Enabled == true)
            {
                if (cur_actionid == 3 | cur_actionid == 4)
                {
                    if (Request.Form["txtbvendorpersonname"] != null & Request.Form["txtbvendorpersonphone"] != null & Request.Form["txtbvendordescription"] != null)
                    {

                        newvendor.VendorName = (Request.Form["txtbdept_name"]);
                        newvendor.Contact_Person_name = (Request.Form["txtbvendorpersonname"]);
                        newvendor.Contact_Person_Phone = (Request.Form["txtbvendorpersonphone"]);
                        newvendor.Address = (Request.Form["txtbvendoraddress"]);
                        newvendor.goods_desc = (Request.Form["txtbvendordescription"]);
                        pp.postmaster_vendor_update(newvendor, Convert.ToInt32(Request.QueryString["vid"]));
                        if (pp.errTrue == true)
                            Response.Write("<script>alert('" + pp.repText + "')</script>");
                        Response.Redirect("/Master/vendor/vendor.aspx");
                    }
                    else Response.Write("<script>alert('Missing Fields, Please Fill Required Field!','ISAY');</script>");
                }
                else Response.Write("<script>alert('You are authorized user for this action, Please coordinate  IT Person!. Thank You!');</script>");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("/Master/vendor/vendor.aspx?vid=" + GridView1.SelectedValue.ToString());
        }
    }
}