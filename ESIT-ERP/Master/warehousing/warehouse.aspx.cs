using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using postproceed;
using rdgrant;  
using AppLogic; 
                
namespace ESIT_ERP.Master.warehousing
{               
    public partial class warehouse : System.Web.UI.Page
    {           
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        postproceed.postproceed pp = new postproceed.postproceed();
        public int cur_actionid;
        static int appid = 3;
        public string retmessage = "";
        AppLogic.Warehouse newwarehouse = new AppLogic.Warehouse();
        ModWarehouse modifywh = new ModWarehouse();
        protected void Page_Load(object sender, EventArgs e)
        {       
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);
            if (cur_actionid == 1)
            {
                btnAdd2.Enabled = false;
            }
            if (Request.QueryString["whid"] != null)
            {   
                modifywh = pp.getwh(Request.QueryString["whid"], Convert.ToInt32(Session["bid"]));
                
                //Response.Write(Request.QueryString["whid"]);
                txtWHName.Text = modifywh.whname;
                txtWHDesc.Text = modifywh.whdesc;
                rblCAT.SelectedValue = modifywh.whcat.ToString();
                rblLocation.SelectedValue = modifywh.whloc.ToString();
                rblType.SelectedValue = modifywh.whtype.ToString();
                btnDel2.Enabled = true;
                btnUpdate2.Enabled = true;
                btnAdd2.Enabled = false;
            }
            #region NEW WAREHOUSE CREATING
            if (!string.IsNullOrEmpty(Request.Form["txtWHName"]) & btnUpdate2.Enabled == false & btnDel2.Enabled == false)
            {
                if (cur_actionid == 1)
                {
                    Response.Write("<script>alert('You are authorized user for this action, Please coordinate IT Person!. Thank You!');</script>");return;
                }
                if (Request.Form["rblCAT"] != null & Request.Form["rblType"] != null & Request.Form["rblLocation"] != null)
                {
                    newwarehouse.wh_name=(Request.Form["txtWHName"]);
                    newwarehouse.wh_desc = (Request.Form["txtWHDesc"]);
                    newwarehouse.cat_id = Convert.ToInt32(Request.Form["rblCAT"]);
                    newwarehouse.type_id = Convert.ToInt32(Request.Form["rblType"]);
                    newwarehouse.location_id = Convert.ToInt32(Request.Form["rblLocation"]);
                    newwarehouse.isActive = true;
                    newwarehouse.uid = Convert.ToInt32(Session["userlogin"]);
                    newwarehouse.b_entity_id = (Convert.ToInt32(Session["bid"]));
                    pp.postmaster_wh(newwarehouse);
                    if (pp.errTrue==true)
                    Response.Write("<script>alert('"+pp.repText+"')</script>");
                    Response.Write("<script>location.replace(location.pathname)</script>");
                }
                else Response.Write("<script>alert('Missing Fields, Please Fill Required Field!','ISAY');</script>");
            }
            #endregion NEW WAREHOUSE CREATING
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("/Master/warehousing/warehouse.aspx?whid="+ GridView1.SelectedValue.ToString());
        }

        protected void btnUpdate2_Click(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            if (!string.IsNullOrEmpty(Request.Form["txtWHName"]) & btnAdd2.Enabled == false & btnDel2.Enabled==true)
            {
                if (cur_actionid==3 | cur_actionid == 4)
                {
                    if (Request.Form["rblCAT"] != null & Request.Form["rblType"] != null & Request.Form["rblLocation"] != null)
                    {
                        newwarehouse.wh_name = (Request.Form["txtWHName"]);
                        newwarehouse.wh_desc = (Request.Form["txtWHDesc"]);
                        newwarehouse.cat_id = Convert.ToInt32(Request.Form["rblCAT"]);
                        newwarehouse.type_id = Convert.ToInt32(Request.Form["rblType"]);
                        newwarehouse.location_id = Convert.ToInt32(Request.Form["rblLocation"]);
                        newwarehouse.isActive = true;
                        newwarehouse.uid = Convert.ToInt32(Session["userlogin"]);
                        newwarehouse.b_entity_id = (Convert.ToInt32(Session["bid"]));
                        pp.postmaster_wh_update(newwarehouse,Convert.ToInt32(Request.QueryString["whid"]), Convert.ToInt32(Session["bid"]));
                        if (pp.errTrue == true)
                            Response.Write("<script>alert('" + pp.repText + "')</script>");
                        Response.Redirect("/Master/warehousing/warehouse.aspx");
                    }
                    else Response.Write("<script>alert('Missing Fields, Please Fill Required Field!','ISAY');</script>");
                }
                else Response.Write("<script>alert('You are authorized user for this action, Please coordinate  IT Person!. Thank You!');</script>");
            }
        }

        protected void btnDel2_Click(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            if (!string.IsNullOrEmpty(Request.Form["txtWHName"]) & btnAdd2.Enabled == false & btnDel2.Enabled == true)
            {
                if (cur_actionid == 4)
                {
                    if (Request.Form["rblCAT"] != null & Request.Form["rblType"] != null & Request.Form["rblLocation"] != null)
                    {
                        //newwarehouse.wh_name = (Request.Form["txtWHName"]);
                        //newwarehouse.wh_desc = (Request.Form["txtWHDesc"]);
                        //newwarehouse.cat_id = Convert.ToInt32(Request.Form["rblCAT"]);
                        //newwarehouse.type_id = Convert.ToInt32(Request.Form["rblType"]);
                        //newwarehouse.location_id = Convert.ToInt32(Request.Form["rblLocation"]);
                        //newwarehouse.isActive = true;
                        //newwarehouse.uid = Convert.ToInt32(Session["userlogin"]);
                        //newwarehouse.b_entity_id = apps.getorgid(Convert.ToInt32(Session["userlogin"]));
                        pp.postmaster_wh_delete(Convert.ToInt32(Request.QueryString["whid"]), Convert.ToInt32(Session["bid"]));
                        if (pp.errTrue == true)
                            Response.Write("<script>alert('" + pp.repText + "')</script>");
                        Response.Redirect("/Master/warehousing/warehouse.aspx");
                    }
                    else Response.Write("<script>alert('Missing Fields, Please Fill Required Field!','ISAY');</script>");
                }
                else Response.Write("<script>alert('You are authorized user for this action, Please coordinate  IT Person!. Thank You!');</script>");
            }
        }
    }
}