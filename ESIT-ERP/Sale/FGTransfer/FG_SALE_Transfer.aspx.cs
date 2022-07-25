using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ESIT_ERP.Sale.FGTransfer
{
    public partial class FG_SALE_Transfer : System.Web.UI.Page
    {
        protected string cs = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=ESITERP;integrated security=True;Max Pool Size=50000";
        protected string cs_R = @"data source=ABSERVER2\SQLEXPRESS;initial catalog=OCCOTOPOS3;integrated security=True;Max Pool Size=50000";
        protected string cs_FS = @"data source=ANWARBALOCH-PC\SQLEXPRESS;initial catalog=OCCOTOPOS3;integrated security=True;Max Pool Size=50000";
        //
        AppLogic.WipProductionEntry WIPRO = new AppLogic.WipProductionEntry();
        Numerator.Numerator num = new Numerator.Numerator();
        rdgrant.rdgrant apps = new rdgrant.rdgrant();
        postproceed.postproceed pp = new postproceed.postproceed();
        transactions.transactions vtran = new transactions.transactions();
        //
        public int cur_actionid;
        public int StartTicket;
        public int EndTicket;
        static int appid = 1021;
        public string retmessage = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userlogin"] == null)
                Response.Redirect("/login.aspx");
            cur_actionid = apps.getActionId(Convert.ToInt32(Session["userlogin"]), appid);

            StartTicket = 0;
            EndTicket = 0;
            StartTicket = getStartTicket();
            EndTicket = getEndTicket();
        }

        protected int getStartTicket()
        {
            int i = 0;
            if (Convert.ToInt16(Session["bid"]) == 1)
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("select top 1 SALE_TICKETS_FF from numerator", con);
                SqlDataReader rdr = null;
                try
                {
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() == true)
                    {
                        i = (int)rdr["SALE_TICKETS_FF"];
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    con.Close();
                }
            }
            else if (Convert.ToInt16(Session["bid"]) == 2)
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("select top 1 SALE_TICKETS_RES from numerator", con);
                SqlDataReader rdr = null;
                try
                {
                    con.Open();
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() == true)
                    {
                        i = (int)rdr["SALE_TICKETS_RES"];
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
        protected int getEndTicket()
        {
            int i = 0;
            if (Convert.ToInt16(Session["bid"]) == 1)
            {
                SqlConnection con = new SqlConnection(cs_FS);
                SqlCommand cmd = new SqlCommand("select TOP 1 T.id as id,T.TicketNumber as tno from Tickets T INNER JOIN Orders O ON O.TicketId=T.Id where T.TicketNumber >= " + (StartTicket) + " order by T.id desc", con);
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
            else if (Convert.ToInt16(Session["bid"]) == 2)
            {

            }
            return i;
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "")
            {
                Response.Write("<script>alert('Please Date');</script>");
                return;
            }

            if (Convert.ToInt32(Session["bid"]) == 1)
            {
                if (StartTicket <= EndTicket)
                {
                    string qryC = "SELECT TT.TicketTags as [TicketTags],MI.Id AS MID,OO.MenuItemName as [MenuItemName], MI.GroupCode as [GroupCode], SUM(OO.Quantity) AS QTY, OO.Price* SUM(OO.Quantity)AS[LINE_AMT]" +
                         " FROM Tickets AS TT" +
                         " INNER JOIN Orders AS OO ON TT.Id = OO.TicketId" +
                         " INNER JOIN MenuItems AS MI ON MI.Id = OO.MenuItemId" +
                         " INNER JOIN MenuItemPortions MPO ON Mi.Id = MPO.MenuItemId" +
                         " INNER JOIN MenuItemPrices MPRI ON MPO.Id = MPRI.MenuItemPortionId" +
                         " WHERE(OO.OrderStates NOT LIKE '%Void%')" +
                         " AND Mi.id in ('52','57','86','90', '93', '94', '87', '88', '92', '89', '196', '95', '191', '91', '175', '116', '127', '132', '173', '118', '128', '114', '129', '126', '111', '130', '113', '110', '117', '109', '112', '123', '120', '131', '133', '125', '76', '75', '77', '165', '158', '84', '83', '85', '146', '147', '142', '141', '136', '137', '138', '139', '195', '198', '104', '101', '106', '103', '100', '99', '108', '102', '107', '98', '97', '144', '105', '194', '82', '81', '203', '202', '80', '200', '197', '171', '59')" +
                         " AND TT.TicketNumber BETWEEN " + StartTicket + " AND " + EndTicket + "" +
                         " GROUP BY TT.TicketTags,Mi.id,OO.MenuItemName, MI.GroupCode,OO.Price";
                    SqlConnection conSALEFETCH = new SqlConnection(cs_FS);
                    SqlCommand cmdSALEFETCH = new SqlCommand(qryC, conSALEFETCH);
                    SqlDataReader rdrSALEFETCH = null;
                    conSALEFETCH.Open();
                    rdrSALEFETCH = cmdSALEFETCH.ExecuteReader();
                    while (rdrSALEFETCH.Read() == true)
                    {
                        SqlConnection conW = new SqlConnection(cs);
                        SqlCommand cmdW = new SqlCommand("INSERT INTO[dbo].[TRANSFER_SALE]([pdate],[TicketTags],[Start],[End],[MID],[MenuItemName],[GroupCode],[QTY],[LINE_AMT],[isConsume],[uid],[b_entity_id])VALUES('" + txtBox.Text + "','" + rdrSALEFETCH["TicketTags"] + "'," + StartTicket + "," + EndTicket + "," + Convert.ToInt32(rdrSALEFETCH["MID"]) + ",'" + rdrSALEFETCH["MenuItemName"] + "','" + rdrSALEFETCH["GroupCode"] + "'," + Convert.ToDecimal(rdrSALEFETCH["QTY"]) + "," + Convert.ToDecimal(rdrSALEFETCH["LINE_AMT"]) + ",0," + Convert.ToInt32(Session["userlogin"]) + "," + Convert.ToInt32(Session["bid"]) + ")", conW);
                        try
                        {
                            conW.Open();
                            cmdW.ExecuteNonQuery();
                            conW.Close();
                        }
                        catch (Exception ex)
                        {
                            conW.Close();
                        }
                        // TRANSFER SALE//
                        //
                        // CONSUME MATERIAL //
                        if (Convert.ToString(rdrSALEFETCH["TicketTags"]) == "")
                        {
                            if (itHasWip(Convert.ToInt32(rdrSALEFETCH["MID"])) == true)
                            {
                                SqlConnection qcon = new SqlConnection(cs);
                                SqlCommand qcmd = new SqlCommand("select B.id AS BOMID,B.fg_id as FID,BR.iid as iid,BR.iqty AS ICONSUME from BOM B INNER JOIN BOM_det_raw BR ON BR.bom_id=B.id where fg_id=" + Convert.ToInt32(rdrSALEFETCH["MID"]) + " AND Profile_Name LIKE '%Takeaway%' AND B.HasWip=1", qcon);
                                SqlDataReader qrdr = null;
                                qcon.Open();
                                qrdr = qcmd.ExecuteReader();
                                while (qrdr.Read() == true)
                                {
                                    try
                                    {
                                        Decimal irate = getirate(Convert.ToInt32(qrdr["iid"]));
                                        SqlConnection conWrite = new SqlConnection(cs);
                                        SqlCommand cmdWrite = new SqlCommand("INSERT INTO [dbo].[MATERIAL_CONSUME_BOM]([bom_id],[pdate],[FID],[IID],[IID_Consume],[IID_trate],[IID_TAMT],[uid],[b_entity_id]) VALUES(" + Convert.ToInt32(qrdr["BOMID"]) + ",'" + Convert.ToDateTime(txtBox.Text) + "'," + Convert.ToInt32(qrdr["FID"]) + "," + Convert.ToInt32(qrdr["iid"]) + "," + Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]) + "," + irate + "," + irate * Convert.ToDecimal(Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"])) + "," + Convert.ToInt32(Session["userlogin"]) + "," + Convert.ToInt32(Session["bid"]) + ")", conWrite);
                                        conWrite.Open();
                                        cmdWrite.ExecuteNonQuery();
                                        vtran.storedecreaseBOM(Convert.ToInt32(Session["userlogin"]), Convert.ToInt32(Session["bid"]), Convert.ToDateTime(txtBox.Text), Convert.ToInt32(qrdr["iid"]), Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]));
                                        conWrite.Close();
                                    }
                                    catch (Exception ex)
                                    {

                                        //throw;
                                    }
                                }

                                ///////////////
                                //// ENTER WIP ITEM ////
                                //////////////
                                SqlConnection qconWIP = new SqlConnection(cs);
                                SqlCommand qcmdWIP = new SqlCommand("select B.id AS BOMID,B.fg_id as FID,BR.WIP_ITEM_ID as [WIP_ITEM_ID],BR.iqty AS ICONSUME from BOM B INNER JOIN BOM_det_WIP BR ON BR.bom_id=B.id where B.fg_id=" + Convert.ToInt32(rdrSALEFETCH["MID"]) + " AND Profile_Name LIKE '%Takeaway%' AND B.HasWip=1", qconWIP);
                                SqlDataReader qrdrWIP = null;
                                qconWIP.Open();
                                qrdrWIP = qcmdWIP.ExecuteReader();
                                while (qrdrWIP.Read() == true)
                                {
                                    try
                                    {
                                        Decimal irate = getwiprate(Convert.ToInt32(qrdrWIP["WIP_ITEM_ID"]));
                                        SqlConnection conWrite = new SqlConnection(cs);
                                        SqlCommand cmdWrite = new SqlCommand("INSERT INTO [dbo].[WIP_MATERIAL_CONSUME_BOM]([bom_id],[pdate],[FID],[WIP_ID],[WIP_ID_Consume],[WIP_IID_trate],[WIP_ID_TAMT],[uid],[b_entity_id]) VALUES(" + Convert.ToInt32(qrdrWIP["BOMID"]) + ",'" + Convert.ToDateTime(txtBox.Text) + "'," + Convert.ToInt32(qrdrWIP["FID"]) + "," + Convert.ToInt32(qrdrWIP["WIP_ITEM_ID"]) + "," + Convert.ToDecimal(qrdrWIP["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]) + "," + irate + "," + irate * Convert.ToDecimal(Convert.ToDecimal(qrdrWIP["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"])) + "," + Convert.ToInt32(Session["userlogin"]) + "," + Convert.ToInt32(Session["bid"]) + ")", conWrite);
                                        conWrite.Open();
                                        cmdWrite.ExecuteNonQuery();
                                        vtran.WIP_Decrease(Convert.ToInt32(Session["userlogin"]), Convert.ToInt32(Session["bid"]), Convert.ToDateTime(txtBox.Text), Convert.ToInt32(qrdrWIP["WIP_ITEM_ID"]), getiid(Convert.ToInt32(qrdrWIP["WIP_ITEM_ID"])), Convert.ToDecimal(qrdrWIP["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]));
                                        conWrite.Close();
                                    }
                                    catch (Exception ex)
                                    {

                                    }
                                }
                                qcon.Close();
                                qconWIP.Close();

                            }
                            else if (itHasWip(Convert.ToInt32(rdrSALEFETCH["MID"])) == false)
                            {
                                SqlConnection qcon = new SqlConnection(cs);
                                SqlCommand qcmd = new SqlCommand("select B.id AS BOMID,B.fg_id as FID,BR.iid as iid,BR.iqty AS ICONSUME from BOM B INNER JOIN BOM_det_raw BR ON BR.bom_id=B.id where fg_id=" + Convert.ToInt32(rdrSALEFETCH["MID"]) + " AND Profile_Name LIKE '%Takeaway%' AND B.HasWip=0", qcon);
                                SqlDataReader qrdr = null;
                                try
                                {
                                    qcon.Open();
                                    qrdr = qcmd.ExecuteReader();
                                    while (qrdr.Read() == true)
                                    {
                                        try
                                        {
                                            Decimal irate = getirate(Convert.ToInt32(qrdr["iid"]));
                                            SqlConnection conWrite = new SqlConnection(cs);
                                            SqlCommand cmdWrite = new SqlCommand("INSERT INTO [dbo].[MATERIAL_CONSUME_BOM]([bom_id],[pdate],[FID],[IID],[IID_Consume],[IID_trate],[IID_TAMT],[uid],[b_entity_id]) VALUES(" + Convert.ToInt32(qrdr["BOMID"]) + ",'" + Convert.ToDateTime(txtBox.Text) + "'," + Convert.ToInt32(qrdr["FID"]) + "," + Convert.ToInt32(qrdr["iid"]) + "," + Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]) + "," + irate + "," + irate * Convert.ToDecimal(Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"])) + "," + Convert.ToInt32(Session["userlogin"]) + "," + Convert.ToInt32(Session["bid"]) + ")", conWrite);
                                            conWrite.Open();
                                            cmdWrite.ExecuteNonQuery();
                                            conWrite.Close();
                                            vtran.storedecreaseBOM(Convert.ToInt32(Session["userlogin"]), Convert.ToInt32(Session["bid"]), Convert.ToDateTime(txtBox.Text), Convert.ToInt32(qrdr["iid"]), Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]));
                                        }
                                        catch (Exception ex)
                                        {

                                        }
                                    }
                                    qcon.Close();
                                }
                                catch (Exception ex)
                                {

                                }
                                ////
                            }
                        }
                        else if (Convert.ToString(rdrSALEFETCH["TicketTags"]) != "")
                        {
                            if (itHasWip(Convert.ToInt32(rdrSALEFETCH["MID"])) == true)
                            {
                                SqlConnection qcon = new SqlConnection(cs);
                                SqlCommand qcmd = new SqlCommand("select B.id AS BOMID,B.fg_id as FID,BR.iid as iid,BR.iqty AS ICONSUME from BOM B INNER JOIN BOM_det_raw BR ON BR.bom_id=B.id where fg_id=" + Convert.ToInt32(rdrSALEFETCH["MID"]) + " AND Profile_Name LIKE '%Dine%' AND B.HasWip=1", qcon);
                                SqlDataReader qrdr = null;
                                qcon.Open();
                                qrdr = qcmd.ExecuteReader();
                                while (qrdr.Read() == true)
                                {
                                    Decimal irate = getirate(Convert.ToInt32(qrdr["iid"]));
                                    SqlConnection conWrite = new SqlConnection(cs);
                                    SqlCommand cmdWrite = new SqlCommand("INSERT INTO [dbo].[MATERIAL_CONSUME_BOM]([bom_id],[pdate],[FID],[IID],[IID_Consume],[IID_trate],[IID_TAMT],[uid],[b_entity_id]) VALUES(" + Convert.ToInt32(qrdr["BOMID"]) + ",'" + Convert.ToDateTime(txtBox.Text) + "'," + Convert.ToInt32(qrdr["FID"]) + "," + Convert.ToInt32(qrdr["iid"]) + "," + Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]) + "," + irate + "," + irate * Convert.ToDecimal(Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"])) + "," + Convert.ToInt32(Session["userlogin"]) + "," + Convert.ToInt32(Session["bid"]) + ")", conWrite);
                                    conWrite.Open();
                                    cmdWrite.ExecuteNonQuery();
                                    vtran.storedecreaseBOM(Convert.ToInt32(Session["userlogin"]), Convert.ToInt32(Session["bid"]), Convert.ToDateTime(txtBox.Text), Convert.ToInt32(qrdr["iid"]), Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]));
                                    conWrite.Close();
                                }
                                qcon.Close();
                                //
                                ///////////////
                                //// ENTER WIP ITEM ////
                                //////////////
                                SqlConnection qconWIP = new SqlConnection(cs);
                                SqlCommand qcmdWIP = new SqlCommand("select B.id AS BOMID,B.fg_id as FID,BR.WIP_ITEM_ID as [WIP_ITEM_ID],BR.iqty AS ICONSUME from BOM B INNER JOIN BOM_det_WIP BR ON BR.bom_id=B.id where B.fg_id=" + Convert.ToInt32(rdrSALEFETCH["MID"]) + " AND Profile_Name LIKE '%Takeaway%' AND B.HasWip=1", qconWIP);
                                SqlDataReader qrdrWIP = null;
                                qconWIP.Open();
                                qrdrWIP = qcmdWIP.ExecuteReader();
                                while (qrdrWIP.Read() == true)
                                {
                                    try
                                    {
                                        Decimal irate = getwiprate(Convert.ToInt32(qrdrWIP["WIP_ITEM_ID"]));
                                        SqlConnection conWrite = new SqlConnection(cs);
                                        SqlCommand cmdWrite = new SqlCommand("INSERT INTO [dbo].[WIP_MATERIAL_CONSUME_BOM]([bom_id],[pdate],[FID],[WIP_ID],[WIP_ID_Consume],[WIP_IID_trate],[WIP_ID_TAMT],[uid],[b_entity_id]) VALUES(" + Convert.ToInt32(qrdrWIP["BOMID"]) + ",'" + Convert.ToDateTime(txtBox.Text) + "'," + Convert.ToInt32(qrdrWIP["FID"]) + "," + Convert.ToInt32(qrdrWIP["WIP_ITEM_ID"]) + "," + Convert.ToDecimal(qrdrWIP["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]) + "," + irate + "," + irate * Convert.ToDecimal(Convert.ToDecimal(qrdrWIP["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"])) + "," + Convert.ToInt32(Session["userlogin"]) + "," + Convert.ToInt32(Session["bid"]) + ")", conWrite);
                                        conWrite.Open();
                                        cmdWrite.ExecuteNonQuery();
                                        vtran.WIP_Decrease(Convert.ToInt32(Session["userlogin"]), Convert.ToInt32(Session["bid"]), Convert.ToDateTime(txtBox.Text), Convert.ToInt32(qrdrWIP["WIP_ITEM_ID"]), getiid(Convert.ToInt32(qrdrWIP["WIP_ITEM_ID"])), Convert.ToDecimal(qrdrWIP["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]));
                                        conWrite.Close();
                                    }
                                    catch (Exception ex)
                                    {

                                    }
                                }
                                qconWIP.Close();
                                //////
                            }
                            else if (itHasWip(Convert.ToInt32(rdrSALEFETCH["MID"])) == false)
                            {
                                SqlConnection qcon = new SqlConnection(cs);
                                SqlCommand qcmd = new SqlCommand("select B.id AS BOMID,B.fg_id as FID,BR.iid as iid,BR.iqty AS ICONSUME from BOM B INNER JOIN BOM_det_raw BR ON BR.bom_id=B.id where fg_id=" + Convert.ToInt32(rdrSALEFETCH["MID"]) + " AND Profile_Name LIKE '%Dine%' AND B.HasWip=0", qcon);
                                SqlDataReader qrdr = null;
                                qcon.Open();
                                qrdr = qcmd.ExecuteReader();
                                while (qrdr.Read() == true)
                                {
                                    Decimal irate = getirate(Convert.ToInt32(qrdr["iid"]));
                                    SqlConnection conWrite = new SqlConnection(cs);
                                    SqlCommand cmdWrite = new SqlCommand("INSERT INTO [dbo].[MATERIAL_CONSUME_BOM]([bom_id],[pdate],[FID],[IID],[IID_Consume],[IID_trate],[IID_TAMT],[uid],[b_entity_id]) VALUES(" + Convert.ToInt32(qrdr["BOMID"]) + ",'" + Convert.ToDateTime(txtBox.Text) + "'," + Convert.ToInt32(qrdr["FID"]) + "," + Convert.ToInt32(qrdr["iid"]) + "," + Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]) + "," + irate + "," + irate * Convert.ToDecimal(Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"])) + "," + Convert.ToInt32(Session["userlogin"]) + "," + Convert.ToInt32(Session["bid"]) + ")", conWrite);
                                    conWrite.Open();
                                    cmdWrite.ExecuteNonQuery();
                                    vtran.storedecreaseBOM(Convert.ToInt32(Session["userlogin"]), Convert.ToInt32(Session["bid"]), Convert.ToDateTime(txtBox.Text), Convert.ToInt32(qrdr["iid"]), Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]));
                                    conWrite.Close();
                                }
                                qcon.Close();

                            }
                        }
                        else
                        {

                        }
                        // CONSUME MATERIAL //
                    }
                    conSALEFETCH.Close();
                    //
                    SqlConnection conUPD = new SqlConnection(cs);
                    try
                    {
                        SqlCommand cmdUPD = new SqlCommand("update numerator set SALE_TICKETS_FF=" + (EndTicket + 1), conUPD);
                        conUPD.Open();
                        cmdUPD.ExecuteNonQuery();
                        conUPD.Close();
                    }
                    catch (Exception ex)
                    {
                        conUPD.Close();
                    }
                    //
                    Response.Write("<script>alert('JOB IS DONE...!');</script>");
                    Response.Redirect("/Sale/FGTransfer/FG_SALE_Transfer.aspx");
                    //
                }
                else if (StartTicket > EndTicket & StartTicket != EndTicket & EndTicket > 0)
                {
                    string qryR = "SELECT TT.TicketTags as [TicketTags],MI.Id AS MID,OO.MenuItemName, MI.GroupCode, SUM(OO.Quantity) AS QTY, OO.Price* SUM(OO.Quantity)AS[LINE_AMT]" +
                         " FROM Tickets AS TT" +
                         " INNER JOIN Orders AS OO ON TT.Id = OO.TicketId" +
                         " INNER JOIN MenuItems AS MI ON MI.Id = OO.MenuItemId" +
                         " INNER JOIN MenuItemPortions MPO ON Mi.Id = MPO.MenuItemId" +
                         " INNER JOIN MenuItemPrices MPRI ON MPO.Id = MPRI.MenuItemPortionId" +
                         " WHERE(OO.OrderStates NOT LIKE '%Void%')" +
                         " AND Mi.id in ('52','57','86','90', '93', '94', '87', '88', '92', '89', '196', '95', '191', '91', '175', '116', '127', '132', '173', '118', '128', '114', '129', '126', '111', '130', '113', '110', '117', '109', '112', '123', '120', '131', '133', '125', '76', '75', '77', '165', '158', '84', '83', '85', '146', '147', '142', '141', '136', '137', '138', '139', '195', '198', '104', '101', '106', '103', '100', '99', '108', '102', '107', '98', '97', '144', '105', '194', '82', '81', '203', '202', '80', '200', '197', '171', '59')" +
                         " AND TT.TicketNumber BETWEEN 0 AND " + EndTicket + "" +
                         " GROUP BY TT.TicketTags,Mi.id,OO.MenuItemName, MI.GroupCode,OO.Price";
                    SqlConnection conSALEFETCH = new SqlConnection(cs_FS);
                    SqlCommand cmdSALEFETCH = new SqlCommand(qryR, conSALEFETCH);
                    SqlDataReader rdrSALEFETCH = null;
                    conSALEFETCH.Open();
                    rdrSALEFETCH = cmdSALEFETCH.ExecuteReader();
                    while (rdrSALEFETCH.Read() == true)
                    {
                        // TRANSFER SALE //
                        SqlConnection conW = new SqlConnection(cs);
                        SqlCommand cmdW = new SqlCommand("INSERT INTO[dbo].[TRANSFER_SALE]([pdate],[TicketTags],[Start],[End],[MID],[MenuItemName],[GroupCode],[QTY],[LINE_AMT],[isConsume],[uid],[b_entity_id])VALUES('"+txtBox.Text+"','" + rdrSALEFETCH["TicketTags"] + "'," + 0 + "," + EndTicket + "," + Convert.ToInt32(rdrSALEFETCH["MID"]) + ",'" + rdrSALEFETCH["MenuItemName"] + "','" + rdrSALEFETCH["GroupCode"] + "'," + Convert.ToDecimal(rdrSALEFETCH["QTY"]) + "," + Convert.ToDecimal(rdrSALEFETCH["LINE_AMT"]) + ",0," + Convert.ToInt32(Session["userlogin"]) + "," + Convert.ToInt32(Session["bid"]) + ")", conW);
                        try
                        {
                            conW.Open();
                            cmdW.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            conW.Close();
                        }
                        conW.Close();
                        // TRANSFER SALE//
                        //
                        // CONSUME MATERIAL //
                        if (Convert.ToString(rdrSALEFETCH["TicketTags"]) == "")
                        {
                            if (itHasWip(Convert.ToInt32(rdrSALEFETCH["MID"])) == true)
                            {
                                SqlConnection qcon = new SqlConnection(cs);
                                SqlCommand qcmd = new SqlCommand("select B.id AS BOMID,B.fg_id as FID,BR.iid as iid,BR.iqty AS ICONSUME from BOM B INNER JOIN BOM_det_raw BR ON BR.bom_id=B.id where fg_id=" + Convert.ToInt32(rdrSALEFETCH["MID"]) + " AND Profile_Name LIKE '%Takeaway%' AND B.HasWip=1", qcon);
                                SqlDataReader qrdr = null;
                                qcon.Open();
                                qrdr = qcmd.ExecuteReader();
                                while (qrdr.Read() == true)
                                {
                                    Decimal irate = getirate(Convert.ToInt32(rdrSALEFETCH["iid"]));
                                    SqlConnection conWrite = new SqlConnection(cs);
                                    SqlCommand cmdWrite = new SqlCommand("INSERT INTO [dbo].[MATERIAL_CONSUME_BOM]([bom_id],[pdate],[FID],[IID],[IID_Consume],[IID_trate],[IID_TAMT],[uid],[b_entity_id]) VALUES(" + Convert.ToInt32(qrdr["BOMID"]) + ",'" + Convert.ToDateTime(txtBox.Text) + "'," + Convert.ToInt32(qrdr["FID"]) + "," + Convert.ToInt32(qrdr["iid"]) + "," + Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]) + "," + irate + "," + irate * Convert.ToDecimal(Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"])) + "," + Convert.ToInt32(Session["userlogin"]) + "," + Convert.ToInt32(Session["bid"]) + ")", conWrite);
                                    conWrite.Open();
                                    cmdWrite.ExecuteNonQuery();
                                    vtran.storedecreaseBOM(Convert.ToInt32(Session["userlogin"]), Convert.ToInt32(Session["bid"]), Convert.ToDateTime(txtBox.Text), Convert.ToInt32(qrdr["iid"]), Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]));
                                    conW.Close();
                                }
                                qcon.Close();
                            }
                            else if (itHasWip(Convert.ToInt32(rdrSALEFETCH["MID"])) == false)
                            {
                                SqlConnection qcon = new SqlConnection(cs);
                                SqlCommand qcmd = new SqlCommand("select B.id AS BOMID,B.fg_id as FID,BR.iid as iid,BR.iqty AS ICONSUME from BOM B INNER JOIN BOM_det_raw BR ON BR.bom_id=B.id where fg_id=" + Convert.ToInt32(rdrSALEFETCH["MID"]) + " AND Profile_Name LIKE '%Takeaway%' AND B.HasWip=1", qcon);
                                SqlDataReader qrdr = null;
                                qcon.Open();
                                qrdr = qcmd.ExecuteReader();
                                while (qrdr.Read() == true)
                                {
                                    Decimal irate = getirate(Convert.ToInt32(rdrSALEFETCH["iid"]));
                                    SqlConnection conWrite = new SqlConnection(cs);
                                    SqlCommand cmdWrite = new SqlCommand("INSERT INTO [dbo].[MATERIAL_CONSUME_BOM]([bom_id],[pdate],[FID],[IID],[IID_Consume],[IID_trate],[IID_TAMT],[uid],[b_entity_id]) VALUES(" + Convert.ToInt32(qrdr["BOMID"]) + ",'" + Convert.ToDateTime(txtBox.Text) + "'," + Convert.ToInt32(qrdr["FID"]) + "," + Convert.ToInt32(qrdr["iid"]) + "," + Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]) + "," + irate + "," + irate * Convert.ToDecimal(Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"])) + "," + Convert.ToInt32(Session["userlogin"]) + "," + Convert.ToInt32(Session["bid"]) + ")", conWrite);
                                    conWrite.Open();
                                    cmdWrite.ExecuteNonQuery();
                                    vtran.storedecreaseBOM(Convert.ToInt32(Session["userlogin"]), Convert.ToInt32(Session["bid"]), Convert.ToDateTime(txtBox.Text), Convert.ToInt32(qrdr["iid"]), Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]));
                                    conW.Close();
                                }
                                qcon.Close();
                                ///////////////
                                //// ENTER WIP ITEM ////
                                //////////////
                                SqlConnection qconWIP = new SqlConnection(cs);
                                SqlCommand qcmdWIP = new SqlCommand("select B.id AS BOMID,B.fg_id as FID,BR.WIP_ITEM_ID as [WIP_ITEM_ID],BR.iqty AS ICONSUME from BOM B INNER JOIN BOM_det_WIP BR ON BR.bom_id=B.id where B.fg_id=" + Convert.ToInt32(qrdr["FID"]) + " AND Profile_Name LIKE '%Takeaway%' AND B.HasWip=1", qconWIP);
                                SqlDataReader qrdrWIP = null;
                                qconWIP.Open();
                                qrdrWIP = qcmdWIP.ExecuteReader();
                                while (qrdrWIP.Read() == true)
                                {
                                    Decimal irate = getwiprate(Convert.ToInt32(rdrSALEFETCH["WIP_ITEM_ID"]));
                                    SqlConnection conWrite = new SqlConnection(cs);
                                    SqlCommand cmdWrite = new SqlCommand("INSERT INTO [dbo].[WIP_MATERIAL_CONSUME_BOM]([bom_id],[pdate],[FID],[WIP_ID],[WIP_ID_Consume],[WIP_IID_trate],[WIP_ID_TAMT],[uid],[b_entity_id]) VALUES(" + Convert.ToInt32(qrdrWIP["BOMID"]) + ",'" + Convert.ToDateTime(txtBox.Text) + "'," + Convert.ToInt32(qrdrWIP["FID"]) + "," + Convert.ToInt32(qrdrWIP["WIP_ITEM_ID"]) + "," + Convert.ToDecimal(qrdrWIP["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]) + "," + irate + "," + irate * Convert.ToDecimal(Convert.ToDecimal(qrdrWIP["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"])) + "," + Convert.ToInt32(Session["userlogin"]) + "," + Convert.ToInt32(Session["bid"]) + ")", conWrite);
                                    conWrite.Open();
                                    cmdWrite.ExecuteNonQuery();
                                    vtran.WIP_Decrease(Convert.ToInt32(Session["userlogin"]), Convert.ToInt32(Session["bid"]), Convert.ToDateTime(txtBox.Text), Convert.ToInt32(qrdrWIP["WIP_ITEM_ID"]), getiid(Convert.ToInt32(qrdrWIP["WIP_ITEM_ID"])), Convert.ToDecimal(qrdrWIP["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]));
                                    conW.Close();
                                }
                                qcon.Close();
                                //////
                                
                            }
                        }
                        else if (Convert.ToString(rdrSALEFETCH["TicketTags"]) != "")
                        {
                            if (itHasWip(Convert.ToInt32(rdrSALEFETCH["MID"])) == true)
                            {
                                SqlConnection qcon = new SqlConnection(cs);
                                SqlCommand qcmd = new SqlCommand("select B.id AS BOMID,B.fg_id as FID,BR.iid as iid,BR.iqty AS ICONSUME from BOM B INNER JOIN BOM_det_raw BR ON BR.bom_id=B.id where fg_id=" + Convert.ToInt32(rdrSALEFETCH["MID"]) + " AND Profile_Name LIKE '%Dine%' AND B.HasWip=1", qcon);
                                SqlDataReader qrdr = null;
                                qcon.Open();
                                qrdr = qcmd.ExecuteReader();
                                while (qrdr.Read() == true)
                                {
                                    Decimal irate = getirate(Convert.ToInt32(rdrSALEFETCH["iid"]));
                                    SqlConnection conWrite = new SqlConnection(cs);
                                    SqlCommand cmdWrite = new SqlCommand("INSERT INTO [dbo].[MATERIAL_CONSUME_BOM]([bom_id],[pdate],[FID],[IID],[IID_Consume],[IID_trate],[IID_TAMT],[uid],[b_entity_id]) VALUES(" + Convert.ToInt32(qrdr["BOMID"]) + ",'" + Convert.ToDateTime(txtBox.Text) + "'," + Convert.ToInt32(qrdr["FID"]) + "," + Convert.ToInt32(qrdr["iid"]) + "," + Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]) + "," + irate + "," + irate * Convert.ToDecimal(Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"])) + "," + Convert.ToInt32(Session["userlogin"]) + "," + Convert.ToInt32(Session["bid"]) + ")", conWrite);
                                    conWrite.Open();
                                    cmdWrite.ExecuteNonQuery();
                                    vtran.storedecreaseBOM(Convert.ToInt32(Session["userlogin"]), Convert.ToInt32(Session["bid"]), Convert.ToDateTime(txtBox.Text), Convert.ToInt32(qrdr["iid"]), Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]));
                                    conW.Close();
                                }
                                qcon.Close();
                            }
                            else if (itHasWip(Convert.ToInt32(rdrSALEFETCH["MID"])) == false)
                            {
                                SqlConnection qcon = new SqlConnection(cs);
                                SqlCommand qcmd = new SqlCommand("select B.id AS BOMID,B.fg_id as FID,BR.iid as iid,BR.iqty AS ICONSUME from BOM B INNER JOIN BOM_det_raw BR ON BR.bom_id=B.id where fg_id=" + Convert.ToInt32(rdrSALEFETCH["MID"]) + " AND Profile_Name LIKE '%Takeaway%' AND B.HasWip=1", qcon);
                                SqlDataReader qrdr = null;
                                qcon.Open();
                                qrdr = qcmd.ExecuteReader();
                                while (qrdr.Read() == true)
                                {
                                    Decimal irate = getirate(Convert.ToInt32(rdrSALEFETCH["iid"]));
                                    SqlConnection conWrite = new SqlConnection(cs);
                                    SqlCommand cmdWrite = new SqlCommand("INSERT INTO [dbo].[MATERIAL_CONSUME_BOM]([bom_id],[pdate],[FID],[IID],[IID_Consume],[IID_trate],[IID_TAMT],[uid],[b_entity_id]) VALUES(" + Convert.ToInt32(qrdr["BOMID"]) + ",'" + Convert.ToDateTime(txtBox.Text) + "'," + Convert.ToInt32(qrdr["FID"]) + "," + Convert.ToInt32(qrdr["iid"]) + "," + Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]) + "," + irate + "," + irate * Convert.ToDecimal(Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"])) + "," + Convert.ToInt32(Session["userlogin"]) + "," + Convert.ToInt32(Session["bid"]) + ")", conWrite);
                                    conWrite.Open();
                                    cmdWrite.ExecuteNonQuery();
                                    vtran.storedecreaseBOM(Convert.ToInt32(Session["userlogin"]), Convert.ToInt32(Session["bid"]), Convert.ToDateTime(txtBox.Text), Convert.ToInt32(qrdr["iid"]), Convert.ToDecimal(qrdr["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]));
                                    conW.Close();
                                }
                                qcon.Close();
                                ///////////////
                                //// ENTER WIP ITEM ////
                                //////////////
                                SqlConnection qconWIP = new SqlConnection(cs);
                                SqlCommand qcmdWIP = new SqlCommand("select B.id AS BOMID,B.fg_id as FID,BR.WIP_ITEM_ID as [WIP_ITEM_ID],BR.iqty AS ICONSUME from BOM B INNER JOIN BOM_det_WIP BR ON BR.bom_id=B.id where B.fg_id=" + Convert.ToInt32(qrdr["FID"]) + " AND Profile_Name LIKE '%Takeaway%' AND B.HasWip=1", qconWIP);
                                SqlDataReader qrdrWIP = null;
                                qconWIP.Open();
                                qrdrWIP = qcmdWIP.ExecuteReader();
                                while (qrdrWIP.Read() == true)
                                {
                                    Decimal irate = getwiprate(Convert.ToInt32(rdrSALEFETCH["WIP_ITEM_ID"]));
                                    SqlConnection conWrite = new SqlConnection(cs);
                                    SqlCommand cmdWrite = new SqlCommand("INSERT INTO [dbo].[WIP_MATERIAL_CONSUME_BOM]([bom_id],[pdate],[FID],[WIP_ID],[WIP_ID_Consume],[WIP_IID_trate],[WIP_ID_TAMT],[uid],[b_entity_id]) VALUES(" + Convert.ToInt32(qrdrWIP["BOMID"]) + ",'" + Convert.ToDateTime(txtBox.Text) + "'," + Convert.ToInt32(qrdrWIP["FID"]) + "," + Convert.ToInt32(qrdrWIP["WIP_ITEM_ID"]) + "," + Convert.ToDecimal(qrdrWIP["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]) + "," + irate + "," + irate * Convert.ToDecimal(Convert.ToDecimal(qrdrWIP["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"])) + "," + Convert.ToInt32(Session["userlogin"]) + "," + Convert.ToInt32(Session["bid"]) + ")", conWrite);
                                    conWrite.Open();
                                    cmdWrite.ExecuteNonQuery();
                                    vtran.WIP_Decrease(Convert.ToInt32(Session["userlogin"]), Convert.ToInt32(Session["bid"]), Convert.ToDateTime(txtBox.Text), Convert.ToInt32(qrdrWIP["WIP_ITEM_ID"]), getiid(Convert.ToInt32(qrdrWIP["WIP_ITEM_ID"])), Convert.ToDecimal(qrdrWIP["ICONSUME"]) * Convert.ToDecimal(rdrSALEFETCH["QTY"]));
                                    conW.Close();
                                }
                                qcon.Close();
                                //////
                            }
                        }
                        else
                        {

                        }
                        // CONSUME MATERIAL //
                    }
                    conSALEFETCH.Close();
                    //
                    SqlConnection conUPD = new SqlConnection(cs);
                    try
                    {
                        SqlCommand cmdUPD = new SqlCommand("update numerator set SALE_TICKETS_FF=" + EndTicket, conUPD);
                        conUPD.Open();
                        cmdUPD.ExecuteNonQuery();
                        conUPD.Close();
                    }
                    catch (Exception ex)
                    {
                        conUPD.Close();
                    }
                    num.wip_production_docid();
                    Response.Write("<script>alert('JOB IS DONE...!');</script>");
                    //
                }
                else
                {
                    Response.Write("<script>alert('SALE DATA RESET OR NO PRODUCTION...!');</script>");
                    Response.Redirect("/Sale/FGTransfer/FG_SALE_Transfer.aspx");
                }
            }
            else if (Convert.ToInt32(Session["bid"]) == 2)
            {

            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("/");
        }

        public bool itHasWip(int a)
        {
            bool b = false;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select hasWip from BOM where fg_id=" + a, con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                b = (bool)rdr["hasWip"];
            }
            con.Close();
            return b;
        }

        public decimal getirate(int a)
        {
            decimal ret = 0;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select TOP 1 GD.irate as irate,IM.divisible_uop as divisible_uop from item_mast IM Inner join grn_items_det GD on IM.id=GD.iid where IM.id=" + a + " order BY GD.id desc", con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
                ret = Convert.ToDecimal((decimal)rdr["irate"]) / Convert.ToDecimal((decimal)rdr["divisible_uop"]);
            else
                ret = 0;
            con.Close();
            return ret;
        }
        //getwiprate
        public decimal getwiprate(int a)
        {
            decimal ret = 0;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select iid as iid,wip_item_id as wip_item_id,wip_produce_qty as wip_produce_qty,iid_consume_qty as iid_consume_qty from wip_production where wip_item_id=" + a, con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                decimal irate = getirate(Convert.ToInt32(rdr["iid"]));
                decimal wip_qty = (decimal)rdr["wip_produce_qty"];
                decimal iid_consume_qty = (decimal)rdr["iid_consume_qty"];
                ret = (iid_consume_qty / wip_qty) * irate;
            }
            else
                ret = 0;
            con.Close();
            return ret;
        }

        public int getiid(int wip_id)
        {
            int iidret=0;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select iid from wip_item where id="+wip_id, con);
            SqlDataReader rdr = null;
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read()==true)
            {
                iidret = (int)rdr["iid"];
            }
            con.Close();
            return iidret;
        }
    }
}
