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
            <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="BOMSQLDSOURCE" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="id" HeaderText="Receipe ID" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="fg_id" HeaderText="Product ID" SortExpression="fg_id" />
                    <asp:BoundField DataField="fg_Name" HeaderText="Product Name" SortExpression="fg_Name" />
                    <asp:BoundField DataField="version" HeaderText="Version" SortExpression="version" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="BOMSQLDSOURCE" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="select * from BOM where Isactive=1 AND b_entity_id=@bid">
                <SelectParameters>
                    <asp:SessionParameter Name="bid" SessionField="bid" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>