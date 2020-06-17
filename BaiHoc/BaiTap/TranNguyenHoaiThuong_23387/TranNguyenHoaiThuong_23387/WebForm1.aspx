<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TranNguyenHoaiThuong_23387.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <div id="banner">
            <asp:Image ImageUrl="images/banner.jpg" ID="Image1" runat="server" Width="960px" Height=" 200px" />
        </div>
        <div id="content">
            <div id="left">
                Danh mục sách
                <asp:DataList ID="DataList1" runat="server">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("TenLoai") %>' CommandArgument='<%# Eval("MaLoai") %>'>LinkButton</asp:LinkButton>
                    </ItemTemplate>
                </asp:DataList>
            </div>
            <div id="right">
                <asp:Login ID="Login1" runat="server" Height="193px" Width="236px">
                </asp:Login>
            </div>
            <div id="bettween">

            </div>
        </div> <!--content-->
        <div id="footer" style="background-color:#ffd800; width:960px; height: 70px; text-align: center">
            FINAL EXAM IS384J 2020S HOME <br />
            TRẦN NGUYỄN HOÀI THƯƠNG <br />
            MSSV: 2320123387
        </div> <!--footer-->
    </div> <!--main-->
    </form>
</body>
</html>
