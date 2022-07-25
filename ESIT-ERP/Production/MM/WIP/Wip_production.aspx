<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wip_production.aspx.cs" Inherits="ESIT_ERP.Production.MM.WIP.Wip_production" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PIN-MTN - Anwar Baloch - ESIT ERP - NEW PRODUCTION NOTE</title>
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
    <h3 class="main-heading text-center headering-lettersp lato"><b>WIP PRODUCTION ENTRY</b></h3>
    <hr />
    <div class="container breadcrumb">
        <form id="form1" runat="server">
            <div class="myinput">
                <div class="col-md-4">
                    <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">SELECT FROM WAREHOUSE</label>
                    <asp:DropDownList CssClass="form-control" ID="DropDown_warehouse" runat="server" DataSourceID="wh_list" DataTextField="wh_name" DataValueField="id">
                        <asp:ListItem Text="-Choose Warehouse-" />
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="wh_list" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT * FROM [warehouse] WHERE ([b_entity_id] = @b_entity_id) ORDER BY [wh_name]">
                        <SelectParameters>
                            <asp:SessionParameter Name="b_entity_id" SessionField="bid" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
                <div class="col-md-4">
                    <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">SELECT TO DEPARTMENT</label>
                    <asp:DropDownList CssClass="form-control" ID="DropDown_dept" runat="server" DataSourceID="dept_list" DataTextField="dept_name" DataValueField="id">
                        <asp:ListItem Text="-Choose Department-" />
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="dept_list" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT * FROM [departments] WHERE ([b_entity_id] = @b_entity_id)">
                        <SelectParameters>
                            <asp:SessionParameter Name="b_entity_id" SessionField="bid" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
                <div class="col-md-4">
                    <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px; top: 0px; left: 0px;">SELECT ITEM</label>
                    <asp:DropDownList CssClass="form-control" ID="DropDown_item" runat="server" DataSourceID="item_list" DataTextField="iname" DataValueField="id">
                        <asp:ListItem Text="-Choose Item-" />
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="item_list" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT * FROM [item_mast] ORDER BY [iname]"></asp:SqlDataSource>
                </div>
                                <div class="col-md-4">
                    <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">SELECT WIP ITEM</label>
                    <asp:DropDownList CssClass="form-control" ID="DropDown_wiplist" runat="server" DataSourceID="SqlWIPLIST" DataTextField="wip_item_name" DataValueField="id">
                        <asp:ListItem Text="-Choose WIP Item-" />
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlWIPLIST" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT * FROM [wip_item] ORDER BY [wip_item_name]"></asp:SqlDataSource>
                </div>
                <div class="col-md-4">
                    <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">Date</label>
                    <asp:TextBox runat="server" ID="txtBox" CssClass="DatePickerCtl form-control" />
                    <asp:HiddenField ID="dateh" runat="server" />
                </div>
                <div class="col-md-4">
                    <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px" for="txtbwipproduce">WIP PRODUCE QTY (PC's / KG / ETC...)</label>
                    <asp:TextBox runat="server" ID="txtbwipproduce" CssClass="form-control" placeholder="WIP PRODUCE QTY" >0</asp:TextBox>
                </div>
                <div class="col-md-4">
                    <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px" for="txtpiidconsume">ITEM CONSUME QTY (PC's / KG / ETC...)</label>
                    <asp:TextBox runat="server" ID="txtpiidconsume" CssClass="form-control" placeholder="ITEM CONSUME QTY" >0</asp:TextBox>
                </div>
                <div class="col-md-4">
                    <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px" for="txtRemarks">Remarks</label>
                    <asp:TextBox runat="server" ID="txtRemarks" CssClass="form-control" placeholder="Remarks" >-</asp:TextBox>
                </div>
                <div class="col-md-8">
                    <asp:Button runat="server" CssClass="btn btn-danger" Style="width: 100%; margin-top: 35px;" ID="btnNext" Text="POST" OnClick="btnNext_Click" />
                </div>
                <br />
                <br />
                <br />
                <div class="col">
                    <asp:Button runat="server" CssClass="btn btn-danger" Style="background-color: #a94442;" ID="btnBack" Text="Go Back &amp; Exit WIP Production" OnClick="btnBack_Click" Width="100%" />
                </div>
            </div>
        </form>
    </div>
</body>
</html>
