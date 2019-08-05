using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rdgrant;

namespace ESIT_ERP
{
    public partial class bentity_selection : System.Web.UI.Page
    {
        public string[] bentity_list = null;
        public string[] bentity_det = null;
        rdgrant.rdgrant ug = new rdgrant.rdgrant();
        public string getbentity_det = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");

            if (Session["bid"]!=null)
            {
                
            }
            getbentity_det = ug.getbentitydet(Convert.ToInt32(Session["userlogin"]));

            if (Request.Form["btnSubmit"]!=null)
            {
                Session["bid"] = Request.Form["rb_bentity"];
                Response.Redirect("/default.aspx");
                return;
            }
            loadorg();
        }

        protected void loadorg()
        {
            getbentity_det = getbentity_det.TrimEnd('^');
            bentity_list = getbentity_det.Split('^');
        }
        
    }
}