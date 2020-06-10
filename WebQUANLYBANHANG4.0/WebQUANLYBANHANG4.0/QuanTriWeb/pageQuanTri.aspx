<%@ Page Title="" Language="C#" MasterPageFile="~/QuanTriWeb/pageQuanTri.Master" AutoEventWireup="true" CodeBehind="pageQuanTri.aspx.cs" Inherits="WebQUANLYBANHANG4._0.QuanTriWeb.pageQuanTri1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style11 {
        width: 100%;
        height: 96px;
    }
    .auto-style12 {
        text-align: center;
    }
    .auto-style14 {
        text-align: center;
        height: 35px;
        width: 672px;
            font-size: x-large;
        }
    .auto-style15 {
        height: 42px;
    }
    .auto-style17 {
        width: 56%;
        height: 96px;
        margin-left: 2px;
    }
    .auto-style18 {
        width: 66px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style17">
    <tr>
        <td class="auto-style14" colspan="2"><strong>QUẢN LÝ DANH MỤC</strong></td>
    </tr>
    <tr>
        <td>Mã Danh Mục</td>
        <td class="auto-style18">
            <asp:DropDownList ID="drlMaDanhMuc" runat="server" Height="19px" Width="130px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>Tên Danh Mục</td>
        <td class="auto-style18">
            <asp:TextBox ID="txtTenDanhMuc" runat="server" Height="23px" Width="120px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2" class="auto-style15">
            <asp:Button ID="btnThem" runat="server" Text="Thêm" Width="100px" Height="32px" />
            <asp:Button ID="btnSua" runat="server" Text="Sửa" Width="100px" Height="32px" />
            <asp:Button ID="bntXoa" runat="server" Text="Xóa" Height="32px" Width="100px" />
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:GridView ID="grvDanhMuc" runat="server" Width="364px" AutoGenerateColumns="False">
                <Columns>
                    <asp:DynamicField HeaderText="Mã Danh Mục" />
                    <asp:DynamicField HeaderText="Tên Danh Mục" />
                    <asp:DynamicField HeaderText="Danh Muc Cha" />
                </Columns>
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style18">&nbsp;</td>
    </tr>
</table>
</asp:Content>
