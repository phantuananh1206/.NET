<%@ Page Title="" Language="C#" MasterPageFile="~/QuanLyBanSach.Master" AutoEventWireup="true" CodeBehind="ChiTiet.aspx.cs" Inherits="TryHard.ChiTiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("TenSach") %>'></asp:Label>
                        <br />
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("NhaXB") %>'></asp:Label>
                        <br />
                        <asp:Label ID="Label4" runat="server" Text='<%#Eval("MoTa") %>'></asp:Label>
                        <br />
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("DonGia") %>'></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnMua" runat="server" Text="Mua" CommandArgument='<%#Eval("MaSach") %>' OnClick="btnMua_Click" />
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="btnXemGioHang" runat="server" Text="Xem giỏ hàng" OnClick="btnXemGioHang_Click" />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
