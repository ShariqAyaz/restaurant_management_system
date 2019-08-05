using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using postproceed;
using rdgrant;

namespace ESIT_ERP.Master.warehousing
{
    public partial class wh_location : System.Web.UI.Page
    {
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        postproceed.postproceed pp = new postproceed.postproceed();
        public int cur_actionid;
        static int appid = 4;
        public string retmessage = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);
            if (!string.IsNullOrEmpty(Request.Form["txtbcatdesc" + cur_actionid]))
            {
                pp.postmaster(Request.Form["txtbcatdesc" + cur_actionid]+"|"+Session["bid"], "wh_location");
                Response.Write("<script>location.replace(location.pathname)</script>");
            }
        }
    }
}