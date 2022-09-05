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
using System.Data.SqlClient;

namespace APPDESK
{
    public partial class frmNewKitchen : MetroForm
    {
        protected string cs = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=ESITERP;integrated security=True;Max Pool Size=50000";
        protected string cs_R = @"data source=ABSERVER\SQLEXPRESS;initial catalog=SambaPOS3_RES;integrated security=True;Max Pool Size=50000";
        protected string cs_FS = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=SambaPOS3;integrated security=True;Max Pool Size=50000";
        private int user_id;
        public frmNewKitchen(int userid)
        {
            InitializeComponent();
            user_id = userid;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (cboxORG.SelectedValue == null | cboxORG.Text=="")
            {
                MessageBox.Show("PLEASE SELECT LOCATION");
                return;
            }
            if (cboxKitchen.Text == "")
            {
                MessageBox.Show("PLEASE SELECT OR WRITE KITCHEN NAME");
                return;
            }
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("INSERT INTO KMS_Kitchen([Kitchen Name],b_entity_id,uid) values(N'"+cboxKitchen.Text+"'," + cboxORG.SelectedValue+ ","+user_id+")", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            loadKitchenName();
            cboxKitchen.Focus();
            cboxKitchen.DroppedDown = true;
        }

        private void loadKitchenName()
        {
            this.b_entityTableAdapter.Fill(this.eSITERPDataSet.b_entity);
            this.kMS_KitchenTableAdapter.Fill(this.eSITERPDataSet.KMS_Kitchen);
        }

        private void frmNewKitchen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eSITERPDataSet.KITCHENMENU' table. You can move, or remove it, as needed.
            this.kITCHENMENUTableAdapter.Fill(this.eSITERPDataSet.KITCHENMENU);
            // TODO: This line of code loads data into the 'eSITERPDataSet.b_entity' table. You can move, or remove it, as needed.
            this.b_entityTableAdapter.Fill(this.eSITERPDataSet.b_entity);
            // TODO: This line of code loads data into the 'eSITERPDataSet.KMS_Kitchen' table. You can move, or remove it, as needed.
            this.kMS_KitchenTableAdapter.Fill(this.eSITERPDataSet.KMS_Kitchen);
        }

        private void cboxKitchen_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from KMS_Kitchen where id="+cboxKitchen.SelectedValue+"",con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read()==true)
            {
                cboxORG.SelectedValue = (int)rdr["id"];
                gbProd.Enabled = true;
                this.kITDETTA.Fill(this.eSITERPDataSet.KITDETDT,Convert.ToInt32(cboxKitchen.SelectedValue));
            }
            con.Close();
        }

        private void btnSaveNext_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("INSERT INTO KMS_Kitchen_DET(KMS_K_ID,PROD_ID) VALUES(" + cboxKitchen.SelectedValue + "," + cboxProd.SelectedValue + ")", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.kITDETTA.Fill(this.eSITERPDataSet.KITDETDT, Convert.ToInt32(cboxKitchen.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void metroGrid1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int curRow = -1;
                //MessageBox.Show(importgrid.CurrentRow.Index.ToString());
                if (metroGrid1.CurrentRow.Index != curRow)
                {
                    curRow = metroGrid1.CurrentRow.Index;
                    
                    updkey = ((Int32)metroGrid1["kid", curRow].Value).ToString();
                    //DTP.Value = (DateTime)metroGrid1["gridtxtbdate", curRow].Value;
                    //btnSaveNext.Text = "Update";
                    btnDel.Text = "Delete " + ((Int32)metroGrid1["kid", curRow].Value).ToString() + " ?";
                    btnSaveNext.Enabled = true;
                    btnClose.Enabled = false;
                    btnDel.Enabled = true;
                    btnDel.Visible = true;
                    //isEdit = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        string  updkey;

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("delete from KMS_Kitchen_DET where id="+updkey, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
this.kITDETTA.Fill(this.eSITERPDataSet.KITDETDT, Convert.ToInt32(cboxKitchen.SelectedValue));


            btnSaveNext.Text = "Save && Next";
            //cboxsm.Text = ""; cboxdnc.Text = ""; txtbsm.Text = "0"; txtbdnc.Text = "0";
            MessageBox.Show("updated");
            //cboxdnc.Focus();
            //this.dNCTA.FillDNC(this.coatsInsentiveDataSet.DNCDT);
            btnClose.Enabled = true;
            //isEdit = false;
            btnDel.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
