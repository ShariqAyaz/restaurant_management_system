using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Numerator;
using AppLogic;
using transactions;

namespace ESIT_ERP.Production.MM
{
    public partial class MRN : System.Web.UI.Page
    {
        AppLogic.MRN mrn = new AppLogic.MRN();
        Numerator.Numerator num = new Numerator.Numerator();
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        postproceed.postproceed pp = new postproceed.postproceed();
        transactions.transactions vtran = new transactions.transactions();
        public int cur_actionid;
        static int appid = 1019;
        public string retmessage = "";
        int store_doc_id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        protected void btnNext_Click(object sender, EventArgs e)
        {
            store_doc_id = num.store_doc_id();
            mrn.doc_id = store_doc_id;
            mrn.doc_date = Convert.ToDateTime(txtBox.Text);
            mrn.iid = Convert.ToInt32(DropDown_IID.SelectedValue);
            mrn.whid = Convert.ToInt32(DropDown_warehouse.SelectedValue);
            mrn.decrease_qty = Convert.ToDecimal(txtbQty.Text);
            mrn.rate = Convert.ToDecimal(txtbRate.Text);
            mrn.ven_id = Convert.ToInt32(DropDown_Venid.SelectedValue);
            mrn.b_entity_id = Convert.ToInt32(Session["bid"]);
            mrn.uid = Convert.ToInt32(Session["userlogin"]);
            mrn.remarks = txtRemarks.Text;
            vtran.postMRN(mrn);
            Response.Redirect("/Production/MM/MRN.aspx");
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/");
        }
    }
}