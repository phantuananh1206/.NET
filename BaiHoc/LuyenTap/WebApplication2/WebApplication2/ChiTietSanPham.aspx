<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="WebApplication2.ChiTietSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("TenHang") %>'></asp:Label>
                        <br />
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/images/" + Eval("Hinh") %>'/>
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Button" CommandArgument='<%#Eval("MaHang") %>' OnClick="Button1_Click" />
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">LinkButton</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
