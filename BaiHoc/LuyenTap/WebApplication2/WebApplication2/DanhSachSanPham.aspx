<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DanhSachSanPham.aspx.cs" Inherits="WebApplication2.DanhSachSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <asp:Label ID="Label1" runat="server" Text='<%#Eval("TenHang") %>'></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/images/" + Eval("Hinh") %>' />
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%#Eval("MaHang") %>' OnClick="LinkButton2_Click">LinkButton</asp:LinkButton>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
