<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="WebApplication1.GioHang1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/CssGioHang.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="top">
        Click vào từng mã sản phẩm để chọn lại số lượng muốn mua
    </div>
    <asp:GridView ID="GridView1" CssClass="gridview" GridLines="None" runat="server" AutoGenerateColumns="False" Width="822px">
        <Columns>
            <asp:TemplateField HeaderText="Mã Sách">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click" CommandArgument='<%#Eval("masach") %>' Text='<%# Bind("masach") %>' runat="server"></asp:LinkButton>
                   
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Đơn giá" DataField="dongia" />
            <asp:TemplateField HeaderText="Ảnh">
                <ItemTemplate>
                    <asp:Image CssClass="image" ID="Image1" ImageUrl='<%#"~/Image/"+Eval("hinh") %>' runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Tên Sách" DataField="tensach" />
            <asp:BoundField HeaderText="Số lượng" DataField="soluong" />
            <asp:TemplateField HeaderText="Chọn">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div class="bottom">
    <asp:Label CssClass="one" ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:Button CssClass="one" ID="btnThanhToan" runat="server" Text="Thanh Toán" OnClick="btnThanhToan_Click" />
    <asp:Button CssClass="one" ID="btnReturn" runat="server" Text="Trả hàng" OnClick="btnReturn_Click"  />
    </div>
</asp:Content>
