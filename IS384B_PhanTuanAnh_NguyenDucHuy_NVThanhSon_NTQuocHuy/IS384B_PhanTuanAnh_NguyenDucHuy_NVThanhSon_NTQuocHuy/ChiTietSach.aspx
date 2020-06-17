<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ChiTietSach.aspx.cs" Inherits="IS384B_PhanTuanAnh_NguyenDucHuy_NVThanhSon_NTQuocHuy.ChiTietSach" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            height: 26px;
        }

        .auto-style6 {
            height: 26px;
            width: 73px;
        }
    </style>
    <link href="2.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <table class="auto-style3 CanGiua">
                <tr>
                    <td class="auto-style6">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/images/" + Eval("Hinh")%>' Width="200px" />
                        <br />
                        <asp:Label Class="ChuDo" runat="server" Text='<%#Eval("DonGia") %>'></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("TenSach") %>'></asp:Label>
                        <br />
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("MoTa")%>'></asp:Label>
                        <br />
                        <asp:Label ID="Label4" runat="server" Text="Số lượng"></asp:Label>
                        <asp:TextBox ID="txtSoLuong" runat="server"></asp:TextBox>
                        <asp:Button ID="btnMuaSach" runat="server" Text="Mua sách" CommandArgument='<%#Eval("MaSach") %>' OnClick="btnMuaSach_Click" />
                        <br />
                        <asp:LinkButton ID="lbtnGioHang" runat="server" OnClick="lbtnGioHang_Click">Giỏ hàng</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>

</asp:Content>
