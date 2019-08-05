<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vendor.aspx.cs" Inherits="ESIT_ERP.Master.vendor.vendor" %>

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
<body style="background-color:;">
    <div class=" text-center top-header" style="">
        <h2 class="marginpaddingzero headering-lettersp lato" style="padding:10px !important;"><a href="/">EateryManager</a></h2>
        <h3 class="marginpaddingzero lato red-active" style="background:#d6d6d6;padding:5px !important;">ANWAR BALOCH RESTAURANT</h3>
    </div>
    <h3 class="main-heading text-center headering-lettersp lato"><b>VENDOR</b></h3>
    <hr/>
    <div class="container">
        <form id="frm_wh_location" runat="server" method="post">
            <div class="container breadcrumb">
                <div class="myinput">
                    <div class="col-md-4">
                    <asp:Label ID="lbldept_name" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="txtWHName" runat="server"><b class="red-active">Vendor Name</b></asp:Label>
                    <asp:TextBox ID="txtbdept_name" runat="server" CssClass="form-control" placeholder="Enter Vendor Name"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                    <asp:Label ID="lblvendorpersonname" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="txtWHName" runat="server"><b class="red-active">Contact Person Name</b></asp:Label>
                        <asp:TextBox ID="txtbvendorpersonname" runat="server" CssClass="form-control" placeholder="Enter Contact Person Name" required=""></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                    <asp:Label ID="lblvendorpersonphone" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="txtWHName" runat="server"><b class="red-active">Contact Person Phone</b></asp:Label>
                        <asp:TextBox ID="txtbvendorpersonphone" runat="server" CssClass="form-control" placeholder="Enter Contact Person Phone Number" required=""></asp:TextBox>
                    </div>
                    <div class="clearfix" style="margin-top:10px;"></div>
                    <div class="col-md-6">
                    <asp:Label ID="lblvendoraddress" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="txtWHName" runat="server"><b class="red-active">Vendor Address</b></asp:Label>
                        <asp:TextBox ID="txtbvendoraddress" runat="server" CssClass="form-control" placeholder="Enter Vendor Address" required=""></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                    <asp:Label ID="lblvendordescription" CssClass="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" CssStyle="vertical-align:center" for="txtWHName" runat="server"><b class="red-active">Good Description and Type</b></asp:Label>
                        <asp:TextBox ID="txtbvendordescription" runat="server" CssClass="form-control" placeholder="Enter Good Description and Type" required=""></asp:TextBox>
                    </div>
                </div>
             </div>    
             
           

            <div class="clearfix"></div>
                <div class="input-group-md" style="width:100%">
                    <span class="input-group-btn text-center">
                        <asp:Button ID="btnAdd2" runat="server" Text="Add" CssClass="btn btn-danger" style="width:97%" />
                    </span>
                    <span class="input-group-btn text-center">
                        <asp:Button ID="btnUpdate2" runat="server" Text="Update" CssClass="btn btn-danger" style="width:97%" Enabled="False" OnClick="btnUpdate2_Click"/>
                    </span>
                    <span class="input-group-btn text-center">
                        <asp:Button ID="btnDel2" runat="server" Text="Delete" CssClass="btn btn-danger"  style="width:97%" Enabled="False" OnClick="btnDel2_Click"/>
                    </span>
                </div>
            <hr/>

            <%-- LOAD VENDORS --%>
           <div class="container breadcrumb">
            <asp:GridView ID="GridView1" CssClass="table table-bordered" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="VendorName" HeaderText="VendorName" SortExpression="VendorName" />
                    <asp:BoundField DataField="Contact_Person_name" HeaderText="Contact_Person_name" SortExpression="Contact_Person_name" />
                    <asp:BoundField DataField="Contact_Person_Phone" HeaderText="Contact_Person_Phone" SortExpression="Contact_Person_Phone" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="goods_desc" HeaderText="goods_desc" SortExpression="goods_desc" />
                </Columns>
               </asp:GridView>
              
               <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT * FROM [vendor_master]"></asp:SqlDataSource>
              
           </div>
            <%-- LOAD VENDORS --%>
        </form>
    </div>
    <a href="/"><h3 class="text-center" style="background-color:#a94442;padding-top:10px;padding-bottom:10px;"><b>GO BACK</b></h3></a>
</body>
</html>