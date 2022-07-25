<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Daily_Back_Process_Report.aspx.cs" Inherits="ESIT_ERP.Reports.Daily_Back_Process_Report" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PIN-MTN - Anwar Baloch - ESIT ERP - Stock Level</title>
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
    <h3 class="main-heading text-center headering-lettersp lato">DAILY KITCHEN PROCESS REPORT</h3>
    <hr />
    <div class="container breadcrumb">
        <form id="form1" runat="server">
            <div class="myinput">
                <div class="col-md-4">
                    <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">Date</label>
                    <asp:TextBox runat="server" ID="txtBox" CssClass="DatePickerCtl form-control" />
                    <asp:HiddenField ID="dateh" runat="server" />
                </div>
                <div class="col">
                    <asp:Button runat="server" CssClass="btn btn-danger" Style="background-color: #a94442;" ID="Button1" Text="VIEW" OnClick="btnBack_Click" Width="100%" />
                </div>
                <br />
                <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;">Sale</h3>
                <br />
                <asp:GridView ID="vid" CssClass="table table-bordered" Width="100%" runat="server" AutoGenerateColumns="False" DataSourceID="SQLDAILYREP" AllowSorting="True">
                    <Columns>
                        <asp:BoundField DataField="WIP-NAME" HeaderText="WIP-NAME" SortExpression="WIP-NAME" />
                        <asp:BoundField DataField="Produce_Qty" HeaderText="Produce_Qty" SortExpression="Produce_Qty" />
                        <asp:BoundField DataField="MCONSUME" HeaderText="MCONSUME" SortExpression="MCONSUME" />
                        <asp:BoundField DataField="Rate/Unit" HeaderText="Rate/Unit" ReadOnly="True" SortExpression="Rate/Unit" />
                        <asp:BoundField DataField="COST" HeaderText="COST" ReadOnly="True" SortExpression="COST" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SQLDAILYREP" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="select wip_item_name [WIP-NAME],wip_produce_qty Produce_Qty,iid_consume_qty MCONSUME,
	cast((select top 1 irate from grn_items_det where iid=WI.iid order by id desc) as decimal(18,2)) [Rate/Unit],
	CAST(iid_consume_qty*(select top 1 irate from grn_items_det where iid=WI.iid order by id desc) as decimal(18,2)) as COST from wip_production WP
INNER JOIN wip_item WI ON WI.id=WP.wip_item_id
	where tdate =@date AND wip_produce_issue=0 AND iid_consume_issue=0 AND wp.b_entity_id=@bid">
                    <SelectParameters>
                        <asp:FormParameter DefaultValue="2019-01-01" FormField="txtBox" Name="date" />
                        <asp:FormParameter DefaultValue="1" FormField="bid" Name="bid" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
                <div class="col">
                    <asp:Button runat="server" CssClass="btn btn-danger" Style="background-color: #a94442;" ID="btnBack" Text="Go Back & Exit REPORT" OnClick="btnBack_Click" Width="100%" />
                </div>
            </div>
        </form>
    </div>
</body>
</html>
