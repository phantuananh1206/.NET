<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MatHangTheoLoai.aspx.cs" Inherits="BaiThucHanh2.MatHangTheoLoai" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("TenHang") %>' CommandArgument ='<%# Eval("MaHang") %>' OnClick="LinkButton1_Click"></asp:LinkButton>
            </ItemTemplate>

        </asp:DataList>
    
    </div>
    </form>
</body>
</html>
