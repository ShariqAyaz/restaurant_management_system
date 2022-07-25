using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Numerator;
using AppLogic;
using transactions;


namespace ESIT_ERP.Production.MM.WIP
{
    public partial class Wip_production : System.Web.UI.Page
    {
        AppLogic.WipProductionEntry WIPRO = new AppLogic.WipProductionEntry();
        Numerator.Numerator num = new Numerator.Numerator();
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        postproceed.postproceed pp = new postproceed.postproceed();
        transactions.transactions vtran = new transactions.transactions();
        public int cur_actionid;
        static int appid = 17;
        public string retmessage = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);
            
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            WIPRO.doc_id = num.wip_production_docid();
            WIPRO.source_whid = Convert.ToInt32(DropDown_warehouse.SelectedValue);
            WIPRO.issue_dept_id = Convert.ToInt32(DropDown_dept.SelectedValue);
            WIPRO.iid = Convert.ToInt32(DropDown_item.SelectedValue);
            WIPRO.tdate = Convert.ToDateTime(txtBox.Text);
            WIPRO.iid_consume_qty = Convert.ToDecimal(txtpiidconsume.Text);
            WIPRO.wip_produce_qty = Convert.ToDecimal(txtbwipproduce.Text);
            WIPRO.wip_item_id = Convert.ToInt32(DropDown_wiplist.SelectedValue);
            WIPRO.remarks = txtRemarks.Text;
            WIPRO.uid = Convert.ToInt32(Session["userlogin"]);
            WIPRO.b_entity_id = Convert.ToInt32(Session["bid"]);
            vtran.postWIPProduction(WIPRO);
            Response.Redirect("/Production/MM/WIP/Wip_production.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/");
        }
    }
}