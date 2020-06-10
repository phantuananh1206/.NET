<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pageDANGNHAP_DANGKI.aspx.cs" Inherits="WebQUANLYBANHANG4._0.pageDANGNHAP_DANGKI" %>

<%@ Register src="userLOGIN.ascx" tagname="userLOGIN" tagprefix="uc1" %>
<%@ Register src="userDANGKI.ascx" tagname="userDANGKI" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal" Width="209px">
                <asp:ListItem Value="1">Đăng Nhập</asp:ListItem>
                <asp:ListItem Value="2">Đăng Kí</asp:ListItem>
            </asp:RadioButtonList>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
