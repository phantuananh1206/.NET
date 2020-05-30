<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MatHang.aspx.cs" Inherits="BaiThucHanh2.MatHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="Hình Ảnh">
                    <ItemTemplate>
                        <asp:Image ID="Image1" ImageUrl='<%#"~/images/" + Eval("Hinh")%>' runat="server" width="200px"/>                 
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:HyperLinkField DataTextField="TenHang" HeaderText="Tên Hàng" />
                <asp:BoundField DataField="MoTa" HeaderText="Mô tả" />
                <asp:BoundField HeaderText="Đơn Giá" DataField="DonGia" />
                
            </Columns>
        </asp:GridView>
    <div>
    
    </div>
    </form>
</body>
</html>
