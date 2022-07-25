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

namespace APPDESK
{
    public partial class frmORG : MetroForm
    {
        public string[] bentity_list = null;
        public string[] bentity_det = null;
        public string getbentity_det = null;

        int userid;
        rdgrant.rdgrant ug = new rdgrant.rdgrant();
        public frmORG(int get_userid)
        {
            InitializeComponent();
            userid = get_userid;
        }


        protected void loadorg()
        {
            getbentity_det = getbentity_det.TrimEnd('^');
            bentity_list = getbentity_det.Split('^');
        }

        private void frmORG_Load(object sender, EventArgs e)
        {
            getbentity_det = ug.getbentitydet(userid);
            loadorg();
            foreach (var b in bentity_list)
            {
                lstbORG.Items.Add(b);
            }
            lstbORG.SelectedIndex = 0;
        }

        private void btnMAIN_Click(object sender, EventArgs e)
        {
            string[] bid = lstbORG.SelectedItem.ToString().Split('|');
            int i = Convert.ToInt16(bid[0]);
            MAIN mn = new MAIN(i, userid);
            mn.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }
    }
}
