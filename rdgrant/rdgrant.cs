using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AppLogic;


namespace rdgrant
{
    public class rdgrant
    {
        protected string cs = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
        protected bool validuser = false;
        
        public bool userlogin(AuthUser usr)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select TOP 1 * from users where isActive=1 AND userid='" + usr.userid + "' AND user_pass='" + usr.userpass + "'", con);
            con.Open();
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i > 0)
            {
                validuser = true;
            }
            else validuser = false;
            con.Close();
            return validuser;
        }
        protected int uid = 0;
        public int useridpostback(AuthUser usr)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select TOP 1 id from users where isActive=1 AND userid='" + usr.userid + "' AND user_pass='" + usr.userpass + "'", con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                uid = (Int32)rdr["id"];
            }
            con.Close();
            return uid;
        }

        protected string uname;
        public string getUname(int uid)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SELECT userid FROM USERS WHERE id="+uid, con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                uname = (string)rdr["userid"];
            }
            con.Close();
            return uname;
        }

        public string getUID(int uid, int get_bid, string what = null)
        {
            if (what != null & what == "LSTAPP")
            {
                this.getapp(uid, get_bid);
            }
            return sqlres;
        }



        protected string orgname = ""; // getbentitydet

        public string getbentitydet(int uid)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            cmd = new SqlCommand("select be.id AS BID,be.entity_name as ENAME from users USR INNER JOIN user_groups UG ON usr.gid=UG.id INNER JOIN group_details UD ON UD.gid=UG.id INNER JOIN b_entity BE ON BE.id=UD.b_entity_id WHERE USR.id=" + uid + " GROUP BY be.id,be.entity_name", con);
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                orgname += rdr.GetInt32(0) + "|" + rdr.GetString(1) + "^";
            }
            con.Close();
            return orgname;
        }

        protected int orgid = 0;
        public int getbentityid(int uid)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            cmd = new SqlCommand("select be.id AS BID from users USR INNER JOIN user_groups UG ON usr.gid=UG.id INNER JOIN b_entity BE ON BE.id=UG.b_entity_id WHERE USR.id=" + uid + " GROUP BY be.id", con);
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            {
                orgid = (int)rdr["BID"];
            }
            con.Close();
            return orgid;
        }

        string sqlres = "";
        protected string getapp(int uid, int get_bid) // GET LIST OF APP ALLOWED TO FOLLOWING USER
        {
            //string ret = "";
            SqlConnection conapp = new SqlConnection(cs);
            SqlCommand cmdapp = new SqlCommand("select AP.id AS APPID,MOD.module AS MODULE,AP.app_name AS APPNAME,AP.app_url AS APPURL,AP.app_ver AS APPVER,UA.id AS ActionId from apps AP " +
"INNER JOIN group_details GD ON ap.id = GD.app_id " +
"INNER JOIN users_action UA ON UA.ID = GD.action_id " +
"INNER JOIN user_groups UG ON UG.id = GD.gid " +
"INNER JOIN users USR ON USR.gid = GD.gid INNER JOIN appmodule MOD on MOD.id = AP.amid where USR.id =" + Convert.ToInt32(uid) + " AND GD.b_entity_id=" + get_bid, conapp);
            SqlDataReader rdrapp = null;
            conapp.Open();
            rdrapp = cmdapp.ExecuteReader();
            //int i = Convert.ToInt32(cmdapp.ExecuteScalar());
            //if (i > 0)
            while (rdrapp.Read() == true)
            {
                sqlres += rdrapp.GetInt32(0) + "|" + rdrapp.GetString(1) + "|" + rdrapp.GetString(2) + "|" + rdrapp.GetString(3) + "|" + rdrapp.GetString(4) + "|" + rdrapp.GetInt32(5) + "^";
            }
            conapp.Close();

            return sqlres;
        }

        protected bool isallowed = false;
        public bool isAllowed(Int32 uid, Int32 appid)
        {
            SqlConnection conchk = new SqlConnection(cs);
            SqlCommand cmdchk = new SqlCommand("select * from apps AP " +
"INNER JOIN group_details GD ON ap.id = GD.app_id " +
"INNER JOIN users_action UA ON UA.ID = GD.action_id " +
"INNER JOIN user_groups UG ON UG.id = GD.gid " +
"INNER JOIN users USR ON USR.gid = GD.gid " +
"INNER JOIN appmodule MOD on MOD.id = AP.amid " +
"where USR.id = " + uid + " AND AP.id=" + appid, conchk);
            conchk.Open();
            int i = Convert.ToInt32(cmdchk.ExecuteScalar());
            if (i > 0)
                isallowed = true;
            else isallowed = false;

            return isallowed;
        }

        public int getActionId(Int32 uid, int appid)
        {
            SqlConnection conchk = new SqlConnection(cs);
            SqlCommand cmdchk = new SqlCommand("select UA.id AS ACTIONID from apps AP " +
"INNER JOIN group_details GD ON ap.id = GD.app_id " +
"INNER JOIN users_action UA ON UA.ID = GD.action_id " +
"INNER JOIN user_groups UG ON UG.id = GD.gid " +
"INNER JOIN users USR ON USR.gid = GD.gid " +
"INNER JOIN appmodule MOD on MOD.id = AP.amid " +
"where USR.id = " + uid + " AND AP.id=" + appid, conchk);
            SqlDataReader rdr = null;
            int i = 0;
            conchk.Open();
            rdr = cmdchk.ExecuteReader();
            if (rdr.Read() == true)
            { i = (Int32)rdr["ACTIONID"]; }
            conchk.Close();
            return i;
        }

    }
}
