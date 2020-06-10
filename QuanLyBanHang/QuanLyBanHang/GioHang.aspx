<%@ Page Title="" Language="C#" MasterPageFile="~/QuanLyBanHang.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="QuanLyBanHang.GioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
