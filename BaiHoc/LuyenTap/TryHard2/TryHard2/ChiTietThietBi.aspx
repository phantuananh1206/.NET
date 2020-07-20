<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ChiTietThietBi.aspx.cs" Inherits="TryHard2.ChiTietThietBi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="dtlChiTietThietBi" runat="server">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblTenThietBi" runat="server" Text='<%#Eval("TenThietBi") %>'></asp:Label>
                        <br />
                        <asp:Label ID="lblMoTa" runat="server" Text='<%#Eval("MoTa") %>'></asp:Label>
                        <br />
                        <asp:Label ID="lblDonGia" runat="server" Text='<%#Eval("DonGia") %>'></asp:Label>
                        <br />
                    </td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblSoLuong" runat="server" Text="Số lượng"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlSoLuong" runat="server">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Button ID="btnGioHang" runat="server" Text="Giỏ hàng" CommandArgument='<%#Eval("MaThietBi") %>' OnClick="btnGioHang_Click"/>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
