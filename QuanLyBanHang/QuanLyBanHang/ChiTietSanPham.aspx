<%@ Page Title="" Language="C#" MasterPageFile="~/QuanLyBanHang.Master" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="QuanLyBanHang.ChiTietSanPham" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <div>
                <table class="auto-style1 CanGiua">
                    <tr>
                        <td>
                            <asp:Image ID="Image2" runat="server" ImageUrl='<%#"~/images/" + Eval("Hinh")%>' Width="200px" />
                            <br />
                            <asp:Label Class="ChuDo" runat="server" Text='<%#Eval("DonGia") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label Class="abc" runat="server" Text='<%#Eval("TenHang") %>'></asp:Label>
                            <br />
                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("MoTa")%>'></asp:Label>
                            <br />
                            <asp:Label ID="Label3" runat="server" Text="Số lượng"></asp:Label>
                            <asp:TextBox ID="txtSoLuong" runat="server" Width="121px"></asp:TextBox>
                            <asp:Button ID="Button1" runat="server" Text="Mua hàng" CommandArgument='<%#Eval("MaHang") %>' OnClick="Button1_Click" />
                            <br />
                            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Giỏ hàng</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </div>

        </ItemTemplate>
    </asp:DataList>
</asp:Content>
