<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="HomeWork2._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            text-align: right;
            width: 19%;
        }
        .auto-style8 {
            width: 19%;
        }
        .auto-style9 {
            width: 168px;
        }
        .auto-style10 {
            text-align: left;
            width: 64%;
        }
        .auto-style11 {
            width: 64%;
            height: 33px;
        }
        .auto-style12 {
            text-align: right;
            width: 19%;
            height: 29px;
        }
        .auto-style13 {
            width: 168px;
            height: 29px;
        }
        .auto-style14 {
            width: 64%;
            height: 29px;
        }
        .auto-style15 {
            width: 19%;
            height: 33px;
        }
        .auto-style16 {
            width: 168px;
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">Email</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Không để trống" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email không đúng định dạng" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Xác nhận email</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtConfirmEmail" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtEmail" ControlToValidate="txtConfirmEmail" Display="Dynamic" ErrorMessage="Xác nhận không giống email" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Điểm</td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtDiem" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtDiem" Display="Dynamic" ErrorMessage="Điểm phải từ 0 đến 10" ForeColor="Red" ValidationExpression="[0-9\.\-]"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">Ngày sinh</td>
                <td class="auto-style13">
                    <asp:TextBox ID="txtNgaySinh" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style14">
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtNgaySinh" Display="Dynamic" ErrorMessage="Ngày sinh phải trên 16 tuổi" ForeColor="Red" Type="Date" OnPreRender="RangeValidator1_PreRender"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style15"></td>
                <td class="auto-style16">
                    <asp:Button ID="btnKiemLoi" runat="server" Text="Kiểm lỗi" />
                </td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td colspan="2" rowspan="3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
    <p>
        x</p>
</body>
</html>
