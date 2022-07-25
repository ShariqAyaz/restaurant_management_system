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
using AppLogic;
using Appdesc_Logic;
using rdgrant;

namespace APPDESK
{
    public partial class frmFastSettle : MetroForm
    {
        AppLogic.get_bcode gb = new get_bcode();
        Appdesc_Logic.Appdesc_Logic AL = new Appdesc_Logic.Appdesc_Logic();
        rdgrant.rdgrant rd = new rdgrant.rdgrant();
        int bid, userid;
        bool ready_to_settle = false;
        bool IsLocked = false;
        int ticket_id, acc_doc_id, entity_id, ticket_no;
        public frmFastSettle(int get_bid, int get_userid)
        {
            InitializeComponent();
            bid = get_bid;
            userid = get_userid;
        }

        private void frmFastSettle_Load(object sender, EventArgs e)
        {
            if (txtbBcode.Focused == false)
            {
                txtbBcode.Focus();
            }
            //this.rES_FETCHTICKET_TA.Fill(this.eSITERPDataSet._RES_FETCHTICKET_DT, Convert.ToString(2776));

            //this.accountsTableAdapter.ClearBeforeFill = true;
            //this.accountsTableAdapter.Fill(this.eSITERPDataSet.Accounts);
            lblUser.Text = "USER: " + rd.getUname(userid);
        }

