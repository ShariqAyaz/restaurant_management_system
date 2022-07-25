<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sale_wise_Cons.aspx.cs" Inherits="ESIT_ERP.Reports.Sale_wise_Cons" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PIN-MTN - Anwar Baloch - ESIT ERP - Stock Level</title>
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
            $(".DatePickerCtl").datepicker();
            dtString = $("#<%=dateh.ClientID%>").val();
            dtString = dtString.split(',');
            $(".DatePickerCtl").datepicker('setDate', dtString);
        });
    </script>
</head>
<body>
    <div class=" text-center top-header" style="">
        <h2 class="marginpaddingzero headering-lettersp lato" style="padding: 10px !important;"><a href="/">EateryManager</a></h2>
        <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;">ANWAR BALOCH RESTAURANT</h3>
    </div>
    <h3 class="main-heading text-center headering-lettersp lato">MATERIAL CONSUMPTION SALE WISE</h3>
    <hr />
    <div class="container breadcrumb">
        <form id="form1" runat="server">
            <div class="myinput">
                <div class="col-md-4">
                    <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">Date</label>
                    <asp:TextBox runat="server" ID="txtBox" CssClass="DatePickerCtl form-control" />
                    <asp:HiddenField ID="dateh" runat="server" />
                </div>
                <div class="col">
                    <asp:Button runat="server" CssClass="btn btn-danger" Style="background-color: #a94442;" ID="Button1" Text="VIEW" OnClick="btnBack_Click" Width="100%" />
                </div>
                <br />
                <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;">Sale</h3>
                <br />
                <asp:GridView ID="GridView2" CssClass="table table-bordered" Width="100%" runat="server" AutoGenerateColumns="False" DataSourceID="Sale" AllowSorting="True">
                    <Columns>
                        <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                        <asp:BoundField DataField="QTY" HeaderText="QTY" ReadOnly="True" SortExpression="QTY" />
                        <asp:BoundField DataField="AMT" HeaderText="AMT" ReadOnly="True" SortExpression="AMT" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="Sale" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="select MenuItemName NAME,SUM(qty) QTY,SUM(LINE_AMT) AMT from TRANSFER_SALE
where pdate=@abc
group by MenuItemName">
                    <SelectParameters>
                        <asp:FormParameter DefaultValue="2019-10-01" FormField="txtBox" Name="abc" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;">Direct Material Consumption</h3>
                <br />
                <asp:GridView ID="vid" CssClass="table table-bordered" Width="100%" runat="server" AutoGenerateColumns="False" DataSourceID="StockLevel" AllowSorting="True">
                    <Columns>
                        <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                        <asp:BoundField DataField="AMT" HeaderText="AMT" ReadOnly="True" SortExpression="AMT" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="StockLevel" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="select FM.name,SUM(MC.IID_TAMT) AMT from MATERIAL_CONSUME_BOM MC
INNER JOIN item_mast IM ON IM.id=MC.IID
INNER JOIN FFMENU FM ON FM.id=MC.FID
where MC.pdate=@abc
group by FM.name">
                    <SelectParameters>
                        <asp:FormParameter DefaultValue="2019-01-01" FormField="txtBox" Name="abc" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SQLSUPPLIERLEDGER" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT id AS TID, tdate AS TDATE, ref_doc_no AS REF_TNO, ttype + '-' + remarks AS remarks, cr AS Credit, dr AS Debit FROM vendor_transactions AS VT WHERE (ven_id = @vid) AND (b_entity_id = @bid) ORDER BY tdate">
                    <SelectParameters>
                        <asp:QueryStringParameter DefaultValue="1" Name="vid" QueryStringField="vid" />
                        <asp:SessionParameter Name="bid" SessionField="bid" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;">WIP Material Consumption</h3>
                <br />
                <asp:GridView ID="GridView1" CssClass="table table-bordered" Width="100%" runat="server" AutoGenerateColumns="False" DataSourceID="WIP_CONS_AMT" AllowSorting="True">
                    <Columns>
                        <asp:BoundField DataField="NAME" HeaderText="NAME" SortExpression="NAME" />
                        <asp:BoundField DataField="AMT" HeaderText="AMT" ReadOnly="True" SortExpression="AMT" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="WIP_CONS_AMT" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="select FM.name as NAME,SUM(WIP_ID_TAMT) AMT
  FROM [ESITERP].[dbo].[WIP_MATERIAL_CONSUME_BOM] WM
  INNER JOIN FFMENU FM ON FM.id=WM.FID
  where WM.pdate=@abc
  group by FM.name">
                    <SelectParameters>
                        <asp:FormParameter DefaultValue="2019-01-01" FormField="txtBox" Name="abc" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                <div class="col">
                    <asp:Button runat="server" CssClass="btn btn-danger" Style="background-color: #a94442;" ID="btnBack" Text="Go Back & Exit REPORT" OnClick="btnBack_Click" Width="100%" />
                </div>

            </div>
        </form>
    </div>
</body>
</html>
