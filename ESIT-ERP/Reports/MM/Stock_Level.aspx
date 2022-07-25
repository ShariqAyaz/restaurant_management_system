<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Stock_Level.aspx.cs" Inherits="ESIT_ERP.Reports.MM.Stock_Level" %>

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
    <asp:Panel ID="pdfPannel" runat="server"> 
    <h3 class="main-heading text-center headering-lettersp lato"><b>Stock Level</b></h3>
    <hr />
    <div class="container breadcrumb">
        <form id="form1" runat="server">
            <div class="myinput">
                <asp:GridView ID="vid" CssClass="table table-bordered" Width="100%" runat="server" AutoGenerateColumns="False" DataSourceID="StockLevel" AllowSorting="True">
                    <Columns>
                        <asp:BoundField DataField="INAME" HeaderText="INAME" SortExpression="INAME" />
                        <asp:BoundField DataField="REC/QTY" HeaderText="REC/QTY" ReadOnly="True" SortExpression="REC/QTY" />
                        <asp:BoundField DataField="ISSUED/TUNIT" HeaderText="ISSUED/TUNIT" ReadOnly="True" SortExpression="ISSUED/TUNIT" />
                        <asp:BoundField DataField="BALANCE" HeaderText="BALANCE" SortExpression="BALANCE" ReadOnly="True" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="StockLevel" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="select IM.iname AS INAME,
sum(increase_qty) AS [REC/QTY],
sum(decrease_qty) AS [ISSUED/TUNIT],(sum(increase_qty)-sum(decrease_qty)) AS [BALANCE] from store_det 
inner join item_mast IM ON IM.id=store_det.iid
INNER JOIN UOM ON UOM.id=im.uom_consumption_id
INNER JOIN store ST ON ST.doc_id=store_det.doc_id WHERE ST.b_entity_id=@bid
group by IM.iname,uom_purchase_id,UOM.UOM,divisible_uop">
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
                    <asp:Button runat="server" CssClass="btn btn-danger" Style="background-color: #a94442;" ID="print" Text="Print" Width="100%" OnClick="print_Click" />
                </div>

                <div class="col">
                    <asp:Button runat="server" CssClass="btn btn-danger" Style="background-color: #a94442;" ID="btnBack" Text="Go Back & Exit REPORT" OnClick="btnBack_Click" Width="100%" />
                </div>

            </div>
        </form>
    </div>
        </asp:Panel>
</body>
</html>
