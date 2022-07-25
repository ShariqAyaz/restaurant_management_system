<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewBOM.aspx.cs" Inherits="ESIT_ERP.Production.BOM.ViewBOM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BOM - Anwar Baloch - ESIT ERP - BOM DETAILS - <% Response.Write(ppo(Convert.ToInt32(Request.QueryString["bomid"]))); %></title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="/assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/assets/css/jquery-ui.css" rel="stylesheet" />
    <link href="/assets/css/style.css" rel="stylesheet" />
    <script src="/assets/js/jquery-3.4.1.js"></script>
    <script src="/assets/js/jquery-ui.js"></script>
    <script src="/assets/js/bootstrap.min.js"></script>
    <script type="text/javascript">
    </script>
</head>
<body>
    <div class=" text-center top-header" style="">
        <h2 class="marginpaddingzero headering-lettersp lato" style="padding: 10px !important;"><a href="/">EateryManager</a></h2>
        <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;">ANWAR BALOCH RESTAURANT</h3>
    </div>
    <h3 class="main-heading text-center headering-lettersp lato"><b>Recipe Builder</b></h3>
    <form method="post" id="frmBOMLIST" runat="server">
        <div class="text-center top-header" style="">
            <h4 style="margin: 0px; padding: 0px;"><strong><% Response.Write(ppo(Convert.ToInt32(Request.QueryString["bomid"]))); %></strong></h4>
        </div>
        <% if (itHasWip(Convert.ToInt32(Request.QueryString["bomid"])) == true)
            {
        %>
        <div class="text-center top-header" style="">
            <h4 style="margin: 0px; padding: 0px;"><a href="ViewWIPCons.aspx?bomid=<% Response.Write(Request.QueryString["bomid"]); %>">View WIP Consumption Items</a></h4>
        </div>
        <%
            }
        %>
        <div class="container" style="margin-top: 10px">
            <asp:GridView CssClass="table table-bordered" ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="sqldslistbom" AllowSorting="True">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="MaterialName" HeaderText="MaterialName" SortExpression="MaterialName" />
                    <asp:BoundField DataField="QTY" HeaderText="QTY" SortExpression="QTY" />
                    <asp:BoundField DataField="UOM" HeaderText="UOM" SortExpression="UOM" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="sqldslistbom" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" DeleteCommand="delete from BOM_det_raw where id=@id" SelectCommand="SELECT BD.id, IM.iname AS MaterialName, BD.iqty AS QTY, UM.UOM FROM BOM AS B INNER JOIN BOM_det_raw AS BD ON B.id = BD.bom_id INNER JOIN item_mast AS IM ON BD.iid = IM.id INNER JOIN UOM AS UM ON IM.uom_consumption_id = UM.id WHERE (B.id = @rid) AND (B.b_entity_id = @bid)" UpdateCommand="update BOM_det_raw set iqty=@qty where id=@id">
                <DeleteParameters>
                    <asp:Parameter Name="id" />
                </DeleteParameters>
                <SelectParameters>
                    <asp:QueryStringParameter Name="rid" QueryStringField="bomid" />
                    <asp:SessionParameter Name="bid" SessionField="bid" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="qty" Type="Decimal" />
                    <asp:Parameter Name="id" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
        <div class="col-md-6">
            <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">ITEM NAME</label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" DataSourceID="item_mast" DataTextField="iname" DataValueField="id" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Text="-Choose Item-" />
            </asp:DropDownList>
            <asp:SqlDataSource ID="item_mast" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT id AS ID,iname as iname FROM [item_mast] ORDER BY [iname]"></asp:SqlDataSource>
        </div>
        <div class="col-md-6">
            <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">Rate</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="txtbiqty" placeholder="Quantity" />
        </div>
        <div class="col-md-12">
            <asp:Button runat="server" CssClass="btn btn-danger" Style="width: 100%; margin-top: 25px;" ID="btnAdd" Text="Add" OnClick="btnAdd_Click" Enabled="False" />
        </div>
        <div class="col-md-12">
            <asp:Button runat="server" CssClass="btn btn-danger" Style="width: 100%; margin-top: 25px;" ID="btnFinish" Text="Finish" OnClick="btnFinish_Click" Enabled="False" />
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OCCOTOPOS3_RESConnectionString %>" SelectCommand="SELECT
                             (SELECT        SUM(TotalAmount) AS Expr1
                               FROM            Tickets AS T
                               WHERE        (Date &gt; '2019-09-01') AND (LastPaymentDate &lt;= '2019-09-21')) AS TOT, 
							    OO.Price * OO.Quantity AS price,
                             (SELECT        MIN(Date) AS Expr1
                               FROM            Tickets AS T
                               WHERE        (Date &gt; '2019-09-01') AND (LastPaymentDate &lt;= '2019-09-21')) AS FDT,
                             (SELECT        MAX(LastPaymentDate) AS Expr1
                               FROM            Tickets AS T
                               WHERE        (Date &gt; '2019-09-01') AND (LastPaymentDate &lt;= '2019-09-21')) AS LDT
FROM            Tickets AS TT INNER JOIN
                         Orders AS OO ON TT.Id = OO.TicketId
WHERE        (OO.OrderStates NOT LIKE '%Void%') AND (TT.Date &gt; '2019-09-01') AND 
                         (TT.LastPaymentDate &lt;= '2019-09-21')"></asp:SqlDataSource>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <a href="/">
            <h3 class="text-center" style="background-color: #a94442; padding-top: 10px; padding-bottom: 10px;"><b>GO BACK</b></h3>
        </a>
    </form>
</body>
</html>
