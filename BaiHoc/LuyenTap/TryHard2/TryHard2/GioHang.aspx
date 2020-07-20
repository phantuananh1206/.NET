<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="TryHard2.GioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grvGioHang" runat="server" AutoGenerateColumns="False" ShowFooter="True" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="MaThietBi" HeaderText="Mã thiết bị" />
            <asp:BoundField DataField="TenThietBi" HeaderText="Tên thiết bị" />
            <asp:BoundField DataField="DonGia" HeaderText="Đơn giá" />
            <asp:BoundField DataField="SoLuong" HeaderText="Số lượng" />
            <asp:TemplateField HeaderText="Chọn">
                <ItemTemplate>
                    <asp:CheckBox ID="cbChon" runat="server" />
                </ItemTemplate>
                <FooterTemplate>
                    <asp:Button ID="Button1" runat="server" Text="Trả hàng" />
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
</asp:Content>
