<%@ Page Title="" Language="C#" MasterPageFile="~/pageUser.Master" AutoEventWireup="true" CodeBehind="pageDANHSACHSANPHAM.aspx.cs" Inherits="WebQUANLYBANHANG4._0.pageDANHSACHSANPHAM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" Height="118px" Width="309px" >
        <ItemTemplate>
            <a href="pageCHITIETSANPHAM.aspx?LINKIDMASP=<%# Eval("IDMASP")%>">
            <img src=" <%# Eval("HINHANH")%>" width="70px" height ="80px"/>
            </a>
        <br>
        Tên : <%# Eval("TENSP") %>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
