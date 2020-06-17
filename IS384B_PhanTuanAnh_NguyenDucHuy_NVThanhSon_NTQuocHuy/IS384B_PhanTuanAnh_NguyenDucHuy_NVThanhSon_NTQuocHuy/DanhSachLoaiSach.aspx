<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DanhSachLoaiSach.aspx.cs" Inherits="IS384B_PhanTuanAnh_NguyenDucHuy_NVThanhSon_NTQuocHuy.DanhSachLoaiSach" %>
<%@ Register Assembly="CollectionPager" Namespace="SiteUtils" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="2.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="dtlDanhSachSach" runat="server" RepeatColumns="3">
        <ItemTemplate>
            <div class="CanGiua">
                <asp:Label Class="ChuDo" runat="server" Text='<%#Eval("TenSach") %>'></asp:Label>
                <br />
                <asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/images/" + Eval("Hinh")%>' Width="200px"/>
                <br />
                <asp:LinkButton ID="lbtnChiTiet" runat="server" CommandArgument='<%# Eval("MaSach") %>' OnClick="lbtnChiTiet_Click">Chi Tiết</asp:LinkButton>
            </div>
        </ItemTemplate>
    </asp:DataList>
    <cc1:CollectionPager ID="clPager" runat="server" ResultsLocation="Bottom"></cc1:CollectionPager>
</asp:Content>