        string alf = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtbBcode.Focused == false)
            {
                txtbBcode.Focus();
            }
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            if (btnSettle.Enabled == true & ready_to_settle == true)
            {
                SETTLE_NOW();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (alf.Contains("*END*") == true)
                this.Close();
            alf += e.KeyChar.ToString();

            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (alf.Contains("*E") == true)
                {
                    try
                    {
                        string[] alfarr = alf.Split('*');
                        string[] get_code = alfarr[0].Split('-');
                        gb.app_code = get_code[0];
                        gb.comp = get_code[1];
                        gb.key = Convert.ToInt32(get_code[2]);
                        ticket_no = Convert.ToInt32(get_code[2]);
                        paction(gb);
                        alf = "";
                    }
                    catch (Exception ex)
                    {
                        alf = "";
                        reset();
                    }
                }
                else
                {

                }

            }

        }

        private void reset()
        {
            btnSettle.Enabled = false;
            txtbBcode.Text = "";
            txtbTOT.Text = "0.00";
            this.eSITERPDataSet.Clear();
            txtbTICKETNO.Text = "";
            txtbMessage.Text = "";
        }

        private void reset_with_Message()
        {
            btnSettle.Enabled = false;
            txtbBcode.Text = "";
            txtbTOT.Text = "0.00";
            this.eSITERPDataSet.Clear();
            txtbTICKETNO.Text = "";
            //txtbMessage.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void foundsettle()
        {
            btnSettle.Enabled = false;
            txtbBcode.Text = "";
            //txtbTOT.Text = "0.00";
            //this.eSITERPDataSet.Clear();
        }

        private void ready()
        {
            btnSettle.Enabled = true;
            txtbBcode.Text = "";
            //txtbTICKETNO.Text = "";
        }

        public void paction(AppLogic.get_bcode a)
        {
            // A = Restaurant Dine-In, Take Away and Delivery Bill //
            // F = Fastfoods Dine-In, Take Away and Delivery Bill //
            if (a.app_code == "A" & bid == 2)
            {
                // CHECKS START
                // CHECK FOR EXISTANCE
                if (AL.isExist(a.app_code, a.key, bid) != true)
                {
                    TTIP.Show("NOT VALID BILL OR ITEM ARE DELETED\nبل نمبرصحیح نہیں ہے", txtbBcode, 20, 20, 5000);
                    txtbMessage.Text = "NOT VALID ARE DELETED\nبل نمبرصحیح نہیں ہے";
                    txtbMessage.BackColor = Color.Red;
                    ready_to_settle = false;
                    txtbTICKETNO.Text = a.key.ToString();
                    reset();
                    return;
                }
                //
                if (AL.isSettle(a.app_code, a.key, bid) == true)
                {
                    TTIP.Show("ALREADY SETTLE\nبل سیٹل ہوجکا ہے", txtbBcode, 10, 10, 3000);
                    txtbMessage.Text = "ALREADY SETTLE\nبل سیٹل ہوجکا ہے";
                    txtbMessage.BackColor = Color.Red;
                    this.rES_FETCHTICKET_TA.Fill(this.eSITERPDataSet._RES_FETCHTICKET_DT, Convert.ToString(a.key));
                    foundsettle();
                    ready_to_settle = false;
                    txtbTOT.Text = Convert.ToString(AL.bill_tot(a.app_code, a.key, bid));
                    txtbTICKETNO.Text = "Ticket No: " + a.key.ToString();
                    return;
                }
                this.rES_FETCHTICKET_TA.Fill(this.eSITERPDataSet._RES_FETCHTICKET_DT, Convert.ToString(a.key));
                // GET KEY INFO'S
                /// GET TICKET_ID
                ticket_id = AL.getTID(a.app_code, a.key, bid);
                acc_doc_id = AL.getACC_DOC_ID(a.app_code, a.key, bid);
                entity_id = AL.getEntityId(a.app_code, a.key, bid);
                IsLocked = AL.isLocked(a.app_code, a.key, bid);
                /// GET TICKET LOCKED STATUS
                /// GET ACC_DOC_ID
                /// GET ENTITY_ID
                // GET KEY INFO'S

                txtbTOT.Text = Convert.ToString(AL.bill_tot(a.app_code, a.key, bid));
                txtbTICKETNO.Text = "Ticket No: " + ticket_id.ToString();
                txtbMessage.Text = "NOT SETTLED YET ابھی تک سٹل نہیں ہوا";
                txtbMessage.BackColor = Color.Yellow;
                ready_to_settle = true;
                ready();
            }
            else if (a.app_code == "A" & bid == 1)
            {
                txtbMessage.Text = "It's Look like Restaurant Bill. یہ ریسٹورانٹ کا بل ہے";
                reset_with_Message();
            }
            else if (a.app_code == "B" & bid == 2)
            {
                txtbMessage.Text = "It's Look like Fastfood Bill. یہ فاسٹ فوڈ کا بل ہے";
                reset_with_Message();
            }
            else if (a.app_code == "B" & bid == 1)
            {
                //// CHECKS START
                //// CHECK FOR EXISTANCE
                //if (AL.isExist(a.app_code, a.key, bid) != true)
                //{
                //    TTIP.Show("NOT VALID BILL OR ITEM ARE DELETED\nبل نمبرصحیح نہیں ہے", txtbBcode, 20, 20, 5000);
                //    txtbMessage.Text = "NOT VALID ARE DELETED\nبل نمبرصحیح نہیں ہے";
                //    txtbMessage.BackColor = Color.Red;
                //    ready_to_settle = false;
                //    txtbTICKETNO.Text = a.key.ToString();
                //    reset_with_Message();
                //    return;
                //}
                ////
                //if (AL.isSettle(a.app_code, a.key, bid) == true)
                //{
                //    TTIP.Show("ALREADY SETTLE\nبل سیٹل ہوجکا ہے", txtbBcode, 10, 10, 3000);
                //    txtbMessage.Text = "ALREADY SETTLE\nبل سیٹل ہوجکا ہے";
                //    txtbMessage.BackColor = Color.Red;

                //    this.rES_FETCHTICKET_TA.Fill(this.eSITERPDataSet._RES_FETCHTICKET_DT, Convert.ToString(a.key));
                    
                //    foundsettle();
                //    ready_to_settle = false;
                //    txtbTOT.Text = Convert.ToString(AL.bill_tot(a.app_code, a.key, bid));
                //    txtbTICKETNO.Text = "Ticket No: " + a.key.ToString();
                //    return;
                //}
                //this.rES_FETCHTICKET_TA.Fill(this.eSITERPDataSet._RES_FETCHTICKET_DT, Convert.ToString(a.key));
                //// GET KEY INFO'S
                ///// GET TICKET_ID
                //ticket_id = AL.getTID(a.app_code, a.key, bid);
                //acc_doc_id = AL.getACC_DOC_ID(a.app_code, a.key, bid);
                //entity_id = AL.getEntityId(a.app_code, a.key, bid);
                //IsLocked = AL.isLocked(a.app_code, a.key, bid);
                ///// GET TICKET LOCKED STATUS
                ///// GET ACC_DOC_ID
                ///// GET ENTITY_ID
                //// GET KEY INFO'S

                //txtbTOT.Text = Convert.ToString(AL.bill_tot(a.app_code, a.key, bid));
                //txtbTICKETNO.Text = "Ticket No: " + ticket_id.ToString();
                //txtbMessage.Text = "NOT SETTLED YET ابھی تک سٹل نہیں ہوا";
                //txtbMessage.BackColor = Color.Yellow;
                //ready_to_settle = true;
                //ready();
                txtbMessage.Text = "Fastfood bill not init yet. Pls consult IT Head";
                reset_with_Message();
            }
            else
            {
                MessageBox.Show("Invalid barcode. Pls Restart Application.");this.Close();
            }
        }

        private void SETTLE_NOW()
        {
            AL.SETTLENOW(bid, ticket_no, ticket_id, acc_doc_id, entity_id);
            reset();
        }

    }
}