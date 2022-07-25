<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewWIPCons.aspx.cs" Inherits="ESIT_ERP.Production.BOM.ViewWIPCons" %>
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
    <p class="main-heading text-center headering-lettersp lato">BOM MATERIAL CONSUMPTION</p>
    <form method="post" id="frmBOMLIST" runat="server">
        <div class="text-center top-header" style="">
            <h4 style="margin: 0px; padding: 0px;"><strong><% Response.Write(ppo(Convert.ToInt32(Request.QueryString["bomid"]))); %></strong></h4>
        </div>
        
        <div class="container" style="margin-top: 10px">
            <asp:GridView CssClass="table table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="sqldslistbom" AllowSorting="True">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="MaterialName" HeaderText="MaterialName" SortExpression="MaterialName" />
                    <asp:BoundField DataField="QTY" HeaderText="QTY" SortExpression="QTY" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="sqldslistbom" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" DeleteCommand="delete from BOM_det_WIP where id=@id" SelectCommand="SELECT BD.id, IM.wip_item_name AS MaterialName, BD.iqty AS QTY
FROM BOM AS B INNER JOIN BOM_det_WIP AS BD ON B.id = BD.bom_id 
INNER JOIN wip_item AS IM ON BD.WIP_ITEM_ID = IM.id 
 WHERE (B.id = @rid) AND (B.b_entity_id = @bid)" UpdateCommand="update BOM_det_WIP set iqty=@qty where id=@id">
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
            <asp:SqlDataSource ID="item_mast" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT id AS ID,wip_item_name as iname FROM [wip_item] ORDER BY [wip_item_name]"></asp:SqlDataSource>
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
        <a href="/">
            <h3 class="text-center" style="background-color: #a94442; padding-top: 10px; padding-bottom: 10px;"><b>GO BACK</b></h3>
        </a>
    </form>
</body>
</html>
