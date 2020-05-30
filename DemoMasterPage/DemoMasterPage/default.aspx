<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="DemoMasterPage._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="outer">
            <div id="header">
                <div id="menu">
                    <div style="float: left">
                        <asp:HyperLink ID="Link1" Text="Home" runat="server" NavigateUrl="~/a1.aspx" />
                        <asp:HyperLink ID="Link2" Text="About Us" runat="server" />
                        <asp:HyperLink ID="HyperLink3" Text="Contact Us" runat="server" />
                        <asp:HyperLink ID="HyperLink4" Text="Feedback" runat="server" />
                        <asp:HyperLink ID="HyperLink5" Text="FAQs" runat="server" />
                        <asp:HyperLink ID="HyperLink6" Text="My Account" runat="server" />
                    </div>
                    <div style="float: right">
                        <asp:LinkButton ID="btnEN" runat="server">English</asp:LinkButton>
                        <asp:LinkButton ID="btnVN" runat="server">Tiếng Việt</asp:LinkButton>                     
                    </div>
                </div>
            </div>
            <div id="content">
                Nội dung
            </div>
            <div id="right">
                <div class="box right-top">
                    RIGHT-TOP
                </div>
                <div class="box right-left">
                    RIGHT-LEFT
                </div>
                <div class="box right-right">
                    RIGHT-RIGHT
                </div>
            </div>
            <div id="footer">
                <strong>Copyright Phan Tuấn Anh</strong>
            </div>
        </div>
    </form>
</body>
</html>
