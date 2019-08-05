<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="item.aspx.cs" Inherits="ESIT_ERP.Master.item.item" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Item - Anwar Baloch - ESIT ERP - Inventory Dashboard</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="/assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/assets/css/style.css" rel="stylesheet" />

    <script src="/script/jquery-3.4.1.slim.min.js"></script>
    <script src="/script/jquery-ui.js"></script><asp:Label ID="lblitemdesc" CssClass="control-label col-sm-2 padding-5 red-active"
    <script src="/script/bootstrap.min.js"></script>
</head>
<body style="background-color:;">
    <div class=" text-center top-header" style="">
        <h2 class="marginpaddingzero headering-lettersp lato" style="padding:10px !important;"><a href="/">EateryManager</a></h2>
        <h3 class="marginpaddingzero lato red-active" style="background:#d6d6d6;padding:5px !important;">ANWAR BALOCH RESTAURANT</h3>
    </div>
    <h3 class="main-heading text-center headering-lettersp lato"><b>ITEM</b></h3>
    <hr/>
    <div class="container">
        <form id="frm_wh_location" runat="server" method="post">
            <div class="container breadcrumb">
                <div class="myinput">
                    <asp:Label ID="lblitemname" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center text-center" CssStyle="vertical-align:center" for="txtItemname" runat="server"><b class="red-active">Item Name (Must Be Unique Name)</b></asp:Label>
                    <div class="input-group-lg input-group-md input-group-sm">
                        <asp:TextBox ID="txtbitemname" runat="server" CssClass="form-control" placeholder="Enter Item Name - (Must Be Unique Item Name)" ></asp:TextBox>
                        <span class="input-group-btn" style="">
                              <asp:Button ID="x1" runat="server" Text="" CssClass="btn btn-danger disabled hidden-lg hidden-md hidden-sm hidden-xs" CssStyle="margin:10px 0;padding:0;" />
                        </span>
                    </div>
                </div>
                <div class="clearfix"></div>
                <div class="myinput">
                    <asp:Label ID="lblitemdesc" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="lblItemdesc" runat="server"><b class="red-active">Item Description</b></asp:Label>
                    <div class="input-group-lg input-group-md input-group-sm">
                        <asp:TextBox ID="txtbitemdesc" runat="server" CssClass="form-control" placeholder="Enter Item Description"></asp:TextBox>
                      <span class="input-group-btn">
                          <asp:Button ID="x2" runat="server" Text="" CssClass="btn btn-danger disabled hidden-lg hidden-md hidden-sm hidden-xs" disabled="" CssStyle="margin:10px 0;padding:0;" />
                      </span>
                    </div>
                </div>
                <div class="clearfix"></div>
                <div class="myinput">
                    <asp:Label ID="lblibarcode" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="ItemBarcode" runat="server"><b class="red-active">Item barcode</b></asp:Label>
                    <div class="input-group-lg input-group-md input-group-sm">
                        <asp:TextBox ID="txtbbarcode" runat="server" CssClass="form-control" placeholder="Enter Item Barcode"></asp:TextBox>
                      <span class="input-group-btn">
                          <asp:Button ID="Button1" runat="server" Text="" CssClass="btn btn-danger disabled hidden-lg hidden-md hidden-sm hidden-xs" disabled="" CssStyle="margin:10px 0;padding:0;" />
                      </span>
                    </div>
                </div>
             </div>
            <div class="col-md-6 col-sm-6 col-xs-12 text-center">
                <h3 class="main-heading"><b>Main Category</b></h3>
                <asp:RadioButtonList BorderStyle="none" ID="rblMainCat" runat="server" border="0" DataSourceID="SQLDatasource_Cat" DataTextField="main_cat" DataValueField="id" RepeatDirection="Horizontal" RepeatLayout="Flow" CssClass="rblist text-center col-md-12 col-sm-12 col-xs-12 breadcrumb" ></asp:RadioButtonList>
                <asp:SqlDataSource ID="SQLDatasource_Cat" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT * FROM [main_cat] ORDER BY [main_cat] DESC"></asp:SqlDataSource>
            </div>
            <div class="col-md-6 col-sm-6 col-xs-12 text-center">
                <h3 class="main-heading"><b>Sub Category</b></h3>
                <asp:RadioButtonList BorderStyle="none" ID="rblSubCat" runat="server" border="0" DataSourceID="SQLDatasource_type" DataTextField="sub_cat" DataValueField="id" RepeatDirection="Horizontal" RepeatLayout="Flow" CssClass="rblist text-center col-md-12 col-sm-12 col-xs-12 breadcrumb" ></asp:RadioButtonList>
                <asp:SqlDataSource ID="SQLDatasource_Type" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT * FROM [sub_cat] ORDER BY [sub_cat] DESC"></asp:SqlDataSource>
            </div>
            <div class="col-md-6 col-sm-6 col-xs-12 text-center">
                <h3 class="main-heading"><b>Unit Of Purchasing</b></h3>
                <asp:RadioButtonList BorderStyle="none" ID="rblPunit" runat="server" border="0" DataSourceID="SQLDatasource_punit" DataTextField="UOM" DataValueField="id" RepeatDirection="Horizontal" RepeatLayout="Flow" CssClass="rblist text-center col-md-12 col-sm-12 col-xs-12 breadcrumb" ></asp:RadioButtonList>
                <asp:SqlDataSource ID="SQLDatasource_punit" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT * FROM [UOM] ORDER BY [UOM] DESC"></asp:SqlDataSource>
            </div>
           <div class="col-md-6 col-sm-6 col-xs-12 text-center">
                <h3 class="main-heading"><b>Unit Of Consumption</b></h3>
                <asp:RadioButtonList BorderStyle="none" ID="rblCunit" runat="server" border="0" DataSourceID="SQLDatasource_cunit" DataTextField="UOM" DataValueField="id" RepeatDirection="Horizontal" RepeatLayout="Flow" CssClass="rblist text-center col-md-12 col-sm-12 col-xs-12 breadcrumb" ></asp:RadioButtonList>
                <asp:SqlDataSource ID="SQLDatasource_cunit" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT * FROM [UOM] ORDER BY [UOM] DESC"></asp:SqlDataSource>
            </div>
           <div class="col-md-6 col-sm-6 col-xs-12 text-center">
                <h3 class="main-heading"><b>Account Head</b></h3>
                <asp:RadioButtonList BorderStyle="none" ID="rblAcc" runat="server" border="0" DataSourceID="SQLDatasourceAccHead" DataTextField="Account_name" DataValueField="id" RepeatDirection="Horizontal" RepeatLayout="Flow" CssClass="rblist text-center col-md-12 col-sm-12 col-xs-12 breadcrumb" ></asp:RadioButtonList>
                <asp:SqlDataSource ID="SQLDatasourceAccHead" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT Account_name AS Account_name,id AS id FROM [accounts]"></asp:SqlDataSource>
            </div>
            <div class="col-md-12 col-sm-12 col-xs-12 text-center">
                <h3 class="main-heading"><b>Unit Of Consumption Quantity</b></h3>
                <asp:TextBox ID="txtbdivisibleuop" runat="server" CssClass="form-control" placeholder="Consumption Quantity - Default = 1" required="" ></asp:TextBox>
            </div>
            <div class="clearfix" style="margin:10px;"></div>
                <div class="input-group-sm text-center" style="width:100%">
                    <span class="input-group-btn text-center">
                        <asp:Button ID="btnAdd2" runat="server" Text="Add" CssClass="btn btn-danger" style="width:95%"/>
                    </span>
                    <span class="input-group-btn text-center">
                        <asp:Button ID="btnUpdate2" runat="server" Text="Update" CssClass="btn btn-danger" style="width:95%" Enabled="False" OnClick="btnUpdate2_Click"/>
                    </span>
                    <span class="input-group-btn text-center">
                        <asp:Button ID="btnDel2" runat="server" Text="Delete" CssClass="btn btn-danger" style="width:95%" Enabled="False" OnClick="btnDel2_Click"/>
                    </span>
                </div>
            <hr/>
            <%-- LOAD WAREHOUSES --%>
           <div class="container breadcrumb">
            <asp:GridView ID="GridView1" CssClass="table table-bordered" runat="server" AutoGenerateColumns="False" DataKeyNames="ItemID" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField HeaderText="Select" ShowSelectButton="True" />
                    <asp:BoundField DataField="ItemID" HeaderText="ItemID" InsertVisible="False" ReadOnly="True" SortExpression="ItemID" />
                    <asp:BoundField DataField="ItemName" HeaderText="ItemName" SortExpression="ItemName" />
                    <asp:BoundField DataField="ItemDesc" HeaderText="ItemDesc" SortExpression="ItemDesc" />
                    <asp:BoundField DataField="Barcode" HeaderText="Barcode" SortExpression="Barcode" />
                    <asp:BoundField DataField="main_cat" HeaderText="main_cat" SortExpression="main_cat" />
                    <asp:BoundField DataField="sub_cat" HeaderText="sub_cat" SortExpression="sub_cat" />
                </Columns>
               </asp:GridView>
              
               <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="select 
IM.id AS ItemID, 
IM.ibarcode AS Barcode, 
IM.iname AS ItemName, 
IM.idesc AS ItemDesc, 
MC.main_cat, 
SC.sub_cat 
from item_mast IM 
INNER JOIN main_cat MC on IM.main_cat_id = MC.id 
INNER JOIN sub_cat SC on IM.sub_cat_id = SC.id"></asp:SqlDataSource>
              
           </div>
            <%-- LOAD WAREHOUSES --%>
        </form>
    </div>
    <a href="/"><h3 class="text-center" style="background-color:#a94442;padding-top:10px;padding-bottom:10px;"><b>GO BACK</b></h3></a>
</body>
</html>