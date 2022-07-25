<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Itemwise_purchase_report.aspx.cs" Inherits="ESIT_ERP.Reports.Supplier.Itemwise_purchase_report" %>

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
        //$(document).ready(function () {  
          //  $(".DatePickerCtl").datepicker();
          //  dtString = $("#////<%//=//dateh.ClientID%>").val();
            //dtString = dtString.split(',');
            //$(".DatePickerCtl").datepicker('setDate', dtString);
        //});
    </script>
</head>
<body>
    <div class=" text-center top-header" style="">
        <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;">ITEM WISE PURCHASE REPORT</h3>
    </div>
    <div class="container breadcrumb">
        <form id="form1" runat="server">
<div class="col-md-6">
                <label class="control-label col-lg-12 col-md-12 col-sm-12 col-xs-12 padding-5 red-active text-center" style="margin-right: 5px">ITEM NAME</label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" DataSourceID="item_mast" DataTextField="iname" DataValueField="id" AutoPostBack="True">
                    <asp:ListItem Text="-Choose Item-" />
                </asp:DropDownList>
                <asp:SqlDataSource ID="item_mast" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT id AS id,iname as iname FROM [item_mast] ORDER BY [iname]"></asp:SqlDataSource>
            </div>
            <div class="col-md-12">
                <asp:Button runat="server" CssClass="btn btn-danger" Style="width: 100%; margin-top: 25px;" ID="btnSearch" Text="View" OnClick="btnSearch_Click" />
            </div><br />
            <div class="col-md-12"><br />
            <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;"><% Response.Write(this.getiname(Convert.ToInt32(Request.QueryString["iid"]))); %></h3>
    </div>
            <asp:GridView ID="GridView1"  CssClass="table table-bordered" style="margin:0px;padding:0px" runat="server" AutoGenerateColumns="False" DataSourceID="sqlItemWiseReport">
                <Columns>
                    <asp:BoundField DataField="GR No" HeaderText="GR No" SortExpression="GR No" />
                    <asp:BoundField DataField="Purchase Date" HeaderText="GR Date" SortExpression="Purchase Date" >
                    <HeaderStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Vender Name" HeaderText="Supplier" SortExpression="Vender Name" />
                    <asp:BoundField DataField="Item Rate" HeaderText="Rate" SortExpression="Item Rate" />
                    <asp:BoundField DataField="Item Qty" HeaderText="Qty" SortExpression="Item Qty" />
                    <asp:BoundField DataField="Line Amount" HeaderText="Amount" ReadOnly="True" SortExpression="Line Amount" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="sqlItemWiseReport" runat="server" ConnectionString="<%$ ConnectionStrings:ESITERPConnectionString %>" SelectCommand="SELECT [GR No],cast([Purchase Date] as date) as [Purchase Date],[Vender Name],[Supplier Invoice],CAST([Item Rate] AS decimal(18,0)) [Item Rate],CAST([Item Qty] AS DECIMAL(18,0)) [Item Qty],CAST([Line Amount] AS decimal) [Line Amount],[iid],[b_entity_id] FROM [GRN_REPORT] WHERE (([iid] = @iid) AND ([b_entity_id] = @b_entity_id))">
                                <SelectParameters>
                    <asp:QueryStringParameter Name="iid" QueryStringField="iid" Type="Int32" />
                    <asp:SessionParameter Name="b_entity_id" SessionField="bid" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <div class=" text-center top-header" style="">
        <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;"><% Response.Write("TOTAL QUANTITY: " + this.totalqty(Session["bid"].ToString(),Request.QueryString["iid"])); %></h3>
    </div>
                        <div class=" text-center top-header" style="">
        <h3 class="marginpaddingzero lato red-active" style="background: #d6d6d6; padding: 5px !important;"><% Response.Write("TOTAL AMOUNT: " + this.totalamt(Session["bid"].ToString(),Request.QueryString["iid"])); %></h3>
    </div>

                            <br />
                <div class="col">
                    <asp:Button runat="server" CssClass="btn btn-danger" Style="background-color: #a94442;" ID="btnBack" Text="Go Back & Exit REPORT" OnClick="btnBack_Click" Width="100%" />
                </div>
        </form>
    </div>
</body>
</html>
