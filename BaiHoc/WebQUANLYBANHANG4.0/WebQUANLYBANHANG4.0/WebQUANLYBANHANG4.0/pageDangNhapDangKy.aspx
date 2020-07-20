<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pageDangNhapDangKy.aspx.cs" Inherits="WebQUANLYBANHANG4._0.pageDangNhapDangKy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" Height="62px">
            <asp:RadioButtonList ID="rbtDangNhapDangKy" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal">
                <asp:ListItem Value="1">Đăng Nhập</asp:ListItem>
                <asp:ListItem Value="2">Đăng Ký</asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
