using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Numerator;
using AppLogic;
using transactions;

namespace ESIT_ERP.Accounts_Transactions
{
    public partial class VendorPay : System.Web.UI.Page
    {
        AppLogic.Vendor_payment vp = new Vendor_payment();
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

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            int vno = num.vpno();
            vp.vpno = vno;
            vp.vendor_id = Convert.ToInt32(DropDownList1.SelectedValue);
            vp.uid = Convert.ToInt32(Session["userlogin"]);
            vp.b_entity_id = Convert.ToInt32(Session["bid"]);
            vp.vDate = Convert.ToDateTime(txtBox.Text);
            vp.remarks = txtbRem.Value;
            vp.dramt = Convert.ToDecimal(txtbAmount.Value);
            vp.isPosted = true;
            vp.cr_acc_id = Convert.ToInt32(DropDownList2.SelectedValue);
            Session["vpay_cr_acc_id"] = DropDownList2.SelectedValue;
            if (vtran.insertVPay(vp) == true)
            {
                vtran.postVendorPayment(Convert.ToString(vno), Convert.ToInt32(Session["userlogin"]), Convert.ToInt32(Session["bid"]));
                Session.Remove("vpay_cr_acc_id");
                Response.Redirect("/Accounts_Transactions/VendorPay.aspx");
            }
            Session.Remove("vpay_cr_acc_id");
            Response.Redirect("/Accounts_Transactions/VendorPay.aspx");
        }
    }
}