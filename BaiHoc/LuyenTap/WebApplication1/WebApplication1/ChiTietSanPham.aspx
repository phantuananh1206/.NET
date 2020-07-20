<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="WebApplication1.ChiTietSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("MaHang") %>' OnClick="LinkButton1_Click">Mua</asp:LinkButton>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("TenHang") %>'></asp:Label>
                        <br />
                        <asp:DropDownList ID="ddlSoLuong" runat="server">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">LinkButton</asp:LinkButton>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
