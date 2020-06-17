<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SachTheoLoai.aspx.cs" Inherits="WebApplication1.SachTheoLoai" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal" RepeatColumns="3">
        <ItemTemplate>
            <div class="oneproduct">
                <div>
                    <asp:LinkButton ID="LinkButton1" CommandArgument='<%#Eval("masach") %>' OnClick="LinkButton1_Click" runat="server"><%#Eval("tensach") %></asp:LinkButton>
                </div>
                <div>
                    <asp:ImageButton ID="Image" CommandArgument='<%#Eval("masach") %>' OnClick="Image_Click" ImageUrl='<%#"~/Image/"+Eval("hinh") %>' runat="server" />
                </div>
                <div>
                    <asp:LinkButton ID="LinkButton2" CommandArgument='<%#Eval("masach") %>' OnClick="LinkButton2_Click" runat="server"><%#Eval("dongia") %></asp:LinkButton>
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
