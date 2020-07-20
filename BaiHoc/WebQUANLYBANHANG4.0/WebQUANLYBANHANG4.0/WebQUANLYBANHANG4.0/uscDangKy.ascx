<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uscDangKy.ascx.cs" Inherits="WebQUANLYBANHANG4._0.uscDangKy" %>
<style type="text/css">
    .auto-style8 {
        height: 23px;
        text-align: center;
    }
    .auto-style9 {
        height: 23px;
        width: 619px;
    }
    .auto-style7 {
        width: 182px;
    }
    .auto-style10 {
        width: 182px;
        height: 26px;
    }
    .auto-style11 {
        height: 26px;
        width: 619px;
    }
    .auto-style12 {
        width: 619px;
        text-align: left;
    }
    .auto-style13 {
        height: 23px;
        text-align: left;
    }
    .auto-style14 {
        width: 182px;
        height: 31px;
    }
    .auto-style15 {
        width: 619px;
        height: 31px;
    }
    .auto-style16 {
        height: 25px;
        text-align: left;
    }
    .auto-style17 {
        height: 25px;
        width: 619px;
    }
    .auto-style18 {
        width: 619px;
        text-align: left;
        height: 26px;
    }
</style>
    <table style="width: 52%; height: 212px;">
    <tr>
        <td class="auto-style8" colspan="2">Đăng Ký Thành Viên&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">Họ Tên (*)&nbsp; :</td>
        <td class="auto-style12">
            <asp:TextBox ID="txtHOTENKH" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTENTAIKHOAN" ErrorMessage="Chưa nhập họ tên" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Tên Đăng Nhập (*) :</td>
        <td class="auto-style12">
            <asp:TextBox ID="txtTENTAIKHOAN" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Chưa nhập tên đăng nhập" ForeColor="Red" ControlToValidate="txtTENTAIKHOAN"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">Mật Khẩu (*)</td>
        <td class="auto-style11">
            <asp:TextBox ID="txtMATKHAU" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtMATKHAU_XACNHAN" ControlToValidate="txtMATKHAU" ErrorMessage="Xác nhận lại mật khẩu" ForeColor="Red"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">Xác Nhận Mật Khẩu (*) :</td>
        <td class="auto-style11">
            <asp:TextBox ID="txtMATKHAU_XACNHAN" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style14">Giới Tính :</td>
        <td class="auto-style15">
            <asp:RadioButtonList ID="rdlGIOITINH" runat="server" RepeatDirection="Horizontal" Width="128px">
                <asp:ListItem Selected="True">Nam</asp:ListItem>
                <asp:ListItem>Nữ</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td class="auto-style16">Ngày Sinh :</td>
        <td class="auto-style17">
            <asp:TextBox ID="txtNGAYSINH" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Sở Thích :</td>
        <td class="auto-style12">
            <asp:TextBox ID="txtSOTHICH" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">Nghề Nghiệp :</td>
        <td class="auto-style11">
            <asp:TextBox ID="txtNGHENGHIEP" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Trình Độ :</td>
        <td class="auto-style12">
            <asp:TextBox ID="txtTRINHDO" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">Địa Chỉ :</td>
        <td class="auto-style11">
            <asp:TextBox ID="txtDIACHI" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">Email: :</td>
        <td class="auto-style18">
            <asp:TextBox ID="txtEMAIL" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style13">Thông Tin Điều Khoản</td>
        <td class="auto-style9">
            <asp:CheckBox ID="CheckBox1" runat="server"  Text="Tôi chấp nhận điều khoản này" />
        </td>
    </tr>
    <tr>
        <td class="auto-style8"></td>
        <td class="auto-style9"></td>
    </tr>
    <tr>
        <td class="auto-style8" colspan="2">
            <asp:Button ID="btnDangKy" runat="server" Text="Đăng Ký" />
        </td>
    </tr>
</table>

