<%@ Page Title="" Language="C#" MasterPageFile="~/pageUser.Master" AutoEventWireup="true" CodeBehind="pageCHITIETSANPHAM.aspx.cs" Inherits="WebQUANLYBANHANG4._0.pageCHITIETSANPHAMaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="annotation.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater2" runat="server" >
        <ItemTemplate>
        <div class= "xyz" >
            <table>
                    <tr style="text-align: left; vertical-align: top">
                    <td>
                        <img src = "<%# Eval ("HINHANH") %>" width="200", height="230" />
                    </td>
                    <td>     
                        <br />
                           <b>Tên:  <%# Eval ("TENSP") %></b>  
                        <br />
                            Đơn giá: <%# Eval ("DONGIA") %>
                        <br />
                            Mô tả: <%# Eval ("MOTA") %>
                        <br />
                        <br />
                            <asp:DropDownList ID ="drlSoLuongSP" runat ="server"></asp:DropDownList>
                        <br />
                        
                            <asp:Button ID="btnGioHang" runat="server" Text="Thêm vào giỏ" />      
                    </td>
                    
                </tr> 
            </table>
        </div>
        </ItemTemplate>
    </asp:Repeater>
       <p class="button">
           <asp:DropDownList ID="drlSoLuong" runat="server"></asp:DropDownList>
            <asp:Button ID="btnGioHang" runat="server" Text="Thêm vào Giỏ" OnClick="btnGioHang_Click" />
        </p> 
</asp:Content>

