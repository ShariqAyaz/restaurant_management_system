using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using postproceed;
using rdgrant;

namespace ESIT_ERP.Master.department
{
    
    public partial class dept_cat : System.Web.UI.Page
    {
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        postproceed.postproceed pp = new postproceed.postproceed();
        public int cur_actionid;
        static int appid = 7;
        public string retmessage = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"]==null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);
            if (!string.IsNullOrEmpty(Request.Form["txtbdeptcat" + cur_actionid]))
            {
                pp.postmaster(Request.Form["txtbdeptcat" + cur_actionid], "dept_cat");
                Response.Write("<script>location.replace(location.pathname)</script>");
            }
        }
    }
}