<%@ Page Title="" Language="C#" MasterPageFile="~/QuanLyBanHang.Master" AutoEventWireup="true" CodeBehind="DanhSachSanPham.aspx.cs" Inherits="QuanLyBanHang.DanhSachSanPham" %>
<%@ Register Assembly="CollectionPager" Namespace="SiteUtils" Tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="2.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList2" runat="server" Width="594px" RepeatColumns="3">
        <ItemTemplate>
            <div class="CanGiua">
                <asp:Label Class="ChuDo" runat="server" Text='<%#Eval("TenHang") %>'></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/images/" + Eval("Hinh")%>' Width="200px" Height="250px"/>
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("MaHang") %>' OnClick="LinkButton2_Click">Chi Tiết</asp:LinkButton>
            </div>
        </ItemTemplate>
    </asp:DataList>
    <cc1:CollectionPager ID="clPager" runat="server" ResultsLocation="Bottom"></cc1:CollectionPager>
</asp:Content>
