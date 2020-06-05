<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="BaiThucHanh2.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            height: 26px;
        }

        .auto-style3 {
            width: 10px;
        }

        .auto-style4 {
            height: 26px;
            width: 10px;
        }

        .auto-style5 {
            width: 20px;
        }

        .auto-style6 {
            width: 5px;
        }

        .auto-style7 {
            height: 26px;
            width: 5px;
        }
        .auto-style8 {
            width: 294px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style2"></td>
                    <td colspan="3" class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("TenHang") %>'></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td rowspan="4" class="auto-style3">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/images/" + Eval("Hinh")%>' Width="200px" />
                    </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label4" runat="server" Text='<%#Eval("MoTa")%>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2" colspan="3">
                        <asp:Label ID="Label5" runat="server" Text="Số lượng"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtSoLuong" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" Text="Mua hàng" OnClick="Button1_Click" CommandArgument='<%#Eval("MaHang") %>' />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2" colspan="3">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Giỏ hàng</asp:LinkButton>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style6"></td>
                    <td></td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <center>                        
                            <asp:Label ID="Label2" runat="server" Text='<%#Eval("DonGia") %>'></asp:Label>
                        </center>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
