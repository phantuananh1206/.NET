<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uscDangNhap.ascx.cs" Inherits="WebQUANLYBANHANG4._0.uscDangNhap" %>
<style type="text/css">
    .auto-style1 {
        height: 23px;
        text-align: center;
    }
    .auto-style2 {
        text-align: center;
    }
    .auto-style3 {
        text-align: left;
    }
    .auto-style4 {
        text-align: left;
        height: 26px;
    }
    .auto-style5 {
        height: 26px;
    }
</style>

<table style="width: 21%;">
    <tr>
        <td class="auto-style1" colspan="2">Đăng Nhập</td>
    </tr>
    <tr>
        <td class="auto-style4">Tên Đăng Nhập</td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox1" runat="server" Width="145px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Mật Khẩu</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" Width="145px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2" colspan="2">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="text-align: center" Text="Đăng Nhập" />
        </td>
    </tr>
</table>
<p style="text-align: center">
    &nbsp;</p>

