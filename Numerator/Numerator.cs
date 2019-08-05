using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Numerator
{

    public class Numerator
    {
        protected string cs = @"data source=SHARIQ-PC\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
        protected int grncount =0;
        protected int vpcount = 0;
        protected int store_doc_count = 0;
        public int grnno()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            grnplus();
            cmd = new SqlCommand("select top 1 grn from numerator", con);
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            {
                grncount = (int)rdr["grn"];
            }
            con.Close();
            return grncount;
        }

        public int vpno()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            vpnoplus();
            cmd = new SqlCommand("select top 1 ven_pay_no from numerator", con);
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            {
                vpcount = (int)rdr["ven_pay_no"];
            }
            con.Close();
            return vpcount;
        }

        public int store_doc_id()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            store_doc_plus();
            cmd = new SqlCommand("select top 1 store_doc_id from numerator", con);
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            {
                store_doc_count = (int)rdr["store_doc_id"];
            }
            con.Close();
            return store_doc_count;
        }

        protected void grnplus()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            cmd = new SqlCommand("update numerator set grn=grn+1", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void vpnoplus()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            cmd = new SqlCommand("update numerator set ven_pay_no=ven_pay_no+1", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void store_doc_plus()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            cmd = new SqlCommand("update numerator set store_doc_id=store_doc_id+1", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
