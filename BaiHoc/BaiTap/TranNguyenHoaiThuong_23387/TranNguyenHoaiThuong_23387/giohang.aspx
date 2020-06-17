<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="giohang.aspx.cs" Inherits="TranNguyenHoaiThuong_23387.giohang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #Label1{
            margin-left: 300px;
            font-size: 22px;
            font-weight: bold;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="GIỎ HÀNG SẢN PHẨM"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" ShowFooter="True" AutoGenerateColumns="False">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="MaSach" HeaderText="Mã Sách" ItemStyle-HorizontalAlign="Center"/>
            <asp:BoundField DataField="DonGia" HeaderText="Đơn giá" ItemStyle-HorizontalAlign="Center"/>
            <asp:TemplateField HeaderText="Hình">  
                <ItemTemplate>
                    <asp:Image ID="Image1" ImageUrl='<%# Eval("Hinh") %>' runat="server" Width="80px" Height="100px" ItemStyle-HorizontalAlign="Center"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="TenSach" HeaderText="Tên Sách" ItemStyle-HorizontalAlign="Center"/>
            <asp:BoundField DataField="SoLuong" HeaderText="Số lượng" ItemStyle-HorizontalAlign="Center"/>
            <asp:TemplateField HeaderText="Chọn">
                <FooterTemplate>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Trả hàng" />
                </FooterTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>
    </asp:Content>
