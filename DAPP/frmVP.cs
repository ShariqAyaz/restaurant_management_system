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
    public partial class frmVP : Form
    {

        protected string cs = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
        string str = "";
        public frmVP()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM VENDOR_PAYSLIP WHERE tno="+textBox1.Text;
            DataSet ds = new DataSet();
            SqlDataAdapter SD = new SqlDataAdapter(query, con);
            // SD.Fill
            SD.Fill(ds, "VENDOR_PAYSLIP");
        }
    }
}
