<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uom.aspx.cs" Inherits="ESIT_ERP.Master.item.uom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Unit Of Measurement - Anwar Baloch - ESIT ERP - Inventory Dashboard</title>
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
    <h3 class="main-heading text-center headering-lettersp lato"><b>Unit Of Measurement</b></h3>
    <hr/>
        
        <form id="frm_main_cat" runat="server" method="post">
    <%
        if (cur_actionid==1)
        {
            %>
            <div class="container breadcrumb" style="">
         <asp:GridView ID="GridView4" CssClass="table table-bordered" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource_esit2" AllowPaging="True">
             <Columns> 
                 <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                 <asp:BoundField DataField="UOM" HeaderText="UOM" SortExpression="UOM" />
                 
             </Columns>
         </asp:GridView>
            
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" DeleteCommand="DELETE FROM [UOM] WHERE [id] = @original_id AND [UOM] = @original_UOM" InsertCommand="INSERT INTO [UOM] ([UOM]) VALUES (@UOM)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [UOM] ORDER BY [UOM]" UpdateCommand="UPDATE [UOM] SET [UOM] = @UOM WHERE [id] = @original_id AND [UOM] = @original_UOM">
             <DeleteParameters>
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_UOM" Type="String" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="UOM" Type="String" />
             </InsertParameters>
             <UpdateParameters>
                 <asp:Parameter Name="UOM" Type="String" />
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_UOM" Type="String" />
             </UpdateParameters>
         </asp:SqlDataSource>
     </div>
            <%
        }else if(cur_actionid==2)
        {
             %>

            <div class="container breadcrumb">
            
            <div class="myinput">
                <asp:Label ID="lblicat2" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="Unit Of Measurement" runat="server"><b class="red-active">Unit Of Measurement</b></asp:Label>
                <div class="input-group-lg input-group-md input-group-sm">
                    <asp:TextBox ID="txtbuom2" runat="server" CssClass="form-control" placeholder="Enter Unit Of Measurement" MaxLength="40"></asp:TextBox>
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
                 <asp:BoundField DataField="UOM" HeaderText="UOM" SortExpression="UOM" />
                 
             </Columns>
         </asp:GridView>
            
         <asp:SqlDataSource ID="SqlDataSource_esit2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" DeleteCommand="DELETE FROM [UOM] WHERE [id] = @original_id AND [UOM] = @original_UOM" InsertCommand="INSERT INTO [UOM] ([UOM]) VALUES (@UOM)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [UOM] ORDER BY [UOM]" UpdateCommand="UPDATE [UOM] SET [UOM] = @UOM WHERE [id] = @original_id AND [UOM] = @original_UOM">
             <DeleteParameters>
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_UOM" Type="String" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="UOM" Type="String" />
             </InsertParameters>
             <UpdateParameters>
                 <asp:Parameter Name="UOM" Type="String" />
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_UOM" Type="String" />
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
                <asp:Label ID="lblicat3" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="email" runat="server"><b class="red-active">Unit Of Measurement</b></asp:Label>
                <div class="input-group-lg input-group-md input-group-sm">
                    <asp:TextBox ID="txtbuom3" runat="server" CssClass="form-control" placeholder="Enter Unit Of Measurement Name" MaxLength="40"></asp:TextBox>
                  <span class="input-group-btn">
                      <asp:Button ID="btnAdd3" runat="server" Text="Add" CssClass="btn btn-danger col-md-12 col-xs-12" style="margin:10px 0;" />
                  </span>
                </div>
            </div>
            
            
        
     </div>

                 <div class="container breadcrumb" style="">
         <asp:GridView ID="GridView3" CssClass="table table-bordered" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource_esit3" AllowPaging="True">
             <Columns>
                 <asp:CommandField ShowEditButton="True" />
                 <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                 <asp:BoundField DataField="UOM" HeaderText="UOM" SortExpression="UOM" />
             </Columns>
         </asp:GridView>
            
         <asp:SqlDataSource ID="SqlDataSource_esit3" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" DeleteCommand="DELETE FROM [UOM] WHERE [id] = @original_id AND [UOM] = @original_UOM" InsertCommand="INSERT INTO [UOM] ([UOM]) VALUES (@UOM)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [UOM] ORDER BY [UOM]" UpdateCommand="UPDATE [UOM] SET [UOM] = @UOM WHERE [id] = @original_id AND [UOM] = @original_UOM">
             <DeleteParameters>
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_UOM" Type="String" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="UOM" Type="String" />
             </InsertParameters>
             <UpdateParameters>
                 <asp:Parameter Name="UOM" Type="String" />
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_UOM" Type="String" />
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
                <asp:Label ID="lblicat4" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="email" runat="server"><b class="red-active">Unit Of Measurement</b></asp:Label>
                <div class="input-group-lg input-group-md input-group-sm">
                    <asp:TextBox ID="txtbuom4" runat="server" CssClass="form-control" placeholder="Enter Unit Of Measurement Name" MaxLength="40"></asp:TextBox>
                  <span class="input-group-btn">
                      <asp:Button ID="btnAdd4" runat="server" Text="Add" CssClass="btn btn-danger col-md-12 col-xs-12" style="margin:10px 0;" />
                  </span>
                </div>
            </div>
            
            
        
     </div>

                 <div class="container breadcrumb" style="">
         <asp:GridView ID="GridView1" CssClass="table table-bordered" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource_esit" AllowPaging="True">
             <Columns>
                 <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                 <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                 <asp:BoundField DataField="UOM" HeaderText="UOM" SortExpression="UOM" />
             </Columns>
         </asp:GridView>
            
         <asp:SqlDataSource ID="SqlDataSource_esit" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" DeleteCommand="DELETE FROM [UOM] WHERE [id] = @original_id AND [UOM] = @original_UOM" InsertCommand="INSERT INTO [UOM] ([UOM]) VALUES (@UOM)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [UOM] ORDER BY [UOM]" UpdateCommand="UPDATE [UOM] SET [UOM] = @UOM WHERE [id] = @original_id AND [UOM] = @original_UOM">
             <DeleteParameters>
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_UOM" Type="String" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="UOM" Type="String" />
             </InsertParameters>
             <UpdateParameters>
                 <asp:Parameter Name="UOM" Type="String" />
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_UOM" Type="String" />
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
