<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThongKe.aspx.cs" Inherits="DemoHitCounter.ThongKe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 24%;
        }
        .auto-style2 {
            width: 120px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <center>
                        <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="THỐNG KÊ"></asp:Label>
                    </center>
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Lượt truy cập"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblSoLuotTC" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Online"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblOnline" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
