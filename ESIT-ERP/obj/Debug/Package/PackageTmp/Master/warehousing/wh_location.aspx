<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wh_location.aspx.cs" Inherits="ESIT_ERP.Master.warehousing.wh_location" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Warehouse Location - Anwar Baloch - ESIT ERP - Inventory Dashboard</title>
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
    <h3 class="main-heading text-center headering-lettersp lato"><b>WAREHOUSE LOCATION</b></h3>
    <hr/>
        
        <form id="frm_wh_location" runat="server" method="post">
    <%
        if (cur_actionid==1)
        {
            %>
            <div class="container breadcrumb" style="">
         <asp:GridView ID="GridView4" CssClass="table table-bordered" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource_esit2" AllowPaging="True">
             <Columns>
                 <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                 <asp:BoundField DataField="location" HeaderText="Warehouse Location" SortExpression="location" />
                 
             </Columns>
         </asp:GridView>
            
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" DeleteCommand="DELETE FROM [wh_location] WHERE [id] = @original_id AND [location] = @original_location" InsertCommand="INSERT INTO [wh_location] ([location]) VALUES (@location)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [wh_location] WHERE b_entity_id=@bid ORDER BY [id] DESC" UpdateCommand="UPDATE [wh_location] SET [location] = @location WHERE [id] = @original_id AND [location] = @original_location">
             <DeleteParameters>
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_location" Type="String" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="location" Type="String" />
             </InsertParameters>
             <SelectParameters>
                 <asp:SessionParameter Name="bid" SessionField="bid" />
             </SelectParameters>
             <UpdateParameters>
                 <asp:Parameter Name="location" Type="String" />
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_location" Type="String" />
             </UpdateParameters>
         </asp:SqlDataSource>
     </div>
            <%
        }else if(cur_actionid==2)
        {
             %>

            <div class="container breadcrumb">
            
            <div class="myinput">
                <asp:Label ID="lblcatdesc2" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="email" runat="server"><b class="red-active">location</b></asp:Label>
                <div class="input-group-lg input-group-md input-group-sm">
                    <asp:TextBox ID="txtbcatdesc2" runat="server" CssClass="form-control" placeholder="Enter location Name" MaxLength="40"></asp:TextBox>
                  <span class="input-group-btn">
                      <asp:Button ID="btnAdd2" runat="server" Text="Add" CssClass="btn btn-danger col-md-12 col-xs-12" style="margin:10px 0;" />
                  </span>
                </div>
            </div>
        
     </div>

                 <div class="container breadcrumb" style="">
         <asp:GridView ID="GridView2" CssClass="table table-bordered" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource_esit2" AllowPaging="True">
             <Columns>
                 <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                 <asp:BoundField DataField="location" HeaderText="Warehouse location" SortExpression="location" />
                 
             </Columns>
         </asp:GridView>
            
         <asp:SqlDataSource ID="SqlDataSource_esit2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" DeleteCommand="DELETE FROM [wh_location] WHERE [id] = @original_id AND [location] = @original_location" InsertCommand="INSERT INTO [wh_location] ([location]) VALUES (@location)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [wh_location] WHERE B_ENTITY_iD=@BID ORDER BY [id] DESC" UpdateCommand="UPDATE [wh_location] SET [location] = @location WHERE [id] = @original_id AND [location] = @original_location">
             <DeleteParameters>
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_location" Type="String" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="location" Type="String" />
             </InsertParameters>
             <SelectParameters>
                 <asp:SessionParameter Name="BID" SessionField="bid" />
             </SelectParameters>
             <UpdateParameters>
                 <asp:Parameter Name="location" Type="String" />
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_location" Type="String" />
             </UpdateParameters>
         </asp:SqlDataSource>
     </div>


            <%
        }
        else if(cur_actionid==3)
        {
            %>

            <div class="container breadcrumb">
            
            <div class="myinput">
                <asp:Label ID="lblcatdesc3" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="email" runat="server"><b class="red-active">location</b></asp:Label>
                <div class="input-group-lg input-group-md input-group-sm">
                    <asp:TextBox ID="txtbcatdesc3" runat="server" CssClass="form-control" placeholder="Enter location Name" MaxLength="40"></asp:TextBox>
                  <span class="input-group-btn">
                      <asp:Button ID="btnAdd3" runat="server" Text="Add" CssClass="btn btn-danger col-md-12 col-xs-12" style="margin:10px 0;" />
                  </span>
                </div>
            </div>
            
            
        
     </div>

                 <div class="container breadcrumb" style="">
         <asp:GridView ID="GridView3" CssClass="table table-bordered" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource_esit3" AllowPaging="True">
             <Columns>
                 <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                 <asp:BoundField DataField="location" HeaderText="Warehouse location" SortExpression="location" />
                 <asp:CommandField ShowDeleteButton="False" ShowEditButton="True"  HeaderText="Edit" />
             </Columns>
         </asp:GridView>
            
         <asp:SqlDataSource ID="SqlDataSource_esit3" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" DeleteCommand="DELETE FROM [wh_location] WHERE [id] = @original_id AND [location] = @original_location" InsertCommand="INSERT INTO [wh_location] ([location]) VALUES (@location)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [wh_location] WHERE B_ENTITY_iD=@BID ORDER BY [id] DESC" UpdateCommand="UPDATE [wh_location] SET [location] = @location WHERE [id] = @original_id AND [location] = @original_location">
             <DeleteParameters>
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_location" Type="String" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="location" Type="String" />
             </InsertParameters>
             <SelectParameters>
                 <asp:SessionParameter Name="BID" SessionField="bid" />
             </SelectParameters>
             <UpdateParameters>
                 <asp:Parameter Name="location" Type="String" />
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_location" Type="String" />
             </UpdateParameters>
         </asp:SqlDataSource>
     </div>


            <%
        }
        else if(cur_actionid==4)
        {
            %>

            <div class="container breadcrumb">
            
            <div class="myinput">
                <asp:Label ID="lblcatdesc4" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="email" runat="server"><b class="red-active">location</b></asp:Label>
                <div class="input-group-lg input-group-md input-group-sm">
                    <asp:TextBox ID="txtbcatdesc4" runat="server" CssClass="form-control" placeholder="Enter location Name" MaxLength="40"></asp:TextBox>
                  <span class="input-group-btn">
                      <asp:Button ID="btnAdd4" runat="server" Text="Add" CssClass="btn btn-danger col-md-12 col-xs-12" style="margin:10px 0;" />
                  </span>
                </div>
            </div>
            
            
        
     </div>

                 <div class="container breadcrumb" style="">
         <asp:GridView ID="GridView1" CssClass="table table-bordered" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource_esit" AllowPaging="True">
             <Columns>
                 <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                 <asp:BoundField DataField="location" HeaderText="Warehouse location" SortExpression="location" />
                 <asp:CommandField ShowDeleteButton="True" ShowEditButton="True"  HeaderText="Edit / Delete" />
             </Columns>
         </asp:GridView>
            
         <asp:SqlDataSource ID="SqlDataSource_esit" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" DeleteCommand="DELETE FROM [wh_location] WHERE [id] = @original_id AND [location] = @original_location" InsertCommand="INSERT INTO [wh_location] ([location]) VALUES (@location)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [wh_location] WHERE B_ENTITY_iD=@BID ORDER BY [id] DESC" UpdateCommand="UPDATE [wh_location] SET [location] = @location WHERE [id] = @original_id AND [location] = @original_location">
             <DeleteParameters>
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_location" Type="String" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="location" Type="String" />
             </InsertParameters>
             <SelectParameters>
                 <asp:SessionParameter Name="BID" SessionField="bid" />
             </SelectParameters>
             <UpdateParameters>
                 <asp:Parameter Name="location" Type="String" />
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_location" Type="String" />
             </UpdateParameters>
         </asp:SqlDataSource>
     </div>
            <%
        }
         %>
        </form>
        <a href="/"><h3 class="text-center" style="background-color:#a94442;padding-top:10px;padding-bottom:10px;"><b>GO BACK</b></h3></a>

</body>
</html>