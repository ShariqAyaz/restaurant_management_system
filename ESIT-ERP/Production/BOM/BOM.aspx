<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BOM.aspx.cs" Inherits="ESIT_ERP.Production.BOM.BOM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GRN - Anwar Baloch - ESIT ERP - NEW GRN</title>
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
            <u><a href="#">New Recipe</a></u>
            <h4 style="margin: 0px; padding: 0px;"><strong>RECIPE LIST</strong></h4>
        </div>
        <div class="container breadcrumb">
            <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="BOMSQLDSOURCE" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" InsertVisible="False" />
                    <asp:BoundField DataField="Profile_Name" HeaderText="Profile_Name" SortExpression="Profile_Name" />
                    <asp:BoundField DataField="fg_id" HeaderText="fg_id" SortExpression="fg_id" />
                    <asp:BoundField DataField="tag" HeaderText="tag" SortExpression="tag" />
                    <asp:BoundField DataField="version" HeaderText="version" SortExpression="version" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="BOMSQLDSOURCE" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="select B.id,Profile_Name,fg_id,tag,[version] from BOM B INNER JOIN FFMENU FM ON B.fg_id=FM.id AND B.Isactive=1 AND B.b_entity_id=@bid">
                <SelectParameters>
                    <asp:SessionParameter Name="bid" SessionField="bid" DefaultValue="" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>