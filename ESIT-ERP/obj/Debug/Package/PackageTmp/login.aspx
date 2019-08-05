<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ESIT_ERP.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login - Anwar Baloch - ESIT ERP</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="/assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/assets/css/style.css" rel="stylesheet" />

    <script src="/script/jquery-3.4.1.slim.min.js"></script>
    <script src="/script/jquery-ui.js"></script>
    <script src="/script/bootstrap.min.js"></script>
</head>
<body style="background-color: ;">
    <div class=" text-center top-header" style="">
        <h2 class="marginpaddingzero headering-lettersp lato" style="padding: 10px !important;"><a href="/">EateryManager</a></h2>
        <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;">ANWAR BALOCH RESTAURANT</h3>
    </div>

    <div class="container text-center">
        <h1 class="text-center">Login</h1>
        <div class="login-form">
            <form id="formlogin" runat="server">
                <asp:TextBox ID="txtbUsername" runat="server" Text="" placeholder="Enter Your Username or User ID" CssClass="form-control"></asp:TextBox>
                <div class="clearfix"></div>
                <asp:TextBox ID="txtbPassword" type="password" runat="server" Text="" placeholder="Enter Your Password" CssClass="form-control"></asp:TextBox>
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-danger login-btn" OnClick="btnLogin_Click" />
            </form>
        </div>
    </div>

    <footer class="text-center footerdesign">
        <b>&COPY; All Right Reserved 2019 - Anwar Baloch ERP Management System by </b><strong><a href="https://esolintime.com" style="font-weight: 300 !important;">ESOLINTIME</a></strong>
    </footer>
</body>
</html>
