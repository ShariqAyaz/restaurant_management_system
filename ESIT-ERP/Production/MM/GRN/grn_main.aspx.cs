using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Numerator;
using AppLogic;
using transactions;

namespace ESIT_ERP.Production.MM.GRN
{
    public partial class grn_main : System.Web.UI.Page
    {
        AppLogic.LoadGRN load_grn = new AppLogic.LoadGRN();
        AppLogic.LoadGRN ins_grn = new AppLogic.LoadGRN();
        Numerator.Numerator num = new Numerator.Numerator();
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        postproceed.postproceed pp = new postproceed.postproceed();
        transactions.transactions vtran = new transactions.transactions();
        public int cur_actionid;
        static int appid = 12;
        public string retmessage = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);

            if (Session["grnno"] != null & Session["GRNisPosted"] != null & Session["grnpstage"] != null)
            {
                if (Request.Form["btnnext"] != null)
                {
                        Response.Redirect("/Production/MM/GRN/grn_det.aspx?grnno="+ Session["grnno"]);
                }
                else if(Convert.ToString(Session["grnpstage"])=="1")
                {
                    // Back Button or GRN load existing GRN
                    // check if not posted
                    load_grn = vtran.chkgrn(Convert.ToInt32(Session["grnno"]));
                    txtRemarks.Text = load_grn.remarks;
                    txtBox.Text = Convert.ToString(load_grn.GRDate.ToString("MM/dd/yyyy"));
                    txtbSupInv.Value = load_grn.supplier_invoice;
                    dateh.Value = load_grn.GRDate.ToString("MM/dd/yyyy");
                }
                else
                {
                    Session.Remove("grnno");
                    Session.Remove("grnpstage");
                    Session.Remove("GRNisPosted");
                    Response.Redirect("/Production/MM/GRN/grn_main.aspx");
                }
            }
            else if (Session["grnno"] == null & Session["grnpstage"] == null & Session["GRNisPosted"] == null)
            {
                if (Request.Form["btnnext"] != null)
                {
                    #region INSERT CODE GOES HERE
                    ins_grn.grn_no = num.grnno();
                    ins_grn.supplier_invoice = Request.Form["txtbSupInv"];
                    ins_grn.vendor_id = Convert.ToInt32(DropDownList1.SelectedValue);
                    ins_grn.GRDate = Convert.ToDateTime(txtBox.Text);
                    ins_grn.uid = Convert.ToInt32(Session["userlogin"]);
                    ins_grn.b_entity_id = Convert.ToInt32(Session["bid"]);
                    ins_grn.remarks = txtRemarks.Text;
                    ins_grn.isPosted = false;
                    if (vtran.insertGRNNote(ins_grn)==true)
                    {
                        // Session SET
                        Session["grnpstage"] = 1;
                        Session["GRNisPosted"] = 0;
                        Session["grnno"] = ins_grn.grn_no;
                        Response.Redirect("/Production/MM/GRN/grn_det.aspx?grnno="+ Session["grnno"]);
                        // REDIRECT TO ITEM ENTRY PAGE

                    }
                    else
                    {
                        Response.Write(@"NOT INSERTED");
                    }
                    #endregion INSERT CODE GOES HERE
                    
                    // // // // // //
                    Response.Write(DropDownList1.SelectedValue + "<br>" + txtRemarks.Text + "<br>" + txtBox.Text + "<br>");
                    Response.Write(Convert.ToString(Request.Form["txtbSupInv"]));
                    Response.Write("<br>");
                }
                else
                {
                    //  GRN FORM OPEN AS FRESH MODE //
                    Reset();
                }
            }
            else
            {
                Session.Remove("grnno");
                Session.Remove("grnpstage");
                Session.Remove("GRNisPosted");
            }
            //txtBox.Text = DateTime.Now.ToString();
            //if (cur_actionid == 1)
            //{
            //    btnAdd2.Enabled = false;
            //}
            //if (Request.QueryString["did"] != null)
            //{
            //    modifydept = pp.getdid(Request.QueryString["did"], Convert.ToInt32(Session["bid"]));

            //    //Response.Write(Request.QueryString["whid"]);
            //    txtbdept_name.Text = modifydept.dept_name;
            //    rblDeptCat.SelectedValue = modifydept.dept_cat_id.ToString();
            //    btnDel2.Enabled = true;
            //    btnUpdate2.Enabled = true;
            //    btnAdd2.Enabled = false;
            //}
            //#region NEW VENDOR CREATING
            //if (!string.IsNullOrEmpty(Request.Form["txtbdept_name"]) & btnUpdate2.Enabled == false & btnDel2.Enabled == false)
            //{
            //    if (cur_actionid == 1)
            //    {
            //        Response.Write("<script>alert('You are authorized user for this action, Please coordinate IT Person!. Thank You!');</script>"); return;
            //    }
            //    if (Request.Form["txtbdept_name"] != null & Request.Form["rblDeptCat"] != null)
            //    {
            //        newdepartment.dept_name = (Request.Form["txtbdept_name"]);
            //        newdepartment.dept_cat_id = Convert.ToInt32(Request.Form["rblDeptCat"]);
            //        newdepartment.isActive = 1;
            //        newdepartment.b_entity_id = Convert.ToInt32(Session["bid"]);
            //        pp.postmaster_department(newdepartment);
            //        if (pp.errTrue == true)
            //            Response.Write("<script>alert('" + pp.repText + "')</script>");
            //        Response.Write("<script>location.replace(location.pathname)</script>");
            //    }
            //    else Response.Write("<script>alert('Missing Fields, Please Fill Required Field!','ISAY');</script>");
            //}
            //#endregion NEW WAREHOUSE CREATING
        }

        protected void Reset()
        {

        }

        protected void datet_SelectionChanged(object sender, EventArgs e)
        {
            //Response.Write(datet.SelectedDate.ToShortDateString() + '.');
            //label1.Text = (datet.SelectedDate.ToShortDateString() + '.');
            //datet.Visible = false;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Session.Remove("grnno");
            Session.Remove("grnpstage");
            Session.Remove("GRNisPosted");
            Response.Redirect("/");
        }
    }
}