<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="DemoThemSuaXoa._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 251px;
        }

        .auto-style2 {
            margin-bottom: 16px;
        }
    </style>
</head>
<body style="height: 339px">
    <form id="form1" runat="server">
        <div class="auto-style1">

            <asp:GridView ID="grvLoaiHang" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" CssClass="auto-style2" ForeColor="Black" GridLines="None" Height="262px" ShowFooter="True" Width="775px" OnRowCancelingEdit="grvLoaiHang_RowCancelingEdit" OnRowDeleting="grvLoaiHang_RowDeleting" OnRowEditing="grvLoaiHang_RowEditing" OnRowUpdating="grvLoaiHang_RowUpdating">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:BoundField DataField="MaLoai" HeaderText="Mã loại" />
                    <asp:BoundField DataField="TenLoai" HeaderText="Tên loại" />
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:TemplateField>
                        <FooterTemplate class="left">
                            <asp:TextBox ID="txtMaLoai" runat="server"></asp:TextBox>
                            <asp:TextBox ID="txtTenLoai" runat="server"></asp:TextBox>
                            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                        </FooterTemplate>
                    </asp:TemplateField>
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

        </div>
    </form>
</body>
</html>
