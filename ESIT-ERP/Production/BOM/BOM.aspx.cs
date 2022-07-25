using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Numerator;
using AppLogic;
using transactions;

namespace ESIT_ERP.Production.BOM
{
    public partial class BOM : System.Web.UI.Page
    {
        AppLogic.LoadGRN load_grn = new AppLogic.LoadGRN();
        AppLogic.LoadGRN ins_grn = new AppLogic.LoadGRN();
        Numerator.Numerator num = new Numerator.Numerator();
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        postproceed.postproceed pp = new postproceed.postproceed();
        transactions.transactions vtran = new transactions.transactions();
        public int cur_actionid;
        static int appid = 13;
        public string retmessage = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("/Production/BOM/ViewBOM.aspx?bomid="+GridView1.SelectedValue.ToString());
        }
    }
}