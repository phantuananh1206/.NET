<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="sanpham.aspx.cs" Inherits="TranNguyenHoaiThuong_23387.sanpham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #data{
           margin-left: 50px;
           text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
        <ItemTemplate>
            <div id="data">
                <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenSach") %>'></asp:Label>
                <br />
                <asp:ImageButton ID="ImageButton1" ImageUrl='<%#"~/Images/" + Eval("Hinh") %>' runat="server" CommandArgument='<%# Eval("MaSach") %>' Height="149px" Width="129px" OnClick="ImageButton1_Click" />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Giá: "></asp:Label>
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("DonGia") %>'></asp:Label>
                </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
