<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ChiTietSP.aspx.cs" Inherits="Final_Exam.ChiTietSP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        img{
            width: 300px;
            height: 235px;
        }
        #ContentPlaceHolder1_DataList1_tensach_0{
            font-weight: bold;
            font-size: 25px;
            color: violet;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <asp:Label ID="tensach" runat="server" Text='<%# Eval("TenSach")%>'></asp:Label> <br />
            <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/images/" + Eval("Hinh") %>'/> <br />
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("NhaXB")%>'></asp:Label><br />             
            <asp:Label ID="Label3" runat="server" Text='<%# Eval("MoTa")%>'></asp:Label><br />
             Giá: <asp:Label ID="Label2" runat="server" Text='<%# Eval("DonGia", "{0:0,0}") + " đồng" %>'></asp:Label><br />            
            <asp:Button ID="Button1" runat="server" Text="Mua hàng" CommandArgument='<%# Eval("MaSach") %>' OnClick="Button1_Click" />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" >Xem Giỏ hàng</asp:LinkButton>
        </ItemTemplate>
        
    </asp:DataList>
</asp:Content>
