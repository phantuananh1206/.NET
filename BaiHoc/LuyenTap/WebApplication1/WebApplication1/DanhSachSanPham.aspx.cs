using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace WebApplication1
{
    public partial class DanhSachSanPham : System.Web.UI.Page
    {
        XuLyDuLieu xuLyDuLieu = new XuLyDuLieu();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            String sql;
            if (Context.Items["ml"] == null)
                sql = "select * from MatHang";
            else
            {
                String maLoai = Context.Items["ml"].ToString();
                sql = "select * from MatHang where MaLoai ='" + maLoai + "'";
            }
            try
            {
                DataList2.DataSource = xuLyDuLieu.bangDuLieu(sql);
                DataList2.DataBind();
            }catch(SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            String maHang = ((LinkButton)sender).CommandArgument;
            Context.Items["mh"] = maHang;
            Server.Transfer("ChiTietSanPham.aspx");
        }
    }
}