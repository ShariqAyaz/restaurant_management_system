<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="grn_main.aspx.cs" Inherits="ESIT_ERP.Production.MM.GRN.grn_main" %>

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
        $(document).ready(function () {  
            $(".DatePickerCtl").datepicker();
            dtString = $("#<%=dateh.ClientID%>").val();
            dtString = dtString.split(',');
            $(".DatePickerCtl").datepicker('setDate', dtString);
        });
    </script>
</head>
<body>
    <div class=" text-center top-header" style="">
        <h2 class="marginpaddingzero headering-lettersp lato" style="padding: 10px !important;"><a href="/">EateryManager</a></h2>
        <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;">ANWAR BALOCH RESTAURANT</h3>
    </div>
    <h3 class="main-heading text-center headering-lettersp lato"><b>GOOD RECEIPT NOTE ENTRY</b></h3>
    <hr />
    <div class="container breadcrumb">
        <form id="form1" runat="server">
            <div class="myinput">
                <div class="col-md-4">
                    <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">SELECT YOUR VENDOR</label>
                    <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server" DataSourceID="ven_master" DataTextField="VendorName" DataValueField="id">
                        <asp:ListItem Text="-Choose Vendor-" />
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="ven_master" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT * FROM [vendor_master] ORDER BY [VendorName]"></asp:SqlDataSource>
                </div>
                <div class="col-md-4">
                    <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">SUPPLIER INVOICE NO</label>
                    <input runat="server" id="txtbSupInv" class="form-control" type="text" name="txtbSupInv" placeholder="SUPPLIER INVOICE NO" />
                </div>
                <div class="col-md-4">
                    <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">Date</label>
                    <asp:TextBox runat="server" ID="txtBox" CssClass="DatePickerCtl form-control" />
                    <asp:HiddenField ID="dateh" runat="server" />
                </div>
                <div class="col-md-4">
                    <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px" for="txtRemarks">Remarks</label>
                    <asp:TextBox runat="server" ID="txtRemarks" CssClass="form-control" placeholder="Remarks" />
                </div>
                <div class="col-md-8">
                    <asp:Button runat="server" CssClass="btn btn-danger" Style="width: 100%; margin-top: 35px;" ID="btnNext" Text="NEXT" />
                </div>
                <br />
                <br />
                <br />
                <div class="col">
                    <asp:Button runat="server" CssClass="btn btn-danger" Style="background-color: #a94442;" ID="btnBack" Text="Go Back & Exit GRN" OnClick="btnBack_Click" Width="100%" />
                </div>
            </div>
        </form>
    </div>
</body>
</html>
