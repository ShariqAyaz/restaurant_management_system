using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Appdesc_Logic
{
    public class Appdesc_Logic
    {
        protected string cs = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=ESITERP;integrated security=True;Max Pool Size=50000";
        protected string cs_R = @"data source=ABSERVER2\SQLEXPRESS;initial catalog=OCCOTOPOS3_RES;integrated security=True;Max Pool Size=50000";
        protected string cs_FS = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=OCCOTOPOS3;integrated security=True;Max Pool Size=50000";
        //
        protected bool active_ticket = false;
        protected bool ticketSettle = false;
        protected decimal get_bill_tot = 0;
        protected int get_getTID = 0;
        protected int get_getACC_DOC_ID = 0;
        protected int get_getEntityId = 0;
        //
        public bool isExist(string app, int key, int org)
        {
            if (app == "A")
            {
                if (org == 2)
                {
                    SqlConnection con = new SqlConnection(cs_R);
                    SqlCommand cmd = new SqlCommand("select T.Id from Tickets T INNER JOIN Orders O ON T.Id = O.TicketId INNER JOIN TicketEntities TE ON T.id = TE.Ticket_Id where TicketNumber = " + key + " AND O.OrderStates NOT LIKE '%void%'", con);
                    con.Open();
                    int i = Convert.ToInt32(cmd.ExecuteScalar());
                    if (i > 0) active_ticket = true;
                    else active_ticket = false;
                    con.Close();
                }
            }
            else if (app == "B")
            {
                if (org == 1)
                {
                    SqlConnection con = new SqlConnection(cs_FS);
                    SqlCommand cmd = new SqlCommand("select T.Id from Tickets T INNER JOIN Orders O ON T.Id = O.TicketId INNER JOIN TicketEntities TE ON T.id = TE.Ticket_Id where TicketNumber = " + key + " AND O.OrderStates NOT LIKE '%void%'", con);
                    con.Open();
                    int i = Convert.ToInt32(cmd.ExecuteScalar());
                    if (i > 0) active_ticket = true;
                    else active_ticket = false;
                    con.Close();
                }
            }
            return active_ticket;
        }

        public bool isSettle(string app, int key, int org)
        {
            if (app == "A")
            {
                if (org == 2)
                {
                    SqlConnection con = new SqlConnection(cs_R);
                    SqlCommand cmd = new SqlCommand("select T.IsClosed from Tickets T WHERE TicketNumber=" + key, con);
                    con.Open();
                    int i = Convert.ToInt32(cmd.ExecuteScalar());
                    if (i > 0) ticketSettle = true;
                    else ticketSettle = false;
                    con.Close();
                }
            }
            else if (app == "B")
            {
                if (org == 1)
                {
                    SqlConnection con = new SqlConnection(cs_FS);
                    SqlCommand cmd = new SqlCommand("select T.IsClosed from Tickets T WHERE TicketNumber=" + key, con);
                    con.Open();
                    int i = Convert.ToInt32(cmd.ExecuteScalar());
                    if (i > 0) ticketSettle = true;
                    else ticketSettle = false;
                    con.Close();
                }
            }
            return ticketSettle;
        }

        public decimal bill_tot(string app, int key, int org)
        {
            if (org == 2)
            {
                SqlConnection con = new SqlConnection(cs_R);
                SqlCommand cmd = new SqlCommand("select TotalAmount from Tickets WHERE TicketNumber=" + key, con);
                con.Open();
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    get_bill_tot = (decimal)rdr["TotalAmount"];
                }
                con.Close();
            }
            else if (org == 1)
            {
                SqlConnection con = new SqlConnection(cs_FS);
                SqlCommand cmd = new SqlCommand("select TotalAmount from Tickets WHERE TicketNumber=" + key, con);
                con.Open();
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    get_bill_tot = (decimal)rdr["TotalAmount"];
                }
                con.Close();
            }
            return get_bill_tot;
        }

        public int getTID(string app, int key, int org)
        {
            if (org == 2)
            {
                SqlConnection con = new SqlConnection(cs_R);
                SqlCommand cmd = new SqlCommand("select id from Tickets WHERE TicketNumber=" + key, con);
                con.Open();
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    get_getTID = (int)rdr["id"];
                }
                con.Close();
            }
            else if (org == 1)
            {
                SqlConnection con = new SqlConnection(cs_FS);
                SqlCommand cmd = new SqlCommand("select id from Tickets WHERE TicketNumber=" + key, con);
                con.Open();
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    get_getTID = (int)rdr["id"];
                }
                con.Close();
            }
            return get_getTID;
        }

        public int getACC_DOC_ID(string app, int key, int org)
        {
            if (org == 2)
            {
                SqlConnection con = new SqlConnection(cs_R);
                SqlCommand cmd = new SqlCommand("select TransactionDocument_id from Tickets WHERE TicketNumber=" + key, con);
                con.Open();
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    get_getACC_DOC_ID = (int)rdr["TransactionDocument_id"];
                }
                con.Close();
            }
            else if (org == 1)
            {
                SqlConnection con = new SqlConnection(cs_FS);
                SqlCommand cmd = new SqlCommand("select TransactionDocument_id from Tickets WHERE TicketNumber=" + key, con);
                con.Open();
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    get_getACC_DOC_ID = (int)rdr["TransactionDocument_id"];
                }
                con.Close();
            }
            return get_getACC_DOC_ID;
        }


        public int getEntityId(string app, int key, int org)
        {
            if (org == 2)
            {
                SqlConnection con = new SqlConnection(cs_R);
                SqlCommand cmd = new SqlCommand("select TicketEntities.EntityId as EID from Tickets INNER JOIN TicketEntities ON TicketEntities.Ticket_Id=Tickets.Id  where TicketNumber=" + key, con);
                con.Open();
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    get_getEntityId = (int)rdr["EID"];
                }
                con.Close();
            }
            else if (org == 1)
            {
                SqlConnection con = new SqlConnection(cs_FS);
                SqlCommand cmd = new SqlCommand("select TicketEntities.EntityId as EID from Tickets INNER JOIN TicketEntities ON TicketEntities.Ticket_Id=Tickets.Id  where TicketNumber=" + key, con);
                con.Open();
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    get_getEntityId = (int)rdr["EID"];
                }
                con.Close();
            }
            return get_getEntityId;
        }

        bool isLocked_T = false;
        public bool isLocked(string app, int key, int org)
        {
            if (app == "A")
            {
                if (org == 2)
                {
                    SqlConnection con = new SqlConnection(cs_R);
                    SqlCommand cmd = new SqlCommand("select T.IsLocked IsLocked from Tickets T INNER JOIN Orders O ON T.Id = O.TicketId INNER JOIN TicketEntities TE ON T.id = TE.Ticket_Id where TicketNumber = " + key + " AND O.OrderStates NOT LIKE '%void%'", con);
                    con.Open();
                    SqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() == true)
                    {
                        isLocked_T = (bool)rdr["IsLocked"];
                    }
                    con.Close();
                }
                else if (org == 1)
                {
                    SqlConnection con = new SqlConnection(cs_FS);
                    SqlCommand cmd = new SqlCommand("select T.IsLocked IsLocked from Tickets T INNER JOIN Orders O ON T.Id = O.TicketId INNER JOIN TicketEntities TE ON T.id = TE.Ticket_Id where TicketNumber = " + key + " AND O.OrderStates NOT LIKE '%void%'", con);
                    con.Open();
                    SqlDataReader rdr = null;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() == true)
                    {
                        isLocked_T = (bool)rdr["IsLocked"];
                    }
                    con.Close();
                }
            }
            return isLocked_T;
        }

        public decimal get_bill_tot_amt(int org, int tno)
        {
            if (org == 2)
            {
                SqlConnection con = new SqlConnection(cs_R);
                SqlCommand cmd = new SqlCommand("select TotalAmount from Tickets WHERE TicketNumber=" + tno, con);
                con.Open();
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    get_bill_tot = (decimal)rdr["TotalAmount"];
                }
                con.Close();
            }
            else if (org == 1)
            {
                SqlConnection con = new SqlConnection(cs_FS);
                SqlCommand cmd = new SqlCommand("select TotalAmount from Tickets WHERE TicketNumber=" + tno, con);
                con.Open();
                SqlDataReader rdr = null;
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    get_bill_tot = (decimal)rdr["TotalAmount"];
                }
                con.Close();
            }
            return get_bill_tot;
        }

        public void SETTLENOW(int bid, int ticket_no, int ticket_id, int acc_doc_id, int entity_id)
        {
            if (bid == 2)
            {
                decimal gettot = get_bill_tot_amt(bid, ticket_no);
                // UPDATE TICKET
                SqlConnection con = new SqlConnection(cs_R);
                SqlCommand cmd = new SqlCommand("update Tickets set RemainingAmount=0 , TicketStates=REPLACE(TicketStates,'Unpaid','Paid') , IsClosed=1 , isLocked=1 where TicketNumber=" + ticket_no, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //
                // insert account transaction
                SqlConnection con1 = new SqlConnection(cs_R);
                SqlCommand cmd1 = new SqlCommand("insert into AccountTransactions([AccountTransactionDocumentId],[Amount],[ExchangeRate],[AccountTransactionTypeId],[SourceAccountTypeId],[TargetAccountTypeId],[IsReversed],[Reversable],[Name]) values(" + acc_doc_id + "," + gettot + ",1.00,4,1,3,0,1,'Payment Transaction [Cash]')", con1);
                con1.Open();
                cmd1.ExecuteNonQuery();
                con1.Close();
                //
                // update entitystates
                SqlConnection con2 = new SqlConnection(cs_R);
                SqlCommand cmd2 = new SqlCommand("update EntityStateValues set EntityStates=REPLACE(EntityStates,'New Orders','Available') where EntityId=" + entity_id, con2);
                con2.Open();
                cmd2.ExecuteNonQuery();
                con2.Close();
                //
                SqlConnection con3 = new SqlConnection(cs_R);
                SqlCommand cmd3 = new SqlCommand("update EntityStateValues set EntityStates=REPLACE(EntityStates,'Bill Requested','Available') where EntityId=" + entity_id, con3);
                con3.Open();
                cmd3.ExecuteNonQuery();
                con3.Close();
            }
            else if (bid == 1)
            {

            }
        }

    }
}
