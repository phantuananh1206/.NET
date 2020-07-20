<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DanhSachSanPham.aspx.cs" Inherits="WebApplication1.DanhSachSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <asp:Label ID="Label1" runat="server" Text='<%#Eval("TenHang") %>'></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("MaHang") %>' OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
