using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAPP
{
    public partial class printPreview_VENDORPAY : Form
    {
        protected string cs = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
        string str = "";
        public printPreview_VENDORPAY()
        {
            InitializeComponent();
        }

        private void printPreview_VENDORPAY_Load(object sender, EventArgs e)
        {
            
        }
    }
}
