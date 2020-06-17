<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ChiTietSach.aspx.cs" Inherits="WebApplication1.ChiTietSach" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/CssChiTietSach.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal">
        <ItemTemplate>
            <div class="outer">
                <div class="left">
                    <asp:Image ID="Image1" ImageUrl='<%#"~/Image/"+Eval("hinh") %>' runat="server" />
                </div>
                <div class="right">
                    <div>
                        <h5>Tên: </h5>
                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("tensach") %>'></asp:Label>
                        
                    </div>
                    <div>
                        <h5><%#Eval("mota") %></h5>
                    </div>
                    <div>
                        <h5>Đơn giá: </h5>
                        <asp:Label ID="lblDonGia" runat="server" Text='<%#Eval("dongia") %>'></asp:Label>
                        
                    </div>
                    Số lượng: 
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="btnAddToCard" runat="server" CommandArgument='<%#Eval("masach") %>' Text="Thêm vào giỏ" OnClick="btnAddToCard_Click"/>
                    <asp:Button ID="btnCardView" runat="server" Text="Giỏ Hàng" OnClick="btnCardView_Click" />
                    
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
