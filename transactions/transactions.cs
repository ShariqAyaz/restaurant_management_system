using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLogic;
using System.Data.SqlClient;
using Numerator;

namespace transactions
{
    public class transactions
    {
        protected string cs = @"data source=SHARIQ-PC\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
        protected LoadGRN lgrn = new LoadGRN();
        protected GRN_ITEMS[] grnItems = null;// new GRN_ITEMS[ii];
        Numerator.Numerator num = new Numerator.Numerator();
        public AppLogic.LoadGRN chkgrn(int grnno)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from grn_note where grn_no=" + grnno, con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                lgrn.grn_no = (Int32)rdr["grn_no"];
                lgrn.vendor_id = (Int32)rdr["vendor_id"];
                lgrn.uid = (Int32)rdr["uid"];
                lgrn.GRDate = (DateTime)rdr["GRDate"];
                lgrn.b_entity_id = (Int32)rdr["b_entity_id"];
                lgrn.supplier_invoice = (string)rdr["supplier_invoice"];
                lgrn.remarks = (string)rdr["remarks"];
                lgrn.isPosted = (Int32)rdr["isPosted"] == 0 ? false : true;
                // // //int val = insGN.isPosted == false ? 0 : 1;
            }
            con.Close();
            return lgrn;
        }

        bool isInserted = false;
        public bool insertGRNNote(LoadGRN insGN)
        {
            int val = insGN.isPosted == false ? 0 : 1;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("insert into grn_note(grn_no,supplier_invoice,vendor_id,GRDate,uid,b_entity_id,remarks,isPosted) values(" + insGN.grn_no + ",'" + insGN.supplier_invoice + "'," + insGN.vendor_id + ",'" + insGN.GRDate + "'," + insGN.uid + "," + insGN.b_entity_id + ",'" + insGN.remarks + "'," + val + ")", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                isInserted = true;
            }
            catch (Exception ex)
            {
                con.Close();
                isInserted = false;
                throw ex;
            }
            return isInserted;
        }

        bool VPInserted = false;
        public bool insertVPay(Vendor_payment insVP)
        {
            int val = insVP.isPosted == false ? 0 : 1;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("insert into vendor_payment_doc(vpno,vendor_id,vDate,cr_acc_id,uid,b_entity_id,dr_amount,remarks,isPosted) values(" + insVP.vpno + ",'" + insVP.vendor_id + "','" + insVP.vDate + "',"+insVP.cr_acc_id+"," + insVP.uid + "," + insVP.b_entity_id + ","+insVP.dramt + ",'" + insVP.remarks + "','"+ val+"')", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                VPInserted = true;
            }
            catch (Exception ex)
            {
                con.Close();
                VPInserted = false;
                throw ex;
            }
            return VPInserted;
        }

        public void chkGRN(string grnno)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            cmd = new SqlCommand("select grn_no from grn_items_det where grn_no='" + grnno + "'", con);
            con.Open();
            int ii = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
        }

        public AppLogic.GRN_ITEMS[] returnItems(string p_gno)
        {
            chkGRN(p_gno);
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select GD.id AS LID,IM.ibarcode AS IBCODE,IM.iname AS INAME,GD.iid AS IID,GD.irate AS IRATE,GD.iqty AS IQTY,(GD.irate*GD.iqty) AS IAMT from grn_items_det GD INNER JOIN item_mast IM ON IM.id=GD.iid where GD.grn_no='" + p_gno + "'", con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            var list = new List<GRN_ITEMS>();
            while (rdr.Read() == true)
            {
                list.Add(new GRN_ITEMS
                {
                    LID = (int)rdr["LID"],
                    ITEMBARCODE = (string)rdr["IBCODE"],
                    ITEMNAME = (string)rdr["INAME"],
                    IID = (Int32)rdr["IID"],
                    IRATE = (decimal)rdr["IRATE"],
                    IQTY = (decimal)rdr["IQTY"],
                    IAMT = (decimal)rdr["IAMT"]
                });
            }
            grnItems = list.ToArray();

            return grnItems;
        }

        private bool isPosted = false;
        public bool isAlreadyPosted(string p_gno)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SELECT isPosted from grn_note where grn_no='" + p_gno + "'", con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                int i = (int)rdr["isPosted"];
                isPosted = i == 0 ? false : true;// ? false;
            }
            con.Close();
            return isPosted;
        }

        public void postVendorPayment(string tno, int uid,int bid)
        {
            vendor_transaction(tno, "VENPAYMENT", uid, bid);
            vendor_account_transaction_vpay(tno, uid, bid);
        }

        public void postGRN(string p_gno, int uid, int bid)
        {
            // VENDER TRANSACTION POSTING
            vendor_transaction(p_gno, "GRNPOST", uid, bid);
            vendor_account_transaction_grn(p_gno, uid, bid);
            storeIncrease(p_gno, "GRNPOST", uid, bid);
            postgrnnow(p_gno);
        }

        protected void postgrnnow(string gno)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("update grn_note set isPosted=1 where grn_no=" + gno, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void vendor_transaction(string tno, string ttype, int uid, int bid)
        {
            if (ttype == "GRNPOST")
            {
                if (haveExp(tno) == true)
                {
                    SqlConnection con = new SqlConnection(cs);
                    SqlCommand cmd = new SqlCommand("insert into vendor_transactions(ven_id,ttype,tdate,ref_doc_no,dr,cr,remarks,b_entity_id,uid) values((select vendor_id from grn_note where grn_no=" + tno + "),'" + ttype + "',(SELECT GRDate from grn_note where grn_no=" + tno + ")," + tno + ",0,((SELECT SUM(irate*iqty) from grn_items_det where grn_no=" + tno + ")+(SELECT exp_amt from grn_expense_det where grn_no=" + tno + ")),''," + bid + "," + uid + ")", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    SqlConnection con = new SqlConnection(cs);
                    SqlCommand cmd = new SqlCommand("insert into vendor_transactions(ven_id,ttype,tdate,ref_doc_no,dr,cr,remarks,uid,b_entity_id) values((select vendor_id from grn_note where grn_no=" + tno + "),'" + ttype + "',(SELECT GRDate from grn_note where grn_no=" + tno + ")," + tno + ",0,(SELECT SUM(irate*iqty) from grn_items_det where grn_no=" + tno + "),''," + uid + "," + bid + ")", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            else if (ttype == "VENPAYMENT")
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("insert into vendor_transactions(ven_id,ttype,tdate,ref_doc_no,dr,cr,remarks,b_entity_id,uid) values((select vendor_id from vendor_payment_doc where vpno=" + tno + "),'" + ttype + "',(SELECT vDate from vendor_payment_doc where vpno=" + tno + ")," + tno + ",(SELECT dr_amount from vendor_payment_doc where vpno=" + tno + "),0,'rem'," + bid + "," + uid + ")", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        int store_doc_id = 0;
        protected void storeIncrease(string tno, string ttype, int uid, int bid)
        {
            store_doc_id = num.store_doc_id();
            if (ttype == "GRNPOST")
            {
                // STORE HEAD
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("INSERT INTO store(doc_id,ref_doc_no,doc_type_id,doc_date,uid,remarks,b_entity_id) values(" + store_doc_id + ", " + tno + ",1,(SELECT GRDate from grn_note where grn_no=" + tno + ")," + uid + ",'REM'," + bid + ")", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                // STORE DET
                SqlConnection conItems = new SqlConnection(cs);
                SqlCommand cmdItems = new SqlCommand("select iid,iqty from grn_items_det where grn_no=" + tno + "", conItems);
                SqlDataReader rdrItems = null;
                conItems.Open();
                rdrItems = cmdItems.ExecuteReader();
                while (rdrItems.Read() == true)
                {
                    SqlConnection conStore = new SqlConnection(cs);
                    SqlCommand cmdStore = new SqlCommand("INSERT INTO store_det(doc_id,iid,increase_qty,decrease_qty,whid) values(" + store_doc_id + "," + (int)rdrItems["iid"] + "," + (decimal)rdrItems["iqty"] + ",0,(select default_wh from item_mast where id=" + (int)rdrItems["iid"] + "))", conStore);
                    conStore.Open();
                    cmdStore.ExecuteNonQuery();
                    conStore.Close();
                }
            }
        }

        protected void vendor_account_transaction_grn(string tno, int uid, int bid)
        {
            ///\\\ TRANSACTION OF DEBIT ///\\\
            if (haveExp(tno) == true)
            {
                // debit 1 // account expense
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("insert into account_transactions(account_id,transaction_date,ref_doc_no,description,cr,dr,b_entity_id) values((select DTC.dr_account_id from documents_types_components DTC INNER JOIN documents_types DT ON DT.id=DTC.doc_type_id WHERE DTC.doc_type_id=1 AND DTC.baseAccount='false'),(select GRDate from grn_note where grn_no=" + tno + ")," + tno + ",'',0,(select exp_amt from grn_expense_det where grn_no=" + tno + ")," + bid + ")", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            // debit 2 // inventory account
            SqlConnection conAcc = new SqlConnection(cs);
            SqlCommand cmdAcc = new SqlCommand("select IM.account_id AS ACCID from grn_items_det GI INNER JOIN item_mast IM ON GI.iid = IM.id where GI.grn_no ="+tno+" group by IM.account_id", conAcc);
            conAcc.Open();
            SqlDataReader rdrAcc = cmdAcc.ExecuteReader();
            while (rdrAcc.Read() == true)
            {
                SqlConnection con1 = new SqlConnection(cs);
                SqlCommand cmd1 = new SqlCommand("insert into account_transactions(account_id,transaction_date,ref_doc_no,description,cr,dr,b_entity_id) values(" + (int)rdrAcc["ACCID"]+",(select GRDate from grn_note where grn_no=" + tno + ")," + tno + ",'',0,(SELECT SUM(GDET.irate*GDET.iqty) from grn_items_det GDET INNER JOIN item_mast IM ON IM.id=GDET.iid where GDET.grn_no="+tno+" AND IM.account_id=" + (int)rdrAcc["ACCID"] + ")," + bid + ")", con1);
                con1.Open();
                cmd1.ExecuteNonQuery();
                con1.Close();
            }
            conAcc.Close();
            // // // // // 
            // TRANSACTION OF CREDIT
            if (haveExp(tno) == true)
            {
                SqlConnection con2 = new SqlConnection(cs);
                SqlCommand cmd2 = new SqlCommand("insert into account_transactions(account_id,transaction_date,ref_doc_no,description,cr,dr,b_entity_id) values(2,(select GRDate from grn_note where grn_no=" + tno + ")," + tno + ",'',((SELECT SUM(irate*iqty) from grn_items_det where grn_no=" + tno + ")+(SELECT exp_amt from grn_expense_det where grn_no=" + tno + ")),0," + bid + ")", con2);
                con2.Open();
                cmd2.ExecuteNonQuery();
                con2.Close();
            }
            else
            {
                SqlConnection con2 = new SqlConnection(cs);
                SqlCommand cmd2 = new SqlCommand("insert into account_transactions(account_id,transaction_date,ref_doc_no,description,cr,dr,b_entity_id) values(2,(select GRDate from grn_note where grn_no=" + tno + ")," + tno + ",'',(SELECT SUM(irate*iqty) from grn_items_det where grn_no=" + tno + "),0," + bid + ")", con2);
                con2.Open();
                cmd2.ExecuteNonQuery();
                con2.Close();
            }
            // payable credit
        }

        protected void vendor_account_transaction_vpay(string tno, int uid, int bid)
        {
            // CR
            SqlConnection con2 = new SqlConnection(cs);
            SqlCommand cmd2 = new SqlCommand("insert into account_transactions(account_id,transaction_date,ref_doc_no,description,cr,dr,b_entity_id) values((SELECT cr_acc_id from vendor_payment_doc where vpno=" + tno+ "),(select vDate from vendor_payment_doc where vpno=" + tno + ")," + tno + ",'',(SELECT dr_amount from vendor_payment_doc where vpno=" + tno + "),0," + bid + ")", con2);
            con2.Open();
            cmd2.ExecuteNonQuery();
            con2.Close();
            // DR
            SqlConnection con3 = new SqlConnection(cs);
            SqlCommand cmd3 = new SqlCommand("insert into account_transactions(account_id,transaction_date,ref_doc_no,description,cr,dr,b_entity_id) values(2,(select vDate from vendor_payment_doc where vpno=" + tno + ")," + tno + ",'',0,(SELECT dr_amount from vendor_payment_doc where vpno=" + tno + ")," + bid + ")", con3);
            con3.Open();
            cmd3.ExecuteNonQuery();
            con3.Close();
        }

        bool haveexp = false;
        protected bool haveExp(string tno)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select * from grn_expense_det where grn_no=" + tno, con);
            con.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            haveexp = i == 0 ? false : true;
            con.Close();
            return haveexp;
        }
    }
}