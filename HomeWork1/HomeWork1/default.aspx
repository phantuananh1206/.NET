<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="HomeWork1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Tinh {
            height: 36px;
            margin-bottom: 28px;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 95px;
        }
        .auto-style3 {
            width: 61px;
        }
        .auto-style5 {
            width: 141px;
        }
        .auto-style6 {
            width: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 478px">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Toán hạng a</td>
                <td class="auto-style3">Toán tử</td>
                <td class="auto-style5">Toán hạng b</td>
                <td class="auto-style6">&nbsp;</td>
                <td>Kết quả</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="txtA" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlToanTu" runat="server">
                        <asp:ListItem Value="+">Cộng</asp:ListItem>
                        <asp:ListItem Value="-">Trừ</asp:ListItem>
                        <asp:ListItem Value="*">Nhân</asp:ListItem>
                        <asp:ListItem Value="/">Chia</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtB" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:Button ID="btnTinh" runat="server" OnClick="btnTinh_Click1" Text="=" />
                </td>
                <td>
                    <asp:TextBox ID="txtKetQua" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtA" Display="Dynamic" ErrorMessage="Vui lòng nhập toán hạng a!" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtA" Display="Dynamic" ErrorMessage="Vui lòng nhập toán hạng hợp lệ!" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtB" Display="Dynamic" ErrorMessage="Vui lòng nhập toán hạng b!" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtB" Display="Dynamic" ErrorMessage="Vui lòng nhập toán hạng hợp lệ!" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
                    <asp:Label ID="lblHienThi" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
    
    </form>
</body>
</html>
