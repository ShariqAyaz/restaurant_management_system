using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using postproceed;
using rdgrant;
using AppLogic;

namespace ESIT_ERP.Master.department
{
    public partial class department : System.Web.UI.Page
    {
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        postproceed.postproceed pp = new postproceed.postproceed();
        public int cur_actionid;
        static int appid = 11;
        public string retmessage = "";
        Department newdepartment = new Department();
        ModDepartment modifydept = new ModDepartment();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);
            if (cur_actionid == 1)
            {
                btnAdd2.Enabled = false;
            }
            if (Request.QueryString["did"] != null)
            {
                modifydept = pp.getdid(Request.QueryString["did"], Convert.ToInt32(Session["bid"]));

                //Response.Write(Request.QueryString["whid"]);
                txtbdept_name.Text = modifydept.dept_name;
                rblDeptCat.SelectedValue = modifydept.dept_cat_id.ToString();
                btnDel2.Enabled = true;
                btnUpdate2.Enabled = true;
                btnAdd2.Enabled = false;
            }
            #region NEW VENDOR CREATING
            if (!string.IsNullOrEmpty(Request.Form["txtbdept_name"]) & btnUpdate2.Enabled == false & btnDel2.Enabled == false)
            {
                if (cur_actionid == 1)
                {
                    Response.Write("<script>alert('You are authorized user for this action, Please coordinate IT Person!. Thank You!');</script>"); return;
                }
                if (Request.Form["txtbdept_name"] != null & Request.Form["rblDeptCat"]!=null)
                {
                    newdepartment.dept_name = (Request.Form["txtbdept_name"]);
                    newdepartment.dept_cat_id = Convert.ToInt32(Request.Form["rblDeptCat"]);
                    newdepartment.isActive = 1;
                    newdepartment.b_entity_id = Convert.ToInt32(Session["bid"]);
                    pp.postmaster_department(newdepartment);
                    if (pp.errTrue == true)
                        Response.Write("<script>alert('" + pp.repText + "')</script>");
                    Response.Write("<script>location.replace(location.pathname)</script>");
                }
                else Response.Write("<script>alert('Missing Fields, Please Fill Required Field!','ISAY');</script>");
            }
            #endregion NEW WAREHOUSE CREATING
        }

        protected void btnDel2_Click(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            if (!string.IsNullOrEmpty(Request.Form["txtbdept_name"]) & btnAdd2.Enabled == false & btnDel2.Enabled == true)
            {
                if (cur_actionid == 4)
                {
                    if (Request.Form["txtbdept_name"] != null & Request.QueryString["did"] != null)
                    {
                        pp.postmaster_department_delete(Convert.ToInt32(Request.QueryString["did"]), Convert.ToInt32(Session["bid"]));
                        if (pp.errTrue == true)
                            Response.Write("<script>alert('" + pp.repText + "')</script>");
                        Response.Redirect("/Master/department/department.aspx");
                    }
                    else Response.Write("<script>alert('Missing Fields, Please Fill Required Field!','ISAY');</script>");
                }
                else Response.Write("<script>alert('You are authorized user for this action, Please coordinate  IT Person!. Thank You!');</script>");
            }
        }

        protected void btnUpdate2_Click(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            if (!string.IsNullOrEmpty(Request.Form["txtbdept_name"]) & btnAdd2.Enabled == false & btnDel2.Enabled == true)
            {
                if (cur_actionid == 3 | cur_actionid == 4)
                {
                    if (!string.IsNullOrEmpty(Request.Form["txtbdept_name"]) & btnAdd2.Enabled == false & btnDel2.Enabled == true)
                    {
                        newdepartment.dept_name = (Request.Form["txtbdept_name"]);
                        newdepartment.dept_cat_id = Convert.ToInt32(Request.Form["rblDeptCat"]);
                        pp.postmaster_department_update(newdepartment, Convert.ToInt32(Request.QueryString["did"]), Convert.ToInt32(Session["bid"]));
                        if (pp.errTrue == true)
                            Response.Write("<script>alert('" + pp.repText + "')</script>");
                        Response.Redirect("/Master/department/department.aspx");
                    }
                    else Response.Write("<script>alert('Missing Fields, Please Fill Required Field!','ISAY');</script>");
                }
                else Response.Write("<script>alert('You are authorized user for this action, Please coordinate  IT Person!. Thank You!');</script>");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("/Master/department/department.aspx?did=" + GridView1.SelectedValue.ToString());
        }
    }
}