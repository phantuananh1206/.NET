<%@ Page Title="" Language="C#" MasterPageFile="~/QuanLyBanHang.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="QuanLyBanHang.GioHang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="2.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label Style="color: red; font-weight: bold;" ID="Label1" runat="server"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowFooter="True" Width="613px" DataKeyNames="MaHang" OnRowDeleting="GridView1_RowDeleting" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:BoundField DataField="MaHang" HeaderText="Mã hàng" ReadOnly="True" />
            <asp:BoundField DataField="TenHang" ReadOnly="True" HeaderText="Tên hàng" />
            <asp:TemplateField HeaderText="Hình">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("Hinh") %>' Height="50px" Width="80px" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="DonGia" ReadOnly="True" HeaderText="Đơn giá" />
            <asp:BoundField DataField="SoLuong" HeaderText="Số lượng" />
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
