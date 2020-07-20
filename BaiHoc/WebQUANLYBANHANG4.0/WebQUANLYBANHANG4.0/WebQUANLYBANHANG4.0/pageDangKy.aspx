<%@ Page Title="" Language="C#" MasterPageFile="~/pageUser.Master" AutoEventWireup="true" CodeBehind="pageDangKy.aspx.cs" Inherits="WebQUANLYBANHANG4._0.pageDangKy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style7 {
        width: 182px;
    }
    .auto-style8 {
        width: 182px;
        height: 23px;
    }
    .auto-style9 {
        height: 23px;
    }
    .auto-style10 {
        width: 182px;
        height: 26px;
    }
    .auto-style11 {
        height: 26px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%; height: 212px;">
    <tr>
        <td class="auto-style8"></td>
        <td class="auto-style9"></td>
    </tr>
    <tr>
        <td class="auto-style7">Họ Tên (*)&nbsp; :</td>
        <td>
            <asp:TextBox ID="txtHOTENKH" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTENTAIKHOAN" ErrorMessage="Chưa nhập thông tin" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Tên Đăng Nhập (*) :</td>
        <td>
            <asp:TextBox ID="txtTENTAIKHOAN" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">Mật Khẩu (*)</td>
        <td class="auto-style11">
            <asp:TextBox ID="txtMATKHAU" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtMATKHAU_XACNHAN" ControlToValidate="txtMATKHAU" ErrorMessage="Xác nhận lại mật khẩu"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">Xác Nhận Mật Khẩu (*) :</td>
        <td class="auto-style11">
            <asp:TextBox ID="txtMATKHAU_XACNHAN" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Giới Tính :</td>
        <td>
            <asp:RadioButtonList ID="rdlGIOITINH" runat="server" RepeatDirection="Horizontal" Width="128px">
                <asp:ListItem Selected="True">Nam</asp:ListItem>
                <asp:ListItem>Nữ</asp:ListItem>
            </asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">Ngày Sinh :</td>
        <td class="auto-style9">
            <asp:TextBox ID="txtNGAYSINH" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Sở Thích :</td>
        <td>
            <asp:TextBox ID="txtSOTHICH" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Nghề Nghiệp :</td>
        <td>
            <asp:TextBox ID="txtNGHENGHIEP" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Trình Độ :</td>
        <td>
            <asp:TextBox ID="txtTRINHDO" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Địa Chỉ :</td>
        <td>
            <asp:TextBox ID="txtDIACHI" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Email: :</td>
        <td>
            <asp:TextBox ID="txtEMAIL" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">Thông Tin Điều Khoản</td>
        <td class="auto-style9">
            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Tôi chấp nhận điều khoản này" />
        </td>
    </tr>
    <tr>
        <td class="auto-style8"></td>
        <td class="auto-style9"></td>
    </tr>
    <tr>
        <td class="auto-style8"></td>
        <td class="auto-style9">
            <asp:Button ID="btnDangKy" runat="server" Text="Đăng Ký" />
        </td>
    </tr>
</table>
</asp:Content>
