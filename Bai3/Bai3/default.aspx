<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Bai3._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <asp:LinkButton ID="LinkButton1" runat="server"
                OnClick="LinkButton1_Click">Ao quan</asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server"
                OnClick="LinkButton2_Click">Giay dep</asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton3" runat="server"
                OnClick="LinkButton3_Click">Tui xach</asp:LinkButton>
        </div>
    </form>
</body>
</html>
