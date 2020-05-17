<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="DemoWebForm._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 124px">
        <div id="abc">
            Tên:
        <asp:TextBox ID="txt1" runat="server" Height="21px" Width="121px" style="margin-top: 25px"></asp:TextBox>
    
        <asp:Button ID="btnOK" runat="server" OnClick="Button1_Click" Text="OK" />
        <br />
        <asp:Label ID="lblHienThi" runat="server"></asp:Label>
        </div>
        
    
    </div>
    </form>
</body>
</html>
