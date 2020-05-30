<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoaiHang_RadioButtonList.aspx.cs" Inherits="BaiThucHanh2.LoaiHang_RadioButtonList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 101px">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Text="DANH SÁCH LOẠI HÀNG"></asp:Label>
    
    </div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
        </asp:RadioButtonList>
    </form>
</body>
</html>
