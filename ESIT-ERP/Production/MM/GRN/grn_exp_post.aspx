<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="grn_exp_post.aspx.cs" Inherits="ESIT_ERP.Production.MM.GRN.grn_exp_post" %>

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
    <form id="form1" runat="server">
        <div class="container breadcrumb">
            <div class="col-md-6">
            <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">Expense Description</label>
            <asp:TextBox class="form-control" runat="server" ID="txtbDesc" placeholder="Expense Description" />
            </div>
            <div class="col-md-6">
            <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">Expense Amount</label>
            <asp:TextBox class="form-control" runat="server" ID="txtbExpAmt" placeholder="Amount" />
            </div>
            <div class="col-md-12">
            <asp:Button runat="server" style="margin-top:25px;width:100%;" CssClass="btn btn-danger" ID="btn_post" Text="Post GRN" OnClick="btnPost_Click" />
            </div>
        </div>
    </form>
</body>
</html>
