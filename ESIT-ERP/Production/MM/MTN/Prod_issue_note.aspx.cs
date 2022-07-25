using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using postproceed;
using rdgrant;
using AppLogic;


namespace ESIT_ERP.Production.MM.MTN
{
    public partial class Prod_issue_note : System.Web.UI.Page
    {

        AppLogic.LoadPIN load_pin = new AppLogic.LoadPIN();
        AppLogic.LoadPIN ins_pin = new AppLogic.LoadPIN();
        Numerator.Numerator num = new Numerator.Numerator();
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        postproceed.postproceed pp = new postproceed.postproceed();
        transactions.transactions vtran = new transactions.transactions();
        public int cur_actionid;
        static int appid = 16;
        public string retmessage = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);

            txtBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            if (Session["pinno"] != null & Session["pinnoisPosted"] != null)
            {
                if (cur_actionid == 1) return;
                if (Request.Form["btnnext"] != null | Convert.ToInt16(Session["pinnoisPosted"]) == 0)
                {
                    Response.Redirect("/Production/MM/MTN/Prod_issue_det.aspx?pinno=" + Session["pinno"]);
                }
            }
            else if (Session["pinno"] == null & Session["pinnoisPosted"] == null)
            {
                if (cur_actionid == 1) return;
                if (Request.Form["btnnext"] != null)
                {
                    #region INSERT CODE GOES HERE
                    ins_pin.pinno = num.pinno();
                    ins_pin.source_whid = Convert.ToInt32(DropDown_warehouse.SelectedValue);
                    ins_pin.issue_dept_id = Convert.ToInt32(DropDown_dept.SelectedValue);
                    ins_pin.iid = Convert.ToInt32(DropDown_item.SelectedValue);
                    ins_pin.tdate = Convert.ToDateTime(txtBox.Text);
                    ins_pin.uid = Convert.ToInt32(Session["userlogin"]);
                    ins_pin.b_entity_id = Convert.ToInt32(Session["bid"]);
                    ins_pin.remarks = txtRemarks.Text;
                    ins_pin.received_qty = Convert.ToDecimal(txtbQty.Text);

                    if (vtran.insertPINote(ins_pin) == true)
                    {
                        //
                        
                        //
                        // Session SET
                        Session["pinnoisPosted"] = 0;
                        Session["pinno"] = ins_pin.pinno;
                        Response.Redirect("/Production/MM/MTN/Prod_issue_det.aspx?pinno=" + Session["pinno"]);
                        // REDIRECT TO ITEM ENTRY PAGE

                    }
                    else
                    {
                        Response.Write(@"NOT INSERTED");
                    }
                    #endregion INSERT CODE GOES HERE

                    //// // // // // //
                    //Response.Write(DropDownList1.SelectedValue + "<br>" + txtRemarks.Text + "<br>" + txtBox.Text + "<br>");
                    //Response.Write(Convert.ToString(Request.Form["txtbSupInv"]));
                    //Response.Write("<br>");
                }
                else
                {
                    //  PIN FORM OPEN AS FRESH MODE //
                    Reset();
                }
            }
            else
            {
                Session.Remove("pinno");
                Session.Remove("pinnoisPosted");
            }
        }

        protected void Reset()
        {

        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Session.Remove("pinno");
            Session.Remove("pinnoisPosted");
            Response.Redirect("/");
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}