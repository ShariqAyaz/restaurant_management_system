<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierLedger.aspx.cs" Inherits="ESIT_ERP.Reports.Supplier.SupplierLedger" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PIN-MTN - Anwar Baloch - ESIT ERP - NEW PRODUCTION NOTE</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="/assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/assets/css/jquery-ui.css" rel="stylesheet" />
    <link href="/assets/css/style.css" rel="stylesheet" />
    <script src="/assets/js/jquery-3.4.1.js"></script>
    <script src="/assets/js/jquery-ui.js"></script>
    <script src="/assets/js/bootstrap.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {  
           
        });
    </script>
</head>
<body>
    <div class=" text-center top-header" style="">
        <h2 class="marginpaddingzero headering-lettersp lato" style="padding: 10px !important;"><a href="/">EateryManager</a></h2>
        <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;">ANWAR BALOCH RESTAURANT</h3>
    </div>
    <h3 class="main-heading text-center headering-lettersp lato"><b>SUPPLIER LEDGEr</b></h3>
    <hr />
    <div class="container breadcrumb">
        <form id="form1" runat="server">
            <div class="myinput">
                  <div class="col-md-12"><br />
            <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;"><% Response.Write(this.getvname(Convert.ToInt32(Request.QueryString["vid"]))); %></h3>
    </div>
                <div class="col-md-4">
                    <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">SELECT VENDOR</label>
            <asp:DropDownList CssClass="form-control" ID="DropDown_VLIST" runat="server" DataSourceID="wh_list" DataTextField="vendorname" DataValueField="id" OnSelectedIndexChanged="DropDown_warehouse_SelectedIndexChanged">
        <asp:ListItem Text="-Choose Vender-" />
    </asp:DropDownList>
    <asp:SqlDataSource ID="wh_list" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT * FROM [vendor_master]">
    </asp:SqlDataSource></div>
        <div class="col-md-12">
                <asp:Button runat="server" CssClass="btn btn-danger" Style="width: 100%; margin-top: 25px;" ID="btnSearch" Text="View" OnClick="btnSearch_Click" />
            </div><br />
        <asp:GridView ID="vid" CssClass="table table-bordered" Width="100%" runat="server" AutoGenerateColumns="False" DataSourceID="SQLSUPPLIERLEDGER">
            <Columns>
                <asp:BoundField DataField="TID" HeaderText="TID" ReadOnly="True" SortExpression="TID" />
                <asp:BoundField DataField="TDATE" HeaderText="TDATE" ReadOnly="True" SortExpression="TDATE" />
                <asp:BoundField DataField="REF_TNO" HeaderText="REF_TNO" ReadOnly="True" SortExpression="REF_TNO" />
                <asp:BoundField DataField="remarks" HeaderText="remarks" ReadOnly="True" SortExpression="remarks" />
                <asp:BoundField DataField="Credit" HeaderText="Credit" ReadOnly="True" SortExpression="Credit" />
                <asp:BoundField DataField="Debit" HeaderText="Debit" ReadOnly="True" SortExpression="Debit" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SQLSUPPLIERLEDGER" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT id AS TID, tdate AS TDATE, ref_doc_no AS REF_TNO, ttype + '-' + remarks AS remarks, cr AS Credit, dr AS Debit FROM vendor_transactions AS VT WHERE (ven_id = @vid) AND (b_entity_id = @bid) ORDER BY tdate">
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="1" Name="vid" QueryStringField="vid" />
                <asp:SessionParameter Name="bid" SessionField="bid" />
            </SelectParameters>
        </asp:SqlDataSource>
                            <div class=" text-center top-header" style="">
        <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;"><% if (Request.QueryString["vid"]!=null & Request.QueryString["vid"]!="") Response.Write("Credit: " + this.totalcr(Session["bid"].ToString(),Request.QueryString["vid"])); %></h3>
    </div>
                        <div class=" text-center top-header" style="">
        <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;"><% if (Request.QueryString["vid"]!=null & Request.QueryString["vid"]!="") Response.Write("Debit: " + this.totaldr(Session["bid"].ToString(),Request.QueryString["vid"])); %></h3>
    </div>
                <div class=" text-center top-header" style="">
        <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;"><% if (Request.QueryString["vid"]!=null & Request.QueryString["vid"]!="") Response.Write("Balance: " + Convert.ToString(Convert.ToDecimal(this.totalcr(Session["bid"].ToString(),Request.QueryString["vid"])) - Convert.ToDecimal(this.totaldr(Session["bid"].ToString(),Request.QueryString["vid"])))); %></h3>
    </div>
                    <div class="col">
                    <asp:Button runat="server" CssClass="btn btn-danger" Style="background-color: #a94442;" ID="btnBack" Text="Go Back & Exit REPORT" OnClick="btnBack_Click" Width="100%" />
                </div>
                
    </div>
    </form>
        </div>
</body>
</html>
