<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="chitietsanpham.aspx.cs" Inherits="TranNguyenHoaiThuong_23387.chitietsanpham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label9" runat="server"></asp:Label>
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <td>&nbsp;<asp:Image ID="Image2" ImageUrl='<%# "~/Images/"+Eval("Hinh") %>' runat="server" Height="187px" Width="142px" />
            </td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Tên sách: "></asp:Label>
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("TenSach") %>'></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="Nhà xuất bản: "></asp:Label>
                <asp:Label ID="Label4" runat="server" Text='<%# Eval("NhaXB") %>'></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text='<%# Eval("MoTa") %>'></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <b style="color: red">
                    <asp:Label ID="Label6" runat="server" Text="Giá: "></asp:Label>
                    <asp:Label ID="Label7" runat="server" Text='<%# Eval("DonGia") %>'></asp:Label>
                </b>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label8" runat="server" Text="Số lượng"></asp:Label>
                <asp:TextBox ID="txtsoluong" runat="server" Height="16px" Width="56px"></asp:TextBox>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Button ID="Button1" runat="server" Text="MUA" CommandArgument='<%# Eval("MaSach") %>' OnClick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="XEM GIỎ HÀNG" OnClick="Button2_Click" />
            </td>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
