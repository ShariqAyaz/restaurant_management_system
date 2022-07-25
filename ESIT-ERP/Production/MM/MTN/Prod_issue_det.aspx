<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prod_issue_det.aspx.cs" Inherits="ESIT_ERP.Production.MM.MTN.Prod_issue_det" %>


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

        function handleEnter(obj, event) {
            document.addEventListener("keydown", function (e) {
                //console.log(e.which);
                //if (e.keyCode == 13) {
                //    e.preventDefault();
                //    alert();
                //    return true;
                //}
            })
            //alert();
            //var keyCode = event.keyCode ? event.keyCode : event.which ? event.which : event.charCode;
            //if (keyCode == 13) {
            //    document.getElementById(obj).click();
            //    return false;
            //}
            //else {
            //    return true;
            //}
        }

        $(document).ready(function () {
            //document.getElementById('DropDownList1').value = '334';
        });
    </script>
</head>
<body>
    <div class=" text-center top-header" style="">
        <h2 class="marginpaddingzero headering-lettersp lato" style="padding: 10px !important;"><a href="/">EateryManager</a></h2>
        <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;">ANWAR BALOCH RESTAURANT</h3>
    </div>
    <h3 class="main-heading text-center headering-lettersp lato"><b>Material Transfer ITEMS ENTRY</b></h3>
    <hr />
    <div class="container breadcrumb">
        <form id="form1" runat="server">

            <div class="col-md-6">
                <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">PRODUCE ITEM NAME</label>
                <asp:DropDownList ID="DropDown_spitem" runat="server" CssClass="form-control" DataSourceID="sp_itemlist" DataTextField="semi_produce_name" DataValueField="id" AutoPostBack="True">
                    <asp:ListItem Text="-Choose Item-" />
                </asp:DropDownList>
                <asp:SqlDataSource ID="sp_itemlist" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT * FROM [semi_produce_item]"></asp:SqlDataSource>
            </div>
            <div class="col-md-6">
                <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">Produce Quantity</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtbProduceQty" placeholder="Rate" >0</asp:TextBox>
            </div>
            <div class="col-md-6">
                <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">Consume Quantity</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="txtbConsumeQty" placeholder="Quantity" >0</asp:TextBox>
            </div>
            <div class="col-md-12">
                <asp:Button runat="server" CssClass="btn btn-danger" Style="width: 100%; margin-top: 25px;" ID="btnAdd" Text="Add" OnClick="btnAdd_Click" />
            </div>
    </div>
    <div class="container breadcrumb">
        <table class="table table-bordered" style="width: 100%;">
            <tr>
                <td>BARCODE</td>
                <td>NAME</td>
                <td>RATE</td>
                <td>QUANTITY</td>
                <td>LINE AMOUNT</td>
                <td>... </td>
            </tr>
            <%
                if (loaditm == true)
                {
                    int ic = 0;
                    foreach (AppLogic.GRN_ITEMS GGI in GI)
                    {
                        Response.Write("<tr class='remove-attr'>");
                        Response.Write("<td>" + GI[ic].ITEMBARCODE + "</td>");
                        Response.Write("<td>" + GI[ic].ITEMNAME + "</td>");
                        Response.Write("<td>" + GI[ic].IRATE + "</td>");
                        Response.Write("<td>" + GI[ic].IQTY + "</td>");
                        Response.Write("<td>" + GI[ic].IAMT + "</td>");
                        Response.Write("<td><a href='/Production/MM/GRN/grn_det.aspx?grnno=" + Session["grnno"] + "&lid=" + GI[ic].LID + "' >X</a></td>");
                        Response.Write("</tr>");
                        ic++;
                    }
                }
            %>
        </table>
    </div>

    <div class="container">
        <div class="col-md-12">
            <asp:Button runat="server" ID="Button2" Text="NEXT" CssClass="btn btn-danger" Style="width: 100%; margin-top: 25px;" OnClick="Button2_Click" />

        </div>
    </div>
    </form>
</body>
</html>
