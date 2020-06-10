<%@ Page Title="" Language="C#" MasterPageFile="~/pageUser.Master" AutoEventWireup="true" CodeBehind="pageDANHSACHSANPHAM.aspx.cs" Inherits="WebQUANLYBANHANG4._0.pageDANHSACHSANPHAM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="annotation.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
        <ItemTemplate>
            <a href="pageCHITIETSANPHAM.aspx?MaSanPham=<%# Eval("IDMASP") %>">
                <div class="abc">
                    
                     <img class="anh" src ="<%# Eval ("HINHANH") %>" width ="200", height="230"/>
                </a>
            <br />
            <br />
               <p class="chu">  <%# Eval ("TENSP") %> </p> 
           
                </div>
        </ItemTemplate>
    </asp:DataList>
   
</asp:Content>
