using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using rdgrant;


namespace ESIT_ERP
{
    public partial class _default : System.Web.UI.Page
    {
        public string[] applistdet = null;
        public string[] applist = null;
        public string getappsdet="";
        public string[] actionid = null;
        public string testvar="test VAR";
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        protected void Page_Load(object sender, EventArgs e)
        {
            getappsdet = "";
            
            if (Session["userlogin"] != null)
                getappsdet = apps.getUID(Convert.ToInt32(Session["userlogin"]),Convert.ToInt32(Session["bid"]), "LSTAPP");
            else
                Response.Redirect("/login.aspx");
            //
            if (Session["bid"]==null)
            {
                Response.Redirect("/bentity_selection.aspx");
            }
            pnlListing_Load();
        }

        protected void pnlListing_Load()
        {
            getappsdet = getappsdet.TrimEnd('^');
            applist = getappsdet.Split('^');
        }
        
    }
}