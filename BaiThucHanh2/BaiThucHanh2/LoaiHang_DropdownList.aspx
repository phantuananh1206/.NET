<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoaiHang_DropdownList.aspx.cs" Inherits="BaiThucHanh2.LoaiHang_DropdownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 119px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Text="DANH SÁCH LOẠI HÀNG"></asp:Label><br/>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
