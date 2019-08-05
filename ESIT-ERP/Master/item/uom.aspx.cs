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
    public partial class uom : System.Web.UI.Page
    {
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        postproceed.postproceed pp = new postproceed.postproceed();
        public int cur_actionid;
        static int appid = 9;
        public string retmessage = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);
            if (!string.IsNullOrEmpty(Request.Form["txtbuom" + cur_actionid]))
            {
                pp.postmaster(Request.Form["txtbuom" + cur_actionid], "uom_new");
                Response.Write("<script>location.replace(location.pathname)</script>");
            }
        }
    }
}