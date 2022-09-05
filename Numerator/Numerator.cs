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
        protected string cs = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
        protected int grncount =0;
        protected int pincount = 0;
        protected int vpcount = 0;
        protected int store_doc_count = 0;
        protected int wippcount =0;

        public int wip_production_docid()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            wip_production_docid_plus();
            cmd = new SqlCommand("select top 1 wip_production_docid from numerator", con);
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            {
                wippcount = (int)rdr["wip_production_docid"];
            }
            con.Close();
            return wippcount;
        }

        protected void wip_production_docid_plus()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            cmd = new SqlCommand("update numerator set wip_production_docid=wip_production_docid+1", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

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

        protected void grnplus()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            cmd = new SqlCommand("update numerator set grn=grn+1", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int pinno()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            pinnplus();
            cmd = new SqlCommand("select top 1 pinno from numerator", con);
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            {
                pincount = (int)rdr["pinno"];
            }
            con.Close();
            return pincount;
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


        protected void pinnplus()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            cmd = new SqlCommand("update numerator set pinno=pinno+1", con);
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

        int transfer_count = 0;
        public int shop_transfer_no()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            shop_transfer_no_plus();
            cmd = new SqlCommand("select top 1 shop_data_transfer_no from numerator", con);
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            {
                transfer_count = (int)rdr["shop_data_transfer_no"];
            }
            con.Close();
            return transfer_count;
        }

        protected void shop_transfer_no_plus()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            cmd = new SqlCommand("update numerator set shop_data_transfer_no=shop_data_transfer_no+1", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int restaurant_transfer_no()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            restaurant_transfer_no_plus();
            cmd = new SqlCommand("select top 1 restaurant_data_transfer_no from numerator", con);
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            {
                transfer_count = (int)rdr["restaurant_data_transfer_no"];
            }
            con.Close();
            return transfer_count;
        }

        protected void restaurant_transfer_no_plus()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            cmd = new SqlCommand("update numerator set restaurant_data_transfer_no=restaurant_data_transfer_no+1", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int fastfood_transfer_no()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            fastfood_transfer_no_plus();
            cmd = new SqlCommand("select top 1 fastfood_data_transfer_no from numerator", con);
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            {
                transfer_count = (int)rdr["fastfood_data_transfer_no"];
            }
            con.Close();
            return transfer_count;
        }

        protected void fastfood_transfer_no_plus()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            cmd = new SqlCommand("update numerator set fastfood_data_transfer_no=fastfood_data_transfer_no+1", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
