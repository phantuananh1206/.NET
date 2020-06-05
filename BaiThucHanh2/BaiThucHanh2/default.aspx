<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="BaiThucHanh2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="1.css" rel="stylesheet" />
    </head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <header>
                Header
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
                    <asp:Label ID="Label1" runat="server" Text="Danh sách loại hàng" ForeColor="Red"></asp:Label>
                    <%--<asp:RadioButtonList ID="rdlLoaiHang" runat="server" AutoPostBack="True" NavigateUrl="~/Webform1.aspx" OnSelectedIndexChanged="rdlLoaiHang_SelectedIndexChanged"></asp:RadioButtonList>--%>
                </div>
                <div id="right">
                    <asp:Login ID="Login1" runat="server">
                    </asp:Login>
                </div>
                <div id="mid">
                </div>
            </div>
            <footer>
                Copyright Phan Tuấn Anh
            </footer>
        </div>
    </form>
</body>
</html>
