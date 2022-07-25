﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace APPDESK
{
    public class getOrderNumberKMS
    {
        protected string cs = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=ESITERP;integrated security=True;Max Pool Size=50000";
        protected string cs_R = @"data source=ABSERVER2\SQLEXPRESS;initial catalog=OCCOTOPOS3_RES;integrated security=True;Max Pool Size=50000";
        protected string cs_FS = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=OCCOTOPOS3;integrated security=True;Max Pool Size=50000";

        public int getStartOrderNumber(int get_bid)
        {
           // string ocode = get_bid == 1 ? "FF" : "RES";
            int ret = 0;
            if (get_bid == 2)
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("select top 1 RES_KMS_RESTAURANT_LASTORDER from numerator", con);
                SqlDataReader rdr = null;
                con.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.Read()==true)
                {
                    ret = (Int32)rdr["RES_KMS_RESTAURANT_LASTORDER"];
                }
                con.Close();
            }
            else if (get_bid == 1)
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("select top 1 FF_KMS_RESTAURANT_LASTORDER from numerator", con);
                SqlDataReader rdr = null;
                con.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    ret = (Int32)rdr["FF_KMS_RESTAURANT_LASTORDER"];
                }
                con.Close();
            }
            return ret;
        }

        public int getEndOrderNumber(int get_bid)
        {
            int i = 0;
            if (Convert.ToInt16(get_bid)==2)
            {
                SqlConnection con = new SqlConnection(cs_R);
                SqlCommand cmd = new SqlCommand("select TOP 1 T.id as id,O.OrderNumber as tno from Tickets T INNER JOIN Orders O ON O.TicketId=T.Id order by O.OrderNumber desc", con);
                SqlDataReader rdr = null;
                try
                {
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() == true)
                    {
                        i = Convert.ToInt32((int)rdr["tno"]);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    con.Close();
                }
            }
            else if (get_bid==1)
            {
                SqlConnection con = new SqlConnection(cs_FS);
                SqlCommand cmd = new SqlCommand("select TOP 1 T.id as id,CAST(O.OrderNumber as int) as tno from Tickets T INNER JOIN Orders O ON O.TicketId=T.Id order by O.OrderNumber desc", con);
                SqlDataReader rdr = null;
                try
                {
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() == true)
                    {
                        i = Convert.ToInt32((int)rdr["tno"]);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    con.Close();
                }
            }
            
            return i;
        }
    }
}
