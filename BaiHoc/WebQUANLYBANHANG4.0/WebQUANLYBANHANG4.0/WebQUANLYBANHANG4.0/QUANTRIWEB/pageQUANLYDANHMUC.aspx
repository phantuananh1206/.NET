<%@ Page Title="" Language="C#" MasterPageFile="~/QUANTRIWEB/QUANTRI.Master" AutoEventWireup="true" CodeBehind="pageQUANLYDANHMUC.aspx.cs" Inherits="WebQUANLYBANHANG4._0.QUANTRIWEB.pageQUANLYDANHMUC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            height: 41px;
        text-align: left;
    }
        .auto-style14 {
        height: 69px;
        text-align: center;
    }
        .auto-style15 {
            height: 33px;
            text-align: left;
        }
        .auto-style16 {
            height: 26px;
            text-align: left;
        }
        .auto-style17 {}
        .auto-style18 {}
    </style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 80%; height: 454px;">
        <tr>
            <td class="auto-style14" colspan="2" aria-orientation="horizontal">Quản Lý Danh Mục</td>
        </tr>
        <tr>
            <td class="auto-style16">Mã danh mục cha</td>
            <td class="auto-style16">
                <asp:DropDownList ID="drlDANHMUCCHA" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">Tên danh mục</td>
            <td style="text-align: left" class="auto-style17">
                <asp:TextBox ID="txtTENDM" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style15" colspan="2">
                <asp:Button ID="btnThemMoi" runat="server" Text="Thêm mới" />
                <asp:Button ID="btnSua" runat="server" Text="Sửa" />
                <asp:Button ID="btnXoa" runat="server" Text="Xóa" />
            </td>
        </tr>
        <tr>
            <td class="auto-style18" colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="214px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="804px" style="margin-top: 0px" AllowPaging="True" PageSize="5" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                    <Columns>
                        
                       
hhhh
                         <asp:TemplateField HeaderText="Mã danh mục">
                             <ItemTemplate>
                                   <asp:Label ID="lbelIDMADM" runat="server" Text='<%# Eval("IDMADM") %>'>
                                </asp:Label>
                             </ItemTemplate>
                         </asp:TemplateField>
                        
                       
                         <asp:TemplateField HeaderText="Tên danh mục">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("TENDM") %>'>
                                </asp:Label>
                             </ItemTemplate>
                             <EditItemTemplate>
                                 <asp:TextBox ID="txtTENDM"  runat="server" Text='<%# Eval("TENDM") %>' >
                                 </asp:TextBox>
                             </EditItemTemplate>
                        </asp:TemplateField>


                         <asp:TemplateField HeaderText="Danh mục cha">
                             <ItemTemplate>
                                 <asp:Label ID="Label2" runat="server" Text='<%# Eval("IDPARENT") %>'></asp:Label>
                             </ItemTemplate>
                             <EditItemTemplate>
                                 <asp:DropDownList ID="drlDANHMUCCHA" runat="server"></asp:DropDownList>
                             </EditItemTemplate>
                         </asp:TemplateField>
                            


                        <asp:CommandField ButtonType="Button" HeaderText="Sửa" ShowEditButton="True" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
            </td>
        </tr>
        </table>
</asp:Content>
