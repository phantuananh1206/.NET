<%@ Page Title="" Language="C#" MasterPageFile="~/pageUser.Master" AutoEventWireup="true" CodeBehind="pageGioHang.aspx.cs" Inherits="WebQUANLYBANHANG4._0.pageGioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="219px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="669px" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" ShowFooter="True">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="IDMASP" HeaderText="Mã sản phẩm" />
            <asp:BoundField DataField="TENSP" HeaderText="Tên sản phẩm" />
            <asp:BoundField DataField="SOLUONG" HeaderText="Số lượng" />
            <asp:BoundField DataField="DONGIA" HeaderText="Đơn giá" />
            <asp:ImageField DataImageUrlField="HINHANH" HeaderText="Hình ảnh" ControlStyle-Height="125px" ControlStyle-Width="135px" >
<ControlStyle Height="125px" Width="135px"></ControlStyle>
            </asp:ImageField>
            <asp:BoundField HeaderText="Thành tiền" DataField="THANHTIEN" />
            <asp:TemplateField HeaderText="Xóa sản phẩm">
                <ItemTemplate>
                    <asp:CheckBox ID="ckblITEM" runat="server" />
                </ItemTemplate>
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
    <asp:Button ID="btnXOA" runat="server" Text="Xóa sản phẩm" OnClick="btnXOA_Click" />
    <asp:Button ID="btnTHANHTOAN" runat="server" Text="Thanh toán" OnClick="btnTHANHTOAN_Click" />
</asp:Content>
