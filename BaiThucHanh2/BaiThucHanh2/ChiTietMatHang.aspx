<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChiTietMatHang.aspx.cs" Inherits="BaiThucHanh2.ChiTietMatHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>   
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="Hình Ảnh">
                    <ItemTemplate>
                        <asp:Image ID="Image1" ImageUrl='<%#"~/images/" + Eval("Hinh")%>' runat="server" Width="200px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="MaHang" HeaderText="Mã Hàng" />
                <asp:BoundField DataField="TenHang" HeaderText="Tên Hàng" />
                <asp:BoundField DataField="MoTa" HeaderText="Mô Tả" />
                <asp:BoundField DataField="DonGia" HeaderText="Đơn Giá" />
                <asp:BoundField DataField="MaLoai" HeaderText="Mã Loại" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
