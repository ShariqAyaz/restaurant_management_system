using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using postproceed;
using rdgrant;

namespace ESIT_ERP.Master.item
{
    public partial class item_subcat : System.Web.UI.Page
    {
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        postproceed.postproceed pp = new postproceed.postproceed();
        public int cur_actionid;
        static int appid = 6;
        public string retmessage = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["userlogin"].ToString()))
                Response.Redirect("login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);
            if (!string.IsNullOrEmpty(Request.Form["txtbisubcat" + cur_actionid]))
            {
                pp.postmaster(Request.Form["txtbisubcat" + cur_actionid], "isub_cat");
                Response.Write("<script>location.replace(location.pathname)</script>");
            }
        }
    }
}