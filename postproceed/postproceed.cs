using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AppLogic;

namespace postproceed
{
    public class postproceed
    {
        protected string cs = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=ESITERP;integrated security=True";
        public string repText;
        public bool errTrue = false;
        protected ModWarehouse appl = new ModWarehouse();
        protected ModDepartment moddept = new ModDepartment();
        protected ModVendor modvendor = new ModVendor();
        protected ModItem applitem = new ModItem();
        public void postmaster(string a, string b)
        {
            a = a.Replace(";", "");
            a = a.Replace("'", "");
            a = a.Replace("/", "");
            a = a.Replace("%", "");
            a = a.Replace("<", "");
            a = a.Replace(">", "");
            a = a.Replace("script", "");
            if (a.Length < 2) return;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = null;
            if (b == "wh_cat")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO wh_cat(cat_desc) values(N'" + a + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    repText = ex.ToString();
                    //repText = ex.ToString();
                }
            }
            else if (b == "wh_type")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO wh_type(type) values(N'" + a + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    repText = ex.ToString();
                }
            }
            else if (b == "wh_location")
            {
                string[] aa = a.Split('|');
                try
                {
                    cmd = new SqlCommand("INSERT INTO wh_location(location,b_entity_id) values(N'" + aa[0] + "'," + aa[1] + ")", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    repText = ex.ToString();
                }
            }
            else if (b == "item_cat")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO main_cat(main_cat) values(N'" + a + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    repText = ex.ToString();
                }
            }
            else if (b == "isub_cat")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO sub_cat(sub_cat) values(N'" + a + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    repText = ex.ToString();
                }
            }
            else if (b == "dept_cat")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO dept_cat(dept_cat) values(N'" + a + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    repText = ex.ToString();
                }
            }
            else if (b == "uom_new")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO UOM(UOM) values(N'" + a + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    repText = ex.ToString();
                }
            }
        }

        #region warehouse master
        public void postmaster_wh(AppLogic.Warehouse WH)
        {
            SqlConnection conWH = new SqlConnection(cs);
            SqlCommand cmdWH = new SqlCommand("INSERT INTO warehouse([wh_name],[wh_desc],[type_id],[location_id],[cat_id],[isActive],[uid],[b_entity_id]) values('" + WH.wh_name + "','" + WH.wh_desc + "'," + WH.type_id + "," + WH.location_id + "," + WH.cat_id + ",'" + WH.isActive + "'," + WH.uid + "," + WH.b_entity_id + ")", conWH);
            try
            {
                conWH.Open();
                cmdWH.ExecuteNonQuery();
                conWH.Close();
                errTrue = false;
            }
            catch (Exception ex)
            {
                conWH.Close();
                repText = ex.ToString();
                errTrue = true;
                //throw;
            }
        }

        public void postmaster_wh_update(AppLogic.Warehouse WH, int get_whid, int get_bid)
        {
            SqlConnection conWH = new SqlConnection(cs);
            SqlCommand cmdWH = new SqlCommand("update warehouse set [wh_desc]='" + WH.wh_desc + "' , [type_id]=" + WH.type_id + " , [location_id]=" + WH.location_id + " , [cat_id]=" + WH.cat_id + " , [uid]=" + WH.uid + " where isActive=1 AND id=" + get_whid + " AND b_entity_id=" + get_bid, conWH);
            try
            {
                conWH.Open();
                cmdWH.ExecuteNonQuery();
                conWH.Close();
                errTrue = false;
            }
            catch (Exception ex)
            {
                conWH.Close();
                repText = ex.ToString();
                errTrue = true;
            }
        }

        public AppLogic.ModWarehouse getwh(string a, int get_bid)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select top 1 wh_name as WHNAME,wh_desc AS WHDESC,type_id AS WHTYPE,cat_id AS CATID,location_id AS LOCID from warehouse where isActive=1 AND id=" + a + " AND b_entity_id=" + get_bid, con);
            SqlDataReader rdr = null;
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                rdr.Read();
                {
                    appl.whname = (string)rdr["WHNAME"];
                    appl.whdesc = (string)rdr["WHDESC"];
                    appl.whtype = (Int32)rdr["WHTYPE"];
                    appl.whcat = (Int32)rdr["CATID"];
                    appl.whloc = (Int32)rdr["LOCID"];
                }
                con.Close();
            }
            catch (Exception)
            {

            }
            return appl;
        }

        public void postmaster_wh_delete(int get_whid, int get_bid)
        {
            SqlConnection conWH = new SqlConnection(cs);
            SqlCommand cmdWH = new SqlCommand("delete warehouse where isActive=1 AND id=" + get_whid + " AND b_entity_id=" + get_bid, conWH);
            try
            {
                conWH.Open();
                cmdWH.ExecuteNonQuery();
                conWH.Close();
                errTrue = false;
            }
            catch (Exception ex)
            {
                conWH.Close();
                repText = ex.ToString();
                errTrue = true;
            }
        }
        #endregion Warehouse Master
        #region Vendor Master
        public void postmaster_vendor(AppLogic.Vendor vendor)
        {
            SqlConnection conVENDOR = new SqlConnection(cs);
            SqlCommand cmdVENDOR = new SqlCommand("INSERT INTO vendor_master(VendorName, Contact_Person_name, Contact_Person_Phone, Address, goods_desc) values('" + vendor.VendorName + "','" + vendor.Contact_Person_name + "','" + vendor.Contact_Person_Phone + "','" + vendor.Address + "','" + vendor.goods_desc + "')", conVENDOR);
            try
            {
                conVENDOR.Open();
                cmdVENDOR.ExecuteNonQuery();
                conVENDOR.Close();
                errTrue = false;
            }
            catch (Exception ex)
            {
                conVENDOR.Close();
                repText = ex.ToString();
                errTrue = true;
                return;
            }
            if (vendor.open_amt > 0)
            {
                SqlConnection conVAMT = new SqlConnection(cs);
                SqlCommand cmdVAMT = new SqlCommand("INSERT INTO account_transactions(account_id,transaction_date,ref_doc_no,description,cr,dr,b_entity_id) VALUES('2','" + Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "',0,'" + "Opening As of " + Convert.ToDateTime(DateTime.Now.ToString("yyyy -MM-dd HH:mm:ss")) + "'," + vendor.open_amt + "," + 0 + ",'" + vendor.b_entity_id + "')", conVAMT);
                try
                {
                    conVAMT.Open();
                    cmdVAMT.ExecuteNonQuery();
                    conVAMT.Close();
                    errTrue = false;
                }
                catch (Exception ex)
                {
                    conVAMT.Close();
                    repText = ex.ToString();
                    errTrue = true;
                    //throw;
                }
                //
                try
                {
                    SqlConnection conCHKVID = new SqlConnection(cs);
                    SqlCommand cmdCHKVID = new SqlCommand("select id from vendor_master where VendorName='"+vendor.VendorName+"'", conCHKVID);
                    conCHKVID.Open();
                    SqlDataReader rdrCHKVID = cmdCHKVID.ExecuteReader();
                    if (rdrCHKVID.Read()==true)
                    {
                        vendor.vid = (int)rdrCHKVID["id"];
                    }
                    conCHKVID.Close();
                    //
                    SqlConnection con = new SqlConnection(cs);
                    SqlCommand cmd = new SqlCommand("insert into vendor_transactions(ven_id,ttype,tdate,ref_doc_no,dr,cr,remarks,uid,b_entity_id) values(" + vendor.vid + ",'OPENING_AMOUNT','" + Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) + "','0',0," + vendor.open_amt + ",'" + "Opening As of " + Convert.ToDateTime(DateTime.Now.ToString("yyyy -MM-dd HH:mm:ss")) + "'," + vendor.uid + "," + vendor.b_entity_id + ")", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    
                }
            }
        }

        public AppLogic.ModVendor getvid(string a)
        {
            SqlConnection conVENDOR = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select * FROM vendor_master where id=" + a, conVENDOR);
            SqlDataReader rdr = null;
            try
            {
                conVENDOR.Open();
                rdr = cmd.ExecuteReader();
                rdr.Read();
                {
                    modvendor.VendorName = (string)rdr["VendorName"];
                    modvendor.Contact_Person_name = (string)rdr["Contact_Person_name"];
                    modvendor.Contact_Person_Phone = (string)rdr["Contact_Person_Phone"];
                    modvendor.Address = (string)rdr["Address"];
                    modvendor.goods_desc = (string)rdr["goods_desc"];
                }
                conVENDOR.Close();
            }
            catch (Exception)
            {

            }
            return modvendor;
        }

        public void postmaster_vendor_delete(int get_vid)
        {
            SqlConnection conVENDOR = new SqlConnection(cs);
            SqlCommand cmdVendor = new SqlCommand("delete vendor_master where id=" + get_vid, conVENDOR);
            try
            {
                conVENDOR.Open();
                cmdVendor.ExecuteNonQuery();
                conVENDOR.Close();
                errTrue = false;
            }
            catch (Exception ex)
            {
                conVENDOR.Close();
                repText = ex.ToString();
                errTrue = true;
            }
        }

        public void postmaster_vendor_update(AppLogic.Vendor vendor, int get_vid)
        {
            SqlConnection conVENDOR = new SqlConnection(cs);
            SqlCommand cmdVENDOR = new SqlCommand("update vendor_master set [Contact_Person_name]='" + vendor.Contact_Person_name + "' , [Contact_Person_Phone]='" + vendor.Contact_Person_Phone + "' , [Address]='" + vendor.Address + "' , [goods_desc]='" + vendor.goods_desc + "' where id=" + get_vid, conVENDOR);
            try
            {
                conVENDOR.Open();
                cmdVENDOR.ExecuteNonQuery();
                conVENDOR.Close();
                errTrue = false;
            }
            catch (Exception ex)
            {
                conVENDOR.Close();
                repText = ex.ToString();
                errTrue = true;
            }
        }
        #endregion Vendor Master
        #region Item Master
        public void postmaster_item(AppLogic.Item item)
        {
            SqlConnection conWH = new SqlConnection(cs);
            SqlCommand cmdWH = new SqlCommand("INSERT INTO item_mast([iname],[idesc],[ibarcode],[main_cat_id],[sub_cat_id],[uom_purchase_id],[uom_consumption_id],[divisible_uop],[default_wh],[uid],[account_id]) values('" + item.iname + "','" + item.idesc + "','" + item.ibarcode + "'," + item.main_cat_id + "," + item.sub_cat_id + "," + item.uom_purchase_id + "," + item.uom_consumption_id + "," + item.divisible_uop + ",1," + item.uid + "," + item.acc_id + ")", conWH);
            try
            {
                conWH.Open();
                cmdWH.ExecuteNonQuery();
                conWH.Close();
                //
                SqlConnection updcon = new SqlConnection(cs);
                SqlCommand updcmd = new SqlCommand("update item_mast set ibarcode=concat(main_cat_id,sub_cat_id,id) where ibarcode=concat(main_cat_id,sub_cat_id,iname)", updcon);
                updcon.Open();
                updcmd.ExecuteNonQuery();
                updcon.Close();
                errTrue = false;
            }
            catch (Exception ex)
            {
                conWH.Close();
                repText = ex.ToString();
                errTrue = true;
                //throw;
            }
        }

        public void postmaster_item_update(AppLogic.Item item, int get_itemid)
        {
            SqlConnection conWH = new SqlConnection(cs);
            SqlCommand cmdWH = new SqlCommand("update item_mast set [idesc]='" + item.idesc + "' , [ibarcode]='" + item.ibarcode + "' , [main_cat_id]=" + item.main_cat_id + " , [sub_cat_id]=" + item.sub_cat_id + ", [uom_purchase_id]=" + item.uom_purchase_id + " ,[uom_consumption_id]=" + item.uom_consumption_id + " , [divisible_uop]=" + item.divisible_uop + "  where id=" + get_itemid, conWH);
            try
            {
                conWH.Open();
                cmdWH.ExecuteNonQuery();
                conWH.Close();
                errTrue = false;
            }
            catch (Exception ex)
            {
                conWH.Close();
                repText = ex.ToString();
                errTrue = true;
            }
        }

        public void postmaster_item_delete(int get_iid)
        {
            SqlConnection conWH = new SqlConnection(cs);
            SqlCommand cmdWH = new SqlCommand("delete item_mast where id=" + get_iid, conWH);
            try
            {
                conWH.Open();
                cmdWH.ExecuteNonQuery();
                conWH.Close();
                errTrue = false;
            }
            catch (Exception ex)
            {
                conWH.Close();
                repText = ex.ToString();
                errTrue = true;
            }
        }

        public AppLogic.ModItem getitem(int a)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select IM.iname AS INAME,iM.idesc AS IDESC,IM.ibarcode AS BARCODE,IM.main_cat_id AS MAINCAT, IM.sub_cat_id AS SUBCAT,IM.uom_purchase_id AS UOP,IM.uom_consumption_id AS UOC,IM.divisible_uop AS DUOM,IM.account_id ACCID from item_mast IM WHERE IM.id=" + a, con);
            SqlDataReader rdr = null;
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                rdr.Read();
                {
                    applitem.iname = (string)rdr["INAME"];
                    applitem.idesc = (string)rdr["IDESC"];
                    applitem.ibarcode = (string)rdr["BARCODE"];
                    applitem.main_cat_id = (Int32)rdr["MAINCAT"];
                    applitem.sub_cat_id = (Int32)rdr["SUBCAT"];
                    applitem.uom_purchase_id = (Int32)rdr["UOP"];
                    applitem.uom_consumption_id = (Int32)rdr["UOC"];
                    applitem.divisible_uop = (decimal)rdr["DUOM"];
                    applitem.acc_id = (Int32)rdr["ACCID"];
                }
                con.Close();
            }
            catch (Exception)
            {

            }
            return applitem;
        }
        #endregion Item Master
        #region department master
        public void postmaster_department(AppLogic.Department WH)
        {
            SqlConnection conWH = new SqlConnection(cs);
            SqlCommand cmdWH = new SqlCommand("INSERT INTO departments(dept_name,dept_cat_id,isActive,b_entity_id) values('" + WH.dept_name + "'," + WH.dept_cat_id + ",1," + WH.b_entity_id + ")", conWH);
            try
            {
                conWH.Open();
                cmdWH.ExecuteNonQuery();
                conWH.Close();
                errTrue = false;
            }
            catch (Exception ex)
            {
                conWH.Close();
                repText = ex.ToString();
                errTrue = true;
                //throw;
            }
        }

        public void postmaster_department_update(AppLogic.Department WH, int get_whid, int get_bid)
        {
            SqlConnection conWH = new SqlConnection(cs);
            SqlCommand cmdWH = new SqlCommand("update departments set [dept_cat_id]='" + WH.dept_cat_id + "' where isActive=1 AND id=" + get_whid + " AND b_entity_id=" + get_bid, conWH);
            try
            {
                conWH.Open();
                cmdWH.ExecuteNonQuery();
                conWH.Close();
                errTrue = false;
            }
            catch (Exception ex)
            {
                conWH.Close();
                repText = ex.ToString();
                errTrue = true;
            }
        }

        public AppLogic.ModDepartment getdid(string a, int get_bid)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SELECT * FROM departments where isActive=1 AND id=" + a + " AND b_entity_id=" + get_bid, con);
            SqlDataReader rdr = null;
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                rdr.Read();
                {
                    moddept.dept_name = (string)rdr["dept_name"];
                    moddept.dept_cat_id = (Int32)rdr["dept_cat_id"];
                }
                con.Close();
            }
            catch (Exception)
            {

            }
            return moddept;
        }

        public void postmaster_department_delete(int get_whid, int get_bid)
        {
            SqlConnection conWH = new SqlConnection(cs);
            SqlCommand cmdWH = new SqlCommand("delete departments where isActive=1 AND id=" + get_whid + " AND b_entity_id=" + get_bid, conWH);
            try
            {
                conWH.Open();
                cmdWH.ExecuteNonQuery();
                conWH.Close();
                errTrue = false;
            }
            catch (Exception ex)
            {
                conWH.Close();
                repText = ex.ToString();
                errTrue = true;
            }
        }
        #endregion Department Master

    }
}
