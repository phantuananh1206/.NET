<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="KiemLoiTuyBien._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }

        .auto-style3 {
            height: 26px;
        }
    </style>
    <script>
        function fnKiemTraSoChan(source, args) {
            args.IsValid = (args.Value % 2 == 0);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style2">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Số chẵn"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSoChan" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Vui lòng nhập số chẵn" ClientValidationFunction="fnKiemTraSoChan" ControlToValidate="txtSoChan" Display="Dynamic" ValidateEmptyText="True"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Mã bảo mật"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMaBM" runat="server"></asp:TextBox>
                    <asp:Label ID="lblMaBM" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="Nhập không đúng mã bảo mật!" ControlToValidate="txtMaBM" Display="Dynamic" OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" Text="Kiểm tra" />
                </td>
                <td class="auto-style3"></td>
            </tr>
        </table>
    </form>
</body>
</html>
