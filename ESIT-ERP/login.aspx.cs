using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppLogic;
using rdgrant;

namespace ESIT_ERP
{
    public partial class login : System.Web.UI.Page
    {
        AppLogic.AuthUser authuser = new AuthUser();
        rdgrant.rdgrant ugrant = new rdgrant.rdgrant();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            authuser.userid = txtbUsername.Text;
            authuser.userpass = txtbPassword.Text;
            if (ugrant.userlogin(authuser) == true)
            {
                Session["userlogin"] = ugrant.useridpostback(authuser);
                Response.Redirect("/default.aspx");
            }
            else Response.Write("<script>alert('INVALID USER/PASS');</script>");
        }

        public string getuserid = "";

    }
}