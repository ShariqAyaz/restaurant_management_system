<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dept_cat.aspx.cs" Inherits="ESIT_ERP.Master.department.dept_cat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Department Category - Anwar Baloch - ESIT ERP - Inventory Dashboard</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
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
    <h3 class="main-heading text-center headering-lettersp lato"><b>DEPARTMENT CATEGORY</b></h3>
    <hr/>
        
        <form id="frm_department" runat="server" method="post">
    <%
        if (cur_actionid==1)
        {
            %>
            <div class="container breadcrumb" style="">
         <asp:GridView ID="GridView4" CssClass="table table-bordered" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource_esit2" AllowPaging="True">
             <Columns>
                 <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                 <asp:BoundField DataField="dept_cat" HeaderText="Department Category" SortExpression="dept_cat" />
                 
             </Columns>
         </asp:GridView>
            
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [dept_cat]">
         </asp:SqlDataSource>
     </div>
            <%
        }else if(cur_actionid==2)
        {
             %>

            <div class="container breadcrumb">
            
            <div class="myinput">
                <asp:Label ID="lbldeptcat2" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="email" runat="server"><b class="red-active">Department Category</b></asp:Label>
                <div class="input-group-lg input-group-md input-group-sm">
                    <asp:TextBox ID="txtbdeptcat2" runat="server" CssClass="form-control" placeholder="Enter Department Category" MaxLength="40"></asp:TextBox>
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
                 <asp:BoundField DataField="dept_cat" HeaderText="Department Category" SortExpression="dept_cat" />
                 
             </Columns>
         </asp:GridView>
            
         <asp:SqlDataSource ID="SqlDataSource_esit2" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" DeleteCommand="DELETE FROM [dept_cat] WHERE [id] = @original_id AND [dept_cat] = @original_dept_cat" InsertCommand="INSERT INTO [dept_cat] ([dept_cat]) VALUES (@dept_cat)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [dept_cat] ORDER BY [id] DESC" UpdateCommand="UPDATE [dept_cat] SET [dept_cat] = @dept_cat WHERE [id] = @original_id AND [dept_cat] = @original_dept_cat">
             <DeleteParameters>
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_dept_cat" Type="String" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="dept_cat" Type="String" />
             </InsertParameters>
             <UpdateParameters>
                 <asp:Parameter Name="dept_cat" Type="String" />
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_dept_cat" Type="String" />
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
                <asp:Label ID="lbldeptcat3" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="email" runat="server"><b class="red-active">Department Category</b></asp:Label>
                <div class="input-group-lg input-group-md input-group-sm">
                    <asp:TextBox ID="txtbdeptcat3" runat="server" CssClass="form-control" placeholder="Enter Department Category" MaxLength="40"></asp:TextBox>
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
                 <asp:BoundField DataField="dept_cat" HeaderText="Department Category" SortExpression="dept_cat" />
                 <asp:CommandField ShowDeleteButton="False" ShowEditButton="True"  HeaderText="Edit" />
             </Columns>
         </asp:GridView>
            
         <asp:SqlDataSource ID="SqlDataSource_esit3" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" DeleteCommand="DELETE FROM [dept_cat] WHERE [id] = @original_id AND [dept_cat] = @original_dept_cat" InsertCommand="INSERT INTO [dept_cat] ([dept_cat]) VALUES (@dept_cat)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [dept_cat] ORDER BY [id] DESC" UpdateCommand="UPDATE [dept_cat] SET [dept_cat] = @dept_cat WHERE [id] = @original_id AND [dept_cat] = @original_dept_cat">
             <DeleteParameters>
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_dept_cat" Type="String" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="dept_cat" Type="String" />
             </InsertParameters>
             <UpdateParameters>
                 <asp:Parameter Name="dept_cat" Type="String" />
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_dept_cat" Type="String" />
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
                <asp:Label ID="lbldeptcat4" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="email" runat="server"><b class="red-active">Department Category</b></asp:Label>
                <div class="input-group-lg input-group-md input-group-sm">
                    <asp:TextBox ID="txtbdeptcat4" runat="server" CssClass="form-control" placeholder="Enter Department Category" MaxLength="40"></asp:TextBox>
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
                 <asp:BoundField DataField="dept_cat" HeaderText="Department Category" SortExpression="dept_cat" />
                 <asp:CommandField ShowDeleteButton="True" ShowEditButton="True"  HeaderText="Edit / Delete" />
             </Columns>
         </asp:GridView>
            
         <asp:SqlDataSource ID="SqlDataSource_esit" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" DeleteCommand="DELETE FROM [dept_cat] WHERE [id] = @original_id AND [dept_cat] = @original_dept_cat" InsertCommand="INSERT INTO [dept_cat] ([dept_cat]) VALUES (@dept_cat)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [dept_cat] ORDER BY [id] DESC" UpdateCommand="UPDATE [dept_cat] SET [dept_cat] = @dept_cat WHERE [id] = @original_id AND [dept_cat] = @original_dept_cat">
             <DeleteParameters>
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_dept_cat" Type="String" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="dept_cat" Type="String" />
             </InsertParameters>
             <UpdateParameters>
                 <asp:Parameter Name="dept_cat" Type="String" />
                 <asp:Parameter Name="original_id" Type="Int32" />
                 <asp:Parameter Name="original_dept_cat" Type="String" />
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