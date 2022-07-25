using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Animation;
using MetroFramework.Drawing;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using MetroFramework.Fonts;
using MetroFramework.Components;
using MetroFramework.Controls;
using AppLogic;
using rdgrant;
namespace APPDESK
{
    public partial class frmLogin : MetroForm
    {
        AuthUser au = new AuthUser();
        rdgrant.rdgrant rd = new rdgrant.rdgrant();
        public int userid;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            au.userid = txtbUsername.Text;
            au.userpass = txtbPass.Text;
            if (rd.userlogin(au) == true)
            {
                userid = rd.useridpostback(au);
                frmORG frmorg = new frmORG(userid);
                frmorg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("NO USER | WRONG PASSWORD"); txtbPass.Focus(); txtbPass.SelectAll(); return;
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (typeof(MetroTextBox) == sender.GetType())
            {
                if (e.KeyCode == Keys.Enter)
                {
                    MetroTextBox mtb = (MetroTextBox)sender;
                    if (mtb.Name == "txtbUsername" & mtb.Text != "")
                    {
                        txtbPass.Focus();
                    }
                    else if (mtb.Name == "txtbPass" & mtb.Text != "")
                    {
                        btnLogin.PerformClick();
                    }
                }
            }
        }
    }
}
