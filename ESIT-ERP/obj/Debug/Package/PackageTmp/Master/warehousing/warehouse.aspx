<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="warehouse.aspx.cs" Inherits="ESIT_ERP.Master.warehousing.warehouse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Warehouse - Anwar Baloch - ESIT ERP - Inventory Dashboard</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="/assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/assets/css/style.css" rel="stylesheet" />

    <script src="/script/jquery-3.4.1.slim.min.js"></script>
    <script src="/script/jquery-ui.js"></script>
    <script src="/script/bootstrap.min.js"></script>
</head>
<body style="background-color:;">
    <div class=" text-center top-header" style="">
        <h2 class="marginpaddingzero headering-lettersp lato" style="padding:10px !important;"><a href="/">EateryManager</a></h2>
        <h3 class="marginpaddingzero lato red-active" style="background:#d6d6d6;padding:5px !important;">ANWAR BALOCH RESTAURANT</h3>
    </div>
    <h3 class="main-heading text-center headering-lettersp lato"><b>WAREHOUSE</b></h3>
    <hr/>
    <div class="container">
        <form id="frm_wh_location" runat="server" method="post">
            <div class="container breadcrumb">
                <div class="myinput">
                    <asp:Label ID="lblWHName" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="txtWHName" runat="server"><b class="red-active">Warehouse Name</b></asp:Label>
                    <div class="input-group-lg input-group-md input-group-sm">
                        <asp:TextBox ID="txtWHName" runat="server" CssClass="form-control" placeholder="Enter Warehouse Name" ></asp:TextBox>
                        <span class="input-group-btn">
                              <asp:Button ID="x1" runat="server" Text="" CssClass="btn btn-danger disabled hidden-lg hidden-md hidden-sm hidden-xs" disabled="" CssStyle="margin:10px 0;padding:0;" />
                        </span>
                    </div>
                </div>
                <div class="clearfix"></div>
                <div class="myinput">
                    <asp:Label ID="lblWHDesc" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="lblWHDesc" runat="server"><b class="red-active">Warehouse Description</b></asp:Label>
                    <div class="input-group-lg input-group-md input-group-sm">
                        <asp:TextBox ID="txtWHDesc" runat="server" CssClass="form-control" placeholder="Enter Warehouse Description"></asp:TextBox>
                      <span class="input-group-btn">
                          <asp:Button ID="x2" runat="server" Text="" CssClass="btn btn-danger disabled hidden-lg hidden-md hidden-sm hidden-xs" disabled="" CssStyle="margin:10px 0;padding:0;" />
                      </span>
                    </div>
                </div>
             </div>    
             
            <div class="col-md-6 col-sm-6 col-xs-12 text-center">
                <h3 class="main-heading"><b>Category Selection</b></h3>
                <asp:RadioButtonList BorderStyle="none" ID="rblCAT" runat="server" border="0" DataSourceID="SQLDatasource_Cat" DataTextField="cat_desc" DataValueField="id" RepeatDirection="Horizontal" RepeatLayout="Flow" CssClass="rblist text-center col-md-12 col-sm-12 col-xs-12 breadcrumb" ></asp:RadioButtonList>
                <asp:SqlDataSource ID="SQLDatasource_Cat" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT * FROM [wh_cat] ORDER BY [cat_desc] DESC"></asp:SqlDataSource>
            </div>
            <div class="col-md-6 col-sm-6 col-xs-12 text-center">
                <h3 class="main-heading"><b>Type Selection</b></h3>
                <asp:RadioButtonList BorderStyle="none" ID="rblType" runat="server" border="0" DataSourceID="SQLDatasource_type" DataTextField="type" DataValueField="id" RepeatDirection="Horizontal" RepeatLayout="Flow" CssClass="rblist text-center col-md-12 col-sm-12 col-xs-12 breadcrumb" ></asp:RadioButtonList>
                <asp:SqlDataSource ID="SQLDatasource_Type" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT * FROM [wh_type] ORDER BY [type] DESC"></asp:SqlDataSource>
            </div>
            <div class="clearfix"></div>
            <div class="col-md-12 col-sm-12 col-xs-12 text-center">
                <h3 class="main-heading"><b>Location Selection</b></h3>
                <asp:RadioButtonList BorderStyle="none" ID="rblLocation" runat="server" border="0" DataSourceID="SQLDatasource_location" DataTextField="location" DataValueField="id" RepeatDirection="Horizontal" RepeatLayout="Flow" CssClass="rblist text-center col-md-12 col-sm-12 col-xs-12 breadcrumb" ></asp:RadioButtonList>
                <asp:SqlDataSource ID="SQLDatasource_location" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT wh_location.id as id,wh_location.location+' - '+b_entity.entity_name as location FROM [wh_location] INNER JOIN b_entity ON b_entity.id=wh_location.b_entity_id order by wh_location.location "></asp:SqlDataSource>
            </div>
            <div class="clearfix"></div>
                <div class="input-group-md" style="width:100%">
                    <span class="input-group-btn text-center">
                        <asp:Button ID="btnAdd2" runat="server" Text="Add" CssClass="btn btn-danger" style="width:97%"/>
                    </span>
                    <span class="input-group-btn text-center">
                        <asp:Button ID="btnUpdate2" runat="server" Text="Update" CssClass="btn btn-danger" style="width:97%" Enabled="False" OnClick="btnUpdate2_Click"/>
                    </span>
                    <span class="input-group-btn text-center">
                        <asp:Button ID="btnDel2" runat="server" Text="Delete" CssClass="btn btn-danger" style="width:97%" Enabled="False" OnClick="btnDel2_Click"/>
                    </span>
                </div>
            <hr/>
            <%-- LOAD WAREHOUSES --%>
           <div class="container breadcrumb">
            <asp:GridView ID="GridView1" CssClass="table table-bordered" runat="server" AutoGenerateColumns="False" DataKeyNames="WHID" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="WHID" HeaderText="WHID" InsertVisible="False" ReadOnly="True" SortExpression="WHID" />
                    <asp:BoundField DataField="WHNAME" HeaderText="WHNAME" SortExpression="WHNAME" />
                    <asp:BoundField DataField="WHDESC" HeaderText="WHDESC" SortExpression="WHDESC" />
                    <asp:BoundField DataField="WHLOCATION" HeaderText="WHLOCATION" SortExpression="WHLOCATION" />
                    <asp:BoundField DataField="WHTYPE" HeaderText="WHTYPE" SortExpression="WHTYPE" />
                    <asp:BoundField DataField="WHCAT" HeaderText="WHCAT" SortExpression="WHCAT" />
                    <asp:BoundField DataField="ENTITYNAME" HeaderText="ENTITYNAME" SortExpression="ENTITYNAME" />
                </Columns>
               </asp:GridView>
              
               <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT WH.id AS WHID, WH.wh_name AS WHNAME, WH.wh_desc AS WHDESC, WL.location AS WHLOCATION, WT.type AS WHTYPE, WC.cat_desc AS WHCAT, BE.entity_name AS ENTITYNAME FROM warehouse AS WH INNER JOIN wh_type AS WT ON WH.type_id = WT.id INNER JOIN wh_location AS WL ON WH.location_id = WL.id INNER JOIN wh_cat AS WC ON WC.id = WH.cat_id INNER JOIN b_entity AS BE ON WH.b_entity_id = BE.id WHERE (WH.isActive = 1) AND (WH.b_entity_id = @bid)">
                   <SelectParameters>
                       <asp:SessionParameter Name="bid" SessionField="bid" />
                   </SelectParameters>
               </asp:SqlDataSource>
              
           </div>
            <%-- LOAD WAREHOUSES --%>
        </form>
    </div>
    <a href="/"><h3 class="text-center" style="background-color:#a94442;padding-top:10px;padding-bottom:10px;"><b>GO BACK</b></h3></a>
</body>
</html>