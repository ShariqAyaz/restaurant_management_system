<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ESIT_ERP._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Anwar Baloch - ESIT ERP - Inventory Dashboard</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="assets/css/style.css" rel="stylesheet" />

    <script src="script/jquery-3.4.1.slim.min.js"></script>
    <script src="script/jquery-ui.js"></script>
    <script src="script/bootstrap.min.js"></script>
</head>
<body style="">
    <div class=" text-center top-header" style="">
        <h2 class="marginpaddingzero headering-lettersp lato" style="padding: 10px !important;"><a href="/">EateryManager</a></h2>
        <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;">ANWAR BALOCH RESTAURANT</h3>
    </div>
    <h3 class="main-heading text-center  headering-lettersp lato"><b>Main Menu</b></h3>
    <hr />
    <div class="container">
        <%
            foreach (string s in applist)
            {
                applistdet = null;
                applistdet = s.Split('|');
                //string actionid = (applistdet[5]);
                Response.Write("<a href='" + applistdet[3] + ".aspx'><div class='breadcrumb' style=''>" + applistdet[1] + " <span class='glyphicon glyphicon-chevron-right red-active'></span> " + "" + applistdet[2] + "<br></div></a>");
            }
        %>
    </div>
</body>
</html>
