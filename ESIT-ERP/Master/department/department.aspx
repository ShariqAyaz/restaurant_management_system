<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="department.aspx.cs" Inherits="ESIT_ERP.Master.department.department" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vendor - Anwar Baloch - ESIT ERP - Inventory Dashboard</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="/assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/assets/css/style.css" rel="stylesheet" />

    <script src="/script/jquery-3.4.1.slim.min.js"></script>
    <script src="/script/jquery-ui.js"></script>
    <script src="/script/bootstrap.min.js"></script>
</head>
<body>
    <div class=" text-center top-header" style="">
        <h2 class="marginpaddingzero headering-lettersp lato" style="padding:10px !important;"><a href="/">EateryManager</a></h2>
        <h3 class="marginpaddingzero lato red-active" style="background:#d6d6d6;padding:5px !important;">ANWAR BALOCH RESTAURANT</h3>
    </div>
    <h3 class="main-heading text-center headering-lettersp lato"><b>DEPARTMENT</b></h3>
    <hr/>
    <div class="container">
        <form id="frm_wh_location" runat="server" method="post">
            <div class="container breadcrumb">
                <div class="myinput">
                    <div class="col-md-12">
                    <asp:Label ID="lbldept_name" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="dept_name" runat="server"><b class="red-active">Department Name</b></asp:Label>
                    <asp:TextBox ID="txtbdept_name" runat="server" CssClass="form-control" placeholder="Enter Department Name"></asp:TextBox>
                    </div>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </div>
             </div>    
                         <div class="col-md-12 col-sm-12 col-xs-12 text-center">
                <h3 class="main-heading"><b>Department Category Selection</b></h3>
                <asp:RadioButtonList BorderStyle="none" ID="rblDeptCat" runat="server" border="0" DataSourceID="SQLDatasource_DCat" DataTextField="dept_cat" DataValueField="id" RepeatDirection="Horizontal" RepeatLayout="Flow" CssClass="rblist text-center col-md-12 col-sm-12 col-xs-12 breadcrumb" ></asp:RadioButtonList>
                <asp:SqlDataSource ID="SQLDatasource_DCat" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT * FROM [dept_cat]"></asp:SqlDataSource>
            </div>
           
            <div class="clearfix"></div>
                    <span class="input-group-btn text-center">
                        <asp:Button ID="btnAdd2" runat="server" Text="Add" CssClass="btn btn-danger" style="width:97%" />
                    </span>
                    <span class="input-group-btn text-center">
                        <asp:Button ID="btnUpdate2" runat="server" Text="Update" CssClass="btn btn-danger" style="width:97%" Enabled="False" OnClick="btnUpdate2_Click"/>
                    </span>
                    <span class="input-group-btn text-center">
                        <asp:Button ID="btnDel2" runat="server" Text="Delete" CssClass="btn btn-danger"  style="width:97%" Enabled="False" OnClick="btnDel2_Click"/>
                    </span>
            <hr/>

            <%-- LOAD VENDORS --%>
           <div class="container breadcrumb">
            <asp:GridView ID="GridView1" CssClass="table table-bordered" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" InsertVisible="False" />
                    <asp:BoundField DataField="dept_name" HeaderText="dept_name" SortExpression="dept_name" />
                    <asp:BoundField DataField="dept_cat_id" HeaderText="dept_cat_id" SortExpression="dept_cat_id" />
                    <asp:CheckBoxField DataField="isActive" HeaderText="isActive" SortExpression="isActive" />
                    <asp:BoundField DataField="b_entity_id" HeaderText="b_entity_id" SortExpression="b_entity_id" />
                    <asp:BoundField DataField="entity_name" HeaderText="entity_name" SortExpression="entity_name" />
                </Columns>
               </asp:GridView>
              
               <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT DP.id, DP.dept_name, DP.dept_cat_id, DP.isActive, DP.b_entity_id, BE.entity_name  FROM departments AS DP INNER JOIN b_entity BE ON BE.id = DP.b_entity_id Where (isActive = 1) AND (b_entity_id = @bid) ORDER BY dept_name">
                   <SelectParameters>
                       <asp:SessionParameter Name="bid" SessionField="bid" />
                   </SelectParameters>
               </asp:SqlDataSource>
              
           </div>
            <%-- LOAD VENDORS --%>
        </form>
    </div>
    <a href="/"><h3 class="text-center" style="background-color:#a94442;padding-top:10px;padding-bottom:10px;"><b>GO BACK</b></h3></a>
</body>
</html>