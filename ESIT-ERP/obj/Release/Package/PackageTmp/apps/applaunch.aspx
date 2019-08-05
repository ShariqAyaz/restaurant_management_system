<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="applaunch.aspx.cs" Inherits="ESIT_ERP.apps.applaunch" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8" />
    <link href="../assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../assets/css/style.css" rel="stylesheet" />
    <script src="../script/jquery-3.4.1.slim.min.js"></script>
    <script src="../script/jquery-ui.js"></script>
    <script src="../script/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:GridView ID="grdView" runat="server" class="table" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" ShowFooter="True"  DataKeyNames="id" DataSourceID="SqlDataSource1" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:TemplateField HeaderText="id" SortExpression="id">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("id") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="cat_desc" HeaderText="cat_desc" SortExpression="cat_desc" />
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />

            </Columns>
            
            
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            
            
        </asp:GridView>
        <asp:Button ID="btnAddRow" runat="server" OnClick="btnAddRow_Click" Text="Add Row" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ESIT-ERPConnectionString %>" DeleteCommand="DELETE FROM [wh_cat] WHERE [id] = @original_id AND [cat_desc] = @original_cat_desc" InsertCommand="INSERT INTO [wh_cat] ([cat_desc]) VALUES (@cat_desc)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [wh_cat] ORDER BY [id]" UpdateCommand="UPDATE [wh_cat] SET [cat_desc] = @cat_desc WHERE [id] = @original_id AND [cat_desc] = @original_cat_desc">
            <DeleteParameters>
                <asp:Parameter Name="original_id" Type="Int32" />
                <asp:Parameter Name="original_cat_desc" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="cat_desc" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="cat_desc" Type="String" />
                <asp:Parameter Name="original_id" Type="Int32" />
                <asp:Parameter Name="original_cat_desc" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
