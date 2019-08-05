<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ESIT_ERP._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8" />
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="assets/css/style.css" rel="stylesheet" />

    <script src="script/jquery-3.4.1.slim.min.js"></script>
    <script src="script/jquery-ui.js"></script>
    <script src="script/bootstrap.min.js"></script>
</head>
<body>
<div class="container text-center">
    <h1 style="color:orangered">ANWAR BALOCH RESTAURANT</h1>
    <h3 style="margin:0px;padding:0px">ESIT-RESTAURANT ERP</h3>
</div>

    <%
        foreach (string s in applist)
        {
            applistdet = null;
            applistdet = s.Split('|');
            //string actionid = (applistdet[5]);
            Response.Write(applistdet[1] + " -> " + "<a href='/"+applistdet[1]+"/"+applistdet[3]+".aspx'>" + applistdet[2] + "</a><br>");
        }
%>
</body>
</html>


