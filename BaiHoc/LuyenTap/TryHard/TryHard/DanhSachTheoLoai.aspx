<%@ Page Title="" Language="C#" MasterPageFile="~/QuanLyBanSach.Master" AutoEventWireup="true" CodeBehind="DanhSachTheoLoai.aspx.cs" Inherits="TryHard.DanhSachTheoLoai" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <asp:Label ID="Label2" runat="server" Text='<%#Eval("TenSach") %>'></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text='<%#Eval("DonGia") %>'></asp:Label>
            <br />
            <asp:LinkButton ID="lbtnChiTiet" runat="server" CommandArgument='<%#Eval("MaSach") %>' OnClick="lbtnChiTiet_Click">Chi Tiết</asp:LinkButton>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
