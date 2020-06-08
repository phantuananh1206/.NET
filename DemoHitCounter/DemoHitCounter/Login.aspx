<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DemoHitCounter.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 529px;
            width: 400px;
            margin-right: 414px;
        }
        .auto-style2 {
            width: 100%;
        }
        #btnDangNhap{
            float: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <table class="auto-style2">
                    <tr>
                        <td>Mã thành viên</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtMaTV" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Mật khẩu</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:CheckBox ID="chkGhiNho" runat="server" Text="Ghi nhớ tài khoản?" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnDangNhap" runat="server" Text="Đăng nhập" OnClick="btnDangNhap_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Thông báo lỗi"></asp:Label>
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <table class="auto-style2">
                    <tr>
                        <td colspan="3">
                            <center>
                                <asp:Image ID="Image1" runat="server" />
                            </center>                     
                        </td>
                    </tr>
                    <tr>
                        <td>Mã thành viên</td>
                        <td>:</td>
                        <td>
                            <asp:Label ID="lblMaTV" runat="server" Text="Mã tài khoản"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Thời điểm đăng nhập</td>
                        <td>:</td>
                        <td>
                            <asp:Label ID="lblThoiDiem" runat="server" Text="Thời gian đăng nhập"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:LinkButton ID="lnkDangXuat" runat="server" OnClick="lnkDangXuat_Click">Đăng xuất</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </asp:View>
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
