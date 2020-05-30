<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="DemoDB._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="1.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <header>
                <h1>HEADER</h1>
            </header>
            <div id="main">
                <div id="menu">
                    <asp:HyperLink ID="HyperLink1" runat="server">TRANG CHỦ</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink2" runat="server">SẢN PHẨM</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink3" runat="server">KHUYẾN MÃI</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink4" runat="server">TIN TỨC</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink5" runat="server">LIÊN HỆ</asp:HyperLink>
                </div>
                <div id="left">
                    <div id="top">
                        Đăng nhập
                        <table class="auto-style1">
                            <tr>
                                <td>Tên đăng nhập</td>
                                <td>
                                    <asp:TextBox ID="txtTenDangNhap" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Mật khẩu</td>
                                <td>
                                    <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <center>
                                        <asp:Button ID="btnDangNhap" runat="server" Text="Đăng nhập" OnClick="btnDangNhap_Click" />
                                    </center>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Label ID="lblThongBao" runat="server" Text="Thông báo"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div id="bottom">
                        Danh mục loại sản phẩm
                    </div>
                </div>
                <div id="right">
                </div>
            </div>
            <footer>
                Copyright Phan Tuấn Anh
            </footer>
        </div>
    </form>
</body>
</html>
