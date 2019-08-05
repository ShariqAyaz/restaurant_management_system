<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bentity_selection.aspx.cs" Inherits="ESIT_ERP.bentity_selection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="/assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/assets/css/jquery-ui.css" rel="stylesheet" />
    <link href="/assets/css/style.css" rel="stylesheet" />
    <script src="/assets/js/jquery-3.4.1.js"></script>
    <script src="/assets/js/jquery-ui.js"></script>
    <script src="/assets/js/bootstrap.min.js"></script>
    <style>
        /* The container */
        .mecontainer {
            display: block;
            position: relative;
            padding:0px;
            margin-bottom: 12px;
            margin-left:40%;
            margin-right:30%;
            cursor: pointer;
            font-size: 22px;
            padding:0 25px 0 45px;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }
        @media(max-width: 856px){
            .mecontainer{
            margin-left:0%;
            margin-right:0%;
            padding:0px;
            padding-left:40px;
            font-size: 17px;
            }
        }
            /* Hide the browser's default radio button */
            .mecontainer input {
                position: absolute;
                opacity: 0;
                padding:0;
                cursor: pointer;
            }

        /* Create a custom radio button */
        .checkmark {
            position: absolute;
            top: 0;
            left: 0;
            height: 30px;
            width: 30px;
            background-color: #eee;
            border-radius: 50%;
        }

        /* On mouse-over, add a grey background color */
        .mecontainer:hover input ~ .checkmark {
            background-color: #ccc;
        }

        /* When the radio button is checked, add a blue background */
        .mecontainer input:checked ~ .checkmark {
            background-color: white;
            border: 1px solid red;
        }

        /* Create the indicator (the dot/circle - hidden when not checked) */
        .checkmark:after {
            content: "";
            position: absolute;
            display: none;
        }

        /* Show the indicator (dot/circle) when checked */
        .mecontainer input:checked ~ .checkmark:after {
            display: block;
        }

        /* Style the indicator (dot/circle) */
        .mecontainer .checkmark:after {
            top: 8px;
            left: 8px;
            width: 12.5px;
            height: 12.5px;
            border-radius: 50%;
            background: red;
        }

        .btncontainer {
            display: flex;
            position: relative;
            cursor: pointer;
            font-size: 25px;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }
    </style>

</head>
<body>
    <div class="container text-center">
    <form id="form1" runat="server" method="post">
        <h1>SELECT YOUR BUSINESS UNIT</h1>
        <%
            foreach (var s in bentity_list)
            {
                bentity_det = null;
                bentity_det = s.Split('|');
                Response.Write("<label class='mecontainer' style=''>" + bentity_det[1] + "<input type='radio' checked='' name='rb_bentity' value='" + bentity_det[0] + "' /><span class='checkmark'></span></label>");
            }
        %>


        </div>
        <div class="container text-center"> 
        <div class="col-md-12 text-center"><input type="submit" name="btnSubmit" class="btncontainer btn btn-danger" style="width:100%;text-align:center" /></div>
            </div>
    </form>
    
</body>
</html>
