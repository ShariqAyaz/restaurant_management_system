using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ESIT_ERP.Reports.MM
{
    public partial class Wip_Stock : System.Web.UI.Page
    {

        protected string cs = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
        //public GRN_ITEMS[] GI = null;
        transactions.transactions GET_GI = new transactions.transactions();
        public bool loaditm = false;
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        public int cur_actionid;
        static int appid = 1023;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/");
        }
    }
}