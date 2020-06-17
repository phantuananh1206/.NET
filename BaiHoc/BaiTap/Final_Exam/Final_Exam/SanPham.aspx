<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="Final_Exam.SanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        img{
            width: 300px;
            height: 235px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>CÁC LOẠI SÁCH CỦA WEB</h2>
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
        <ItemTemplate>
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenSach") %>'></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/images/" + Eval("Hinh") %>'/>
            <br />
            <asp:Label ID="Label2" runat="server" Text='<%# Eval("DonGia", "{0:0,0}") %>'></asp:Label>
            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("MaSach") %>' OnClick="LinkButton1_Click">Chi tiết</asp:LinkButton>
        </ItemTemplate>

    </asp:DataList>
</asp:Content>
