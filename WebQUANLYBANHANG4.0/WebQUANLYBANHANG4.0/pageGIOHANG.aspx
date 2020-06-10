<%@ Page Title="" Language="C#" MasterPageFile="~/pageUser.Master" AutoEventWireup="true" CodeBehind="pageGIOHANG.aspx.cs" Inherits="WebQUANLYBANHANG4._0.pageGIOHANG" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grvGioHang" runat="server" AutoGenerateColumns="False" Height="133px" Width="688px">
        <Columns>
            <asp:BoundField DataField="IDMASP" HeaderText="Mã sản phẩm" />
            <asp:BoundField DataField="TENSP" HeaderText="Tên sản phẩm" />
            <asp:BoundField DataField="SOLUONG" HeaderText="Số lượng" />
            <asp:BoundField DataField="DONGIA" HeaderText="Đơn giá" />
            <asp:ImageField DataImageUrlField="HINHANH" HeaderText="Hình ảnh">
            </asp:ImageField>
            <asp:BoundField DataField="THANHTIEN" HeaderText="Thành tiền" />
            <asp:TemplateField HeaderText="Xóa sản phẩm">
                <ItemTemplate>
                    <asp:CheckBox ID="ckbXoa" runat="server" Text="Chọn" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnXoaSanPham" runat="server" Height="36px" Text="Xóa sản phẩm" Width="91px" />
    <asp:Button ID="btnThanhToan" runat="server" Height="32px" Text="Thanh toán" Width="91px" />
</asp:Content>
