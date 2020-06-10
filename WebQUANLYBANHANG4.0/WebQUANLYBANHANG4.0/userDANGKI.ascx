<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="userDANGKI.ascx.cs" Inherits="WebQUANLYBANHANG4._0.userDANGKI" %>
<style type="text/css">

    .auto-style8 {
        width: 169px;
        height: 23px;
    }
    .auto-style9 {
        height: 23px;
    }
    .auto-style7 {
        width: 169px;
    }
    .auto-style10 {
        width: 169px;
        height: 26px;
    }
    .auto-style11 {
        height: 26px;
    }
    .auto-style12 {
        height: 23px;
        text-align: center;
    }
    .auto-style13 {
        width: 71%;
        height: 212px;
    }
</style>
    <table class="auto-style13">
    <tr>
        <td class="auto-style12" colspan="2"><strong>ĐĂNG KÍ THÀNH VIÊN&nbsp;</strong></td>
    </tr>
    <tr>
        <td class="auto-style7">Họ Tên (*)&nbsp; :</td>
        <td>
            <asp:TextBox ID="txtHOTENKH" runat="server" Width="228px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTENTAIKHOAN" ErrorMessage="Bạn chưa nhập họ tên" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Tên Đăng Nhập (*) :</td>
        <td>
            <asp:TextBox ID="txtTENTAIKHOAN" runat="server" Width="228px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Bạn chưa nhập tên" ForeColor="Red" ControlToValidate="txtTENTAIKHOAN"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">Mật Khẩu (*)</td>
        <td class="auto-style11">
            <asp:TextBox ID="txtMATKHAU" runat="server" Width="228px" ></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtMATKHAU_XACNHAN" ControlToValidate="txtMATKHAU" ErrorMessage=" Mật khẩu không khớp" ForeColor="Red"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">Xác Nhận Mật Khẩu (*) :</td>
        <td class="auto-style11">
            <asp:TextBox ID="txtMATKHAU_XACNHAN" runat="server" Width="228px"></asp:TextBox>
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
            <asp:TextBox ID="txtNGAYSINH" runat="server" Width="228px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Sở Thích :</td>
        <td>
            <asp:TextBox ID="txtSOTHICH" runat="server" Width="228px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Nghề Nghiệp :</td>
        <td>
            <asp:TextBox ID="txtNGHENGHIEP" runat="server" Width="228px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Trình Độ :</td>
        <td>
            <asp:TextBox ID="txtTRINHDO" runat="server" Width="228px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Địa Chỉ :</td>
        <td>
            <asp:TextBox ID="txtDIACHI" runat="server" Width="228px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">Email: :</td>
        <td>
            <asp:TextBox ID="txtEMAIL" runat="server" Width="228px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">Thông Tin Điều Khoản</td>
        <td class="auto-style9">
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Tôi chấp nhận điều khoản này" />
        </td>
    </tr>
    <tr>
        <td class="auto-style8"></td>
        <td class="auto-style9"></td>
    </tr>
    <tr>
        <td class="auto-style8"></td>
        <td class="auto-style9">
            <strong>
            <asp:Button ID="btnDangKy" runat="server" Text="Đăng Ký" ForeColor="Black" />
            </strong>
        </td>
    </tr>
</table>

