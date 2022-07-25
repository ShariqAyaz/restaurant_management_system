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
using Numerator;

namespace APPDESK
{
    public partial class frmKitchenManagement : MetroForm
    {
        protected string cs = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=ESITERP;integrated security=True;Max Pool Size=50000";
        protected string cs_R = @"data source=ABSERVER2\SQLEXPRESS;initial catalog=OCCOTOPOS3_RES;integrated security=True;Max Pool Size=50000";
        protected string cs_FS = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=OCCOTOPOS3;integrated security=True;Max Pool Size=50000";
        private int user_id, bid;
        int st_t, end_t;
        Numerator.Numerator num = new Numerator.Numerator();
        getOrderNumberKMS gt = new getOrderNumberKMS();
        transactions.transactions tr = new transactions.transactions();


        private int k_id;
        private string lang = "";
        public frmKitchenManagement(int kid, int userid, string s, int bid)
        {
            InitializeComponent();
            user_id = userid;
            k_id = kid;
            lang = s;
            loadD();
        }

        private void loadD()
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("select CAST(OFETCH.id as int) OID,CAST(CAST(OFETCH.otime AS time) AS nvarchar) OTIME,OFETCH.[TABLE] TBL,OFETCH.ticket_tag TTAG,KM.name ename, KM.urduname uname,OFETCH.qty,OFETCH.b_entity_id bid,OFETCH.[status] sts from ORDER_FETCH OFETCH INNER JOIN KITCHENMENU KM ON Ofetch.fg_id=KM.fg_id AND ofetch.b_entity_id=km.b_entity_id where KM.id in (select KMS_Kitchen_DET.PROD_ID from KMS_Kitchen_DET where KMS_Kitchen_DET.KMS_K_ID=" + k_id + ") ORDER BY OFETCH.id desc", con);
                SqlDataReader rdr = null;
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read() == true)
                {
                    DynamicPanel((int)rdr["OID"], (string)rdr["OTIME"] + "|" + (string)rdr["TBL"] + "|" + (string)rdr["TTAG"] + "|" + (string)rdr["ename"] + "|" + (string)rdr["uname"] + "|" + Convert.ToString((decimal)rdr["qty"]) + "|" + Convert.ToString((int)rdr["bid"]) + "|" + (string)rdr["sts"]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DynamicPanel(int i, string cat_name)
        {
            string[] arr = cat_name.Split('|');
            if (arr[7] == "N")
            {
                Panel dynamicPanel = new Panel();
                dynamicPanel.Size = new System.Drawing.Size(tabControl1.Width, 50);
                dynamicPanel.Size = new System.Drawing.Size(flpNew.Width, 50);
                dynamicPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dynamicPanel.Font = new Font("Segoe UI", 16);
                dynamicPanel.BackColor = Color.White;
                // dynamicPanel.Text = cat_name;
                dynamicPanel.Name = "btn_" + i;
                dynamicPanel.Tag = i;
                //i++;
                flpNew.Controls.Add(dynamicPanel);

                #region Panel Component Start
                // 
                // lblTIME
                // 
                //////Label lblTIME = new Label();
                //////lblTIME.AutoSize = true;
                //////lblTIME.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //////lblTIME.Location = new System.Drawing.Point(637, 15);
                //////lblTIME.Name = "lblTIME" + i;
                //////lblTIME.Size = new System.Drawing.Size(49, 20);
                //////lblTIME.TabIndex = 6;
                //////lblTIME.Text = arr[0];
                //////dynamicPanel.Controls.Add(lblTIME);
                // 
                // lblINFO
                //
                Label lblINFO = new Label();
                lblINFO.AutoSize = true;
                lblINFO.Location = new System.Drawing.Point(348, 9);
                lblINFO.Font = new System.Drawing.Font("Segoe UI", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblINFO.Name = "lblINFO" + i;
                lblINFO.Size = new System.Drawing.Size(259, 30);
                lblINFO.TabIndex = 5;
                lblINFO.Text = Convert.ToString(arr[6] == "2" ? "R" : "F") + " " + arr[1];
                dynamicPanel.Controls.Add(lblINFO);
                // 
                // lblINAME
                // 
                Label lblINAME = new Label();
                lblINAME.AutoSize = true;
                lblINAME.BackColor = System.Drawing.Color.Transparent;
                lblINAME.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblINAME.Location = new System.Drawing.Point(50, 0);
                lblINAME.Name = "lblINAME" + i;
                lblINAME.Size = new System.Drawing.Size(187, 43);
                lblINAME.TabIndex = 4;
                lblINAME.Text = lang == "UR" ? arr[4] : arr[3];
                dynamicPanel.Controls.Add(lblINAME);
                // 
                // lblIQTY
                // 
                Label lblIQTY = new Label();
                lblIQTY.AutoSize = true;
                lblIQTY.Location = new System.Drawing.Point(6, 10);
                lblIQTY.Name = "lblIQTY" + i;
                lblIQTY.Size = new System.Drawing.Size(25, 30);
                lblIQTY.TabIndex = 3;
                lblIQTY.Text = arr[5];
                dynamicPanel.Controls.Add(lblIQTY);
                // 
                // btnDel
                // 
                Button btnDel = new Button();
                btnDel.Anchor = System.Windows.Forms.AnchorStyles.Right;
                btnDel.FlatStyle = FlatStyle.Popup;
                btnDel.BackColor = System.Drawing.Color.Red;
                btnDel.Location = new System.Drawing.Point(737, 0);
                btnDel.Name = "btnDel" + i;
                btnDel.Size = new System.Drawing.Size(95, 50);
                btnDel.TabIndex = 2;
                btnDel.Tag = i;
                btnDel.Text = "D";
                btnDel.UseVisualStyleBackColor = false;
                btnDel.Click += new EventHandler(btnDel_Click);
                dynamicPanel.Controls.Add(btnDel);
                // 
                // btnProcess
                // 
                Button btnProcess = new Button();
                btnProcess.Anchor = System.Windows.Forms.AnchorStyles.Right;
                btnProcess.FlatStyle = FlatStyle.Popup;
                btnProcess.BackColor = System.Drawing.Color.Yellow;
                btnProcess.Location = new System.Drawing.Point(830, 0);
                btnProcess.Name = "btnProcess" + i;
                btnProcess.Size = new System.Drawing.Size(95, 50);
                btnProcess.TabIndex = 1;
                btnProcess.Tag = i;
                btnProcess.Text = "I";
                btnProcess.UseVisualStyleBackColor = false;
                btnProcess.Click += new EventHandler(btnProcess_Click);
                dynamicPanel.Controls.Add(btnProcess);
                // btnCompleted
                Button btnCompleted = new Button();
                btnCompleted.Anchor = System.Windows.Forms.AnchorStyles.Right;
                btnCompleted.FlatStyle = FlatStyle.Popup;
                btnCompleted.BackColor = System.Drawing.Color.Green;
                btnCompleted.ForeColor = System.Drawing.Color.White;
                btnCompleted.Location = new System.Drawing.Point(915, 0);
                btnCompleted.Name = "btnCompleted" + i;
                btnCompleted.Size = new System.Drawing.Size(95, 50);
                btnCompleted.Tag = i;
                btnCompleted.TabIndex = 0;
                btnCompleted.Text = "C";
                btnCompleted.UseVisualStyleBackColor = false;
                btnCompleted.Click += new EventHandler(btnCompleted_Click);
                dynamicPanel.Controls.Add(btnCompleted);
                #endregion Panel Component END
            }
            else if (arr[7] == "I")
            {
                Panel dynamicPanel = new Panel();
                dynamicPanel.Size = new System.Drawing.Size(this.Width, 50);
                dynamicPanel.Size = new System.Drawing.Size(flpInProcess.Width, 50);
                dynamicPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dynamicPanel.Font = new Font("Segoe UI", 16);
                dynamicPanel.BackColor = Color.Pink;
                // dynamicPanel.Text = cat_name;
                dynamicPanel.Name = "btn_" + i;
                dynamicPanel.Tag = i;
                //i++;
                flpInProcess.Controls.Add(dynamicPanel);
                #region Panel Component Start
                // 
                // lblTIME
                // 
                //////Label lblTIME = new Label();
                //////lblTIME.AutoSize = true;
                //////lblTIME.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //////lblTIME.Location = new System.Drawing.Point(637, 15);
                //////lblTIME.Name = "lblTIME" + i;
                //////lblTIME.Size = new System.Drawing.Size(49, 20);
                //////lblTIME.TabIndex = 6;
                //////lblTIME.Text = arr[0];
                //////dynamicPanel.Controls.Add(lblTIME);
                // 
                // lblINFO
                //
                Label lblINFO = new Label();
                lblINFO.AutoSize = true;
                lblINFO.Location = new System.Drawing.Point(348, 9);
                lblINFO.Font = new System.Drawing.Font("Segoe UI", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblINFO.Name = "lblINFO" + i;
                lblINFO.Size = new System.Drawing.Size(259, 30);
                lblINFO.TabIndex = 5;
                lblINFO.Text = Convert.ToString(arr[6] == "2" ? "RES" : "FF") + "  " + arr[1];
                dynamicPanel.Controls.Add(lblINFO);
                // 
                // lblINAME
                // 
                Label lblINAME = new Label();
                lblINAME.AutoSize = true;
                lblINAME.BackColor = System.Drawing.Color.Transparent;
                lblINAME.Font = new System.Drawing.Font("XB Kayhan Sayeh", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblINAME.Location = new System.Drawing.Point(50, 0);
                lblINAME.Name = "lblINAME" + i;
                lblINAME.Size = new System.Drawing.Size(187, 43);
                lblINAME.TabIndex = 4;
                lblINAME.Text = lang == "UR" ? arr[4] : arr[3];
                dynamicPanel.Controls.Add(lblINAME);
                // 
                // lblIQTY
                // 
                Label lblIQTY = new Label();
                lblIQTY.AutoSize = true;
                lblIQTY.Location = new System.Drawing.Point(6, 10);
                lblIQTY.Name = "lblIQTY" + i;
                lblIQTY.Size = new System.Drawing.Size(25, 30);
                lblIQTY.TabIndex = 3;
                lblIQTY.Text = arr[5];
                dynamicPanel.Controls.Add(lblIQTY);
                // 
                // btnDel
                // 
                Button btnDel = new Button();
                btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom));
                btnDel.FlatStyle = FlatStyle.Popup;
                btnDel.BackColor = System.Drawing.Color.Red;
                btnDel.Location = new System.Drawing.Point(737, 0);
                btnDel.Name = "btnDel" + i;
                btnDel.Size = new System.Drawing.Size(95, 50);
                btnDel.TabIndex = 2;
                btnDel.Tag = i;
                btnDel.Text = "D";
                btnDel.UseVisualStyleBackColor = false;
                btnDel.Click += new EventHandler(btnDel_Click);
                dynamicPanel.Controls.Add(btnDel);
                // 
                // btnProcess
                // 
                Button btnProcess = new Button();
                btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
                btnProcess.FlatStyle = FlatStyle.Popup;
                btnProcess.BackColor = System.Drawing.Color.Yellow;
                btnProcess.Location = new System.Drawing.Point(830, 0);
                btnProcess.Name = "btnProcess" + i;
                btnProcess.Size = new System.Drawing.Size(95, 50);
                btnProcess.TabIndex = 1;
                btnProcess.Tag = i;
                btnProcess.Text = "I";
                btnProcess.UseVisualStyleBackColor = false;
                btnProcess.Click += new EventHandler(btnProcess_Click);
                dynamicPanel.Controls.Add(btnProcess);
                // btnCompleted
                Button btnCompleted = new Button();
                btnCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top));
                btnCompleted.FlatStyle = FlatStyle.Popup;
                btnCompleted.BackColor = System.Drawing.Color.Green;
                btnCompleted.ForeColor = System.Drawing.Color.White;
                btnCompleted.Location = new System.Drawing.Point(915, 0);
                btnCompleted.Name = "btnCompleted" + i;
                btnCompleted.Size = new System.Drawing.Size(95, 50);
                btnCompleted.Tag = i;
                btnCompleted.TabIndex = 0;
                btnCompleted.Text = "C";
                btnCompleted.UseVisualStyleBackColor = false;
                btnCompleted.Click += new EventHandler(btnCompleted_Click);
                dynamicPanel.Controls.Add(btnCompleted);
                #endregion Panel Component END
            }
            else if (arr[7] == "C")
            {
                Panel dynamicPanel = new Panel();
                dynamicPanel.Size = new System.Drawing.Size(this.Width,50);
                dynamicPanel.Size = new System.Drawing.Size(flpCompleted.Width, 50);
                dynamicPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dynamicPanel.Font = new Font("Segoe UI", 16);
                dynamicPanel.BackColor = Color.Green;
                // dynamicPanel.Text = cat_name;
                dynamicPanel.Name = "btn_" + i;
                dynamicPanel.Tag = i;
                //dynamicPanelC.Click += new EventHandler(DynamicButtonItem_Click);
                flpCompleted.Controls.Add(dynamicPanel);
                #region Panel Component Start
                // 
                // lblTIME
                // 
                ////////Label lblTIME = new Label();
                ////////lblTIME.AutoSize = true;
                ////////lblTIME.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ////////lblTIME.Location = new System.Drawing.Point(637, 15);
                ////////lblTIME.Name = "lblTIME" + i;
                ////////lblTIME.Size = new System.Drawing.Size(49, 20);
                ////////lblTIME.TabIndex = 6;
                ////////lblTIME.Text = arr[0];
                ////////dynamicPanel.Controls.Add(lblTIME);
                // 
                // lblINFO
                //
                Label lblINFO = new Label();
                lblINFO.AutoSize = true;
                lblINFO.Location = new System.Drawing.Point(348, 9);
                lblINFO.Font = new System.Drawing.Font("Segoe UI", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblINFO.Name = "lblINFO" + i;
                lblINFO.Size = new System.Drawing.Size(259, 30);
                lblINFO.TabIndex = 5;
                lblINFO.Text = Convert.ToString(arr[6] == "2" ? "RES" : "FF") + "-" + arr[1];
                dynamicPanel.Controls.Add(lblINFO);
                // 
                // lblINAME
                // 
                Label lblINAME = new Label();
                lblINAME.AutoSize = true;
                lblINAME.BackColor = System.Drawing.Color.Transparent;
                lblINAME.Font = new System.Drawing.Font("XB Kayhan Sayeh", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblINAME.Location = new System.Drawing.Point(50, 0);
                lblINAME.Name = "lblINAME" + i;
                lblINAME.Size = new System.Drawing.Size(187, 43);
                lblINAME.TabIndex = 4;
                lblINAME.Text = lang == "UR" ? arr[4] : arr[3];
                dynamicPanel.Controls.Add(lblINAME);
                // 
                // lblIQTY
                // 
                Label lblIQTY = new Label();
                lblIQTY.AutoSize = true;
                lblIQTY.Location = new System.Drawing.Point(6, 10);
                lblIQTY.Name = "lblIQTY" + i;
                lblIQTY.Size = new System.Drawing.Size(25, 30);
                lblIQTY.TabIndex = 3;
                lblIQTY.Text = arr[5];
                dynamicPanel.Controls.Add(lblIQTY);
                // 
                // btnDel
                // 
                Button btnDel = new Button();
                btnDel.Location = new System.Drawing.Point(737, 0);
                btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top));
                btnDel.FlatStyle = FlatStyle.Popup;
                btnDel.BackColor = System.Drawing.Color.Red;
                btnDel.Name = "btnDel" + i;
                btnDel.Size = new System.Drawing.Size(95, 50);
                btnDel.TabIndex = 2;
                btnDel.Tag = i;
                btnDel.Text = "D";
                btnDel.UseVisualStyleBackColor = false;
                btnDel.Click += new EventHandler(btnDel_Click);
                dynamicPanel.Controls.Add(btnDel);
                // 
                // btnProcess
                // 
                Button btnProcess = new Button();
                btnProcess.Location = new System.Drawing.Point(830, 0);
                btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top));
                btnProcess.FlatStyle = FlatStyle.Popup;
                btnProcess.BackColor = System.Drawing.Color.Yellow;
                btnProcess.Name = "btnProcess" + i;
                btnProcess.Size = new System.Drawing.Size(95, 50);
                btnProcess.TabIndex = 1;
                btnProcess.Tag = i;
                btnProcess.Text = "I";
                btnProcess.UseVisualStyleBackColor = false;
                btnProcess.Click += new EventHandler(btnProcess_Click);
                dynamicPanel.Controls.Add(btnProcess);
                // btnCompleted
                Button btnCompleted = new Button();
                btnCompleted.Location = new System.Drawing.Point(915, 0);
                btnCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
                btnCompleted.FlatStyle = FlatStyle.Popup;
                btnCompleted.BackColor = System.Drawing.Color.Green;
                btnCompleted.ForeColor = System.Drawing.Color.White;
                btnCompleted.Name = "btnCompleted" + i;
                btnCompleted.Size = new System.Drawing.Size(95, 50);
                btnCompleted.Tag = i;
                btnCompleted.TabIndex = 0;
                btnCompleted.Text = "C";
                btnCompleted.UseVisualStyleBackColor = false;
                btnCompleted.Click += new EventHandler(btnCompleted_Click);
                dynamicPanel.Controls.Add(btnCompleted);
                #endregion Panel Component END
            }
            //arr[0]; // TIME
            //arr[1]; // tbl
            //arr[2]; // ttag
            //arr[3]; // ename
            //arr[4]; // uname
            //arr[5]; // qty
            //arr[6]; // bid
            //arr[7]; // sts
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10000;
            flpCompleted.Controls.Clear();
            flpInProcess.Controls.Clear();
            flpNew.Controls.Clear();
            loadD();
            flpNew.Width = this.Width - 5;
            flpInProcess.Width = this.Width - 5;
            flpCompleted.Width = this.Width - 5;
        }

        private void flpInProcess_SizeChanged(object sender, EventArgs e)
        {
            foreach (Panel pnl in flpInProcess.Controls)
            {
                pnl.Width = (flpInProcess.Width - 15);
            }
            foreach (Panel pnl in flpCompleted.Controls)
            {
                pnl.Width = (flpInProcess.Width - 15);
            }
            foreach (Panel pnl in flpNew.Controls)
            {
                pnl.Width = (flpInProcess.Width - 15);
            }
        }


        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                int oid = Convert.ToInt32(btn.Tag);
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("update ORDER_FETCH set [status]='I' WHERE id=" + oid, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int oid = Convert.ToInt32(btn.Tag);
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("delete ORDER_FETCH where id=" + oid, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //this.Parent.Controls.Clear();
        }

        private void frmKitchenManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int oid = Convert.ToInt32(btn.Tag);
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("update ORDER_FETCH set [status]='C' WHERE id=" + oid, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //Panel pn = (Panel)sender;
            //if (pn.Name == "btn_" + oid.ToString())
            //{
            //    pn.Controls.Clear();
            //    pn.Dispose();
            //    pn.SuspendLayout();
            //}
        }

    }
}
