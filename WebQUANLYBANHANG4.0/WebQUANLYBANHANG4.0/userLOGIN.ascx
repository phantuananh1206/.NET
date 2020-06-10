<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="userLOGIN.ascx.cs" Inherits="WebQUANLYBANHANG4._0.userLOGIN" %>
<style type="text/css">
    .auto-style1 {
        text-align: center;
        height: 27px;
    }
    .auto-style2 {
        width: 110px;
    }
    .auto-style3 {
        width: 38%;
        height: 90px;
    }
    .auto-style4 {
        text-align: center;
    }
</style>

<table class="auto-style3" border ="1">
    <tr>
        <td class="auto-style1" colspan="2"><strong>ĐĂNG NHẬP</strong></td>
    </tr>
    <tr>
        <td class="auto-style2">Tên đăng nhập</td>
        <td>
            <asp:TextBox ID="txTenDangNhap" runat="server" Width="160px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Mật khẩu</td>
        <td>
            <asp:TextBox ID="txMatKhau" runat="server" Width="160px"></asp:TextBox>
        </td>
    </tr>
    <tr> 
        <td class="auto-style4" colspan="2">
            
            <asp:Button ID="btnDangNhap" runat="server" Text="Đăng nhập" Width="83px" />
            
        </td>
    </tr>
</table>

