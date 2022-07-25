<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wip_Stock.aspx.cs" Inherits="ESIT_ERP.Reports.MM.Wip_Stock" %>


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

        });
    </script>
</head>
<body>
    <div class=" text-center top-header" style="">
        <h2 class="marginpaddingzero headering-lettersp lato" style="padding: 10px !important;"><a href="/">EateryManager</a></h2>
        <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;">ANWAR BALOCH RESTAURANT</h3>
    </div>
    <h3 class="main-heading text-center headering-lettersp lato"><b>WIP Stock Level</b></h3>
    <hr />
    <div class="container breadcrumb">
        <form id="form1" runat="server">
            <div class="myinput">
                <asp:GridView ID="vid" CssClass="table table-bordered" Width="100%" runat="server" AutoGenerateColumns="False" DataSourceID="StockLevel" AllowSorting="True">
                    <Columns>
                        <asp:BoundField DataField="WIP_NAME" HeaderText="WIP_NAME" SortExpression="WIP_NAME" />
                        <asp:BoundField DataField="TOTAL_PRODUCE" HeaderText="TOTAL_PRODUCE" ReadOnly="True" SortExpression="TOTAL_PRODUCE" />
                        <asp:BoundField DataField="TOTAL_ISSUE" HeaderText="TOTAL_ISSUE" ReadOnly="True" SortExpression="TOTAL_ISSUE" />
                        <asp:BoundField DataField="TOTAL_BALANCE" HeaderText="TOTAL_BALANCE" SortExpression="TOTAL_BALANCE" ReadOnly="True" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="StockLevel" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="select WI.wip_item_name AS WIP_NAME,SUM(WP.wip_produce_qty) TOTAL_PRODUCE,SUM(WP.wip_produce_issue) TOTAL_ISSUE,SUM(WP.wip_produce_qty)-SUM(WP.wip_produce_issue) TOTAL_BALANCE from wip_production WP INNER JOIN wip_item WI ON WI.id=WP.wip_item_id where WP.b_entity_id=@bid AND issue_able=1 group by WI.wip_item_name">
                    <SelectParameters>
                        <asp:SessionParameter DefaultValue="1" Name="bid" SessionField="bid" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SQLSUPPLIERLEDGER" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT id AS TID, tdate AS TDATE, ref_doc_no AS REF_TNO, ttype + '-' + remarks AS remarks, cr AS Credit, dr AS Debit FROM vendor_transactions AS VT WHERE (ven_id = @vid) AND (b_entity_id = @bid) ORDER BY tdate">
                    <SelectParameters>
                        <asp:QueryStringParameter DefaultValue="1" Name="vid" QueryStringField="vid" />
                        <asp:SessionParameter Name="bid" SessionField="bid" />
                    </SelectParameters>
                </asp:SqlDataSource>
               
                <div class="col">
                    <asp:Button runat="server" CssClass="btn btn-danger" Style="background-color: #a94442;" ID="btnBack" Text="Go Back & Exit REPORT" OnClick="btnBack_Click" Width="100%" />
                </div>

            </div>
        </form>
    </div>
</body>
</html>
