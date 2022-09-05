using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace APPDESK
{
    public class getRestaurantTicket
    {
        protected string cs = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=ESITERP;integrated security=True;Max Pool Size=50000";
        protected string cs_R = @"data source=ABSERVER\SQLEXPRESS;initial catalog=SambaPOS3_RES;integrated security=True;Max Pool Size=50000";
        protected string cs_FS = @"data source=ABFASTFOOD\SQLEXPRESS;initial catalog=SambaPOS3;integrated security=True;Max Pool Size=50000";

        public int getStartTicket(int get_bid)
        {
           // string ocode = get_bid == 1 ? "FF" : "RES";
            int ret = 0;
            if (get_bid == 1)
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("select top 1 RESTAURANT_PURCHASE from numerator", con);
                SqlDataReader rdr = null;
                con.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.Read()==true)
                {
                    ret = (Int32)rdr["RESTAURANT_PURCHASE"];
                }
                con.Close();
            }
            else if (get_bid == 2)
            {
                // Extream logic failed :)
            }
            return ret;
        }

        public int getEndTicket(int get_bid)
        {
            int i = 0;
            if (Convert.ToInt16(get_bid)==1)
            {
                SqlConnection con = new SqlConnection(cs_FS);
                SqlCommand cmd = new SqlCommand("select TOP 1 T.id as id,T.TicketNumber as tno from Tickets T INNER JOIN Orders O ON O.TicketId=T.Id order by T.id desc", con);
                SqlDataReader rdr = null;
                try
                {
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() == true)
                    {
                        i = Convert.ToInt32((string)rdr["tno"]);
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
