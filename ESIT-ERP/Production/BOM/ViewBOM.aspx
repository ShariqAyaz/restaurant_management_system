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
        <div class=" text-center top-header" style="">
            <h4 style="margin: 0px; padding: 0px;"><strong><% Response.Write(ppo(Convert.ToInt32(Request.QueryString["bomid"]))); %></strong></h4>
        </div>

        <div class="container" style="margin-top: 10px">
            <asp:GridView CssClass="table table-bordered" ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="sqldslistbom">
                <Columns>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="Select"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="MaterialName" HeaderText="MaterialName" SortExpression="MaterialName" />
                    <asp:BoundField DataField="QTY" HeaderText="QTY" SortExpression="QTY" />
                    <asp:BoundField DataField="UOM" HeaderText="UOM" SortExpression="UOM" />
                    <asp:CommandField HeaderText="Edit / Delete" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="sqldslistbom" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" DeleteCommand="delete from bom_det where id=@id" SelectCommand="SELECT BD.id, IM.iname AS MaterialName, BD.iqty AS QTY, UM.UOM FROM BOM AS B INNER JOIN BOM_det AS BD ON B.id = BD.bom_id INNER JOIN item_mast AS IM ON BD.iid = IM.id INNER JOIN UOM AS UM ON IM.uom_consumption_id = UM.id WHERE (B.id = @rid) AND (B.b_entity_id = @bid)" UpdateCommand="update bom_det set iqty=@qty where id=@id">
                <SelectParameters>
                    <asp:QueryStringParameter Name="rid" QueryStringField="bomid" />
                    <asp:SessionParameter Name="bid" SessionField="bid" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="qty" Type="Decimal" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
