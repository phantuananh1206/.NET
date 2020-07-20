<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DanhSachThietBi.aspx.cs" Inherits="TryHard2.DanhSachThietBi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="dtlDanhSachThietBi" runat="server">
        <ItemTemplate>
            <asp:Label ID="Label1" runat="server" Text='<%#Eval("TenThietBi") %>'></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text='<%#Eval("DonGia") %>'></asp:Label>
            <br />
            <asp:LinkButton ID="lbtnChiTiet" runat="server" CommandArgument='<%#Eval("MaThietBi") %>' OnClick="lbtnChiTiet_Click">Chi tiết</asp:LinkButton>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
