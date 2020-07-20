<%@ Page Title="" Language="C#" MasterPageFile="~/pageUser.Master" AutoEventWireup="true" CodeBehind="pageCHITIETSANPHAM.aspx.cs" Inherits="WebQUANLYBANHANG4._0.pageCHITIETSANPHAM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_ItemCommand">
            <ItemTemplate>
            <table width="100%">
              <tr style="text-align: left; vertical-align: top">
                  <td width="50%">
                    <img  src="<%# Eval("HINHANH") %>" width="250px" height="400px"/>
                  </td>
                  <td width="50%" style="text-align: left; vertical-align: top">
                    <%# Eval("TENSP") %>
                  <hr/>
                  <br>
                    Giá: 
                    <%# Eval("DONGIA") %>
                  <hr />
                  <br >
                    Mô tả: 
                    <%# Eval("MOTA") %>
                 </td>
             </tr>
            </table>
        </ItemTemplate>
    </asp:Repeater>
    <asp:dropdownlist ID="drlSOLUONG" runat="server"></asp:dropdownlist>
    <asp:Button ID="btnGIOHANG" runat="server" OnClick="btnGIOHANG_Click" Text="Giỏ hàng" />
</asp:Content>
