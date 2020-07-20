using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication2
{
    public partial class DanhSachSanPham : System.Web.UI.Page
    {
        String connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        KetNoi ketNoi = new KetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            String SQL;
            if (Context.Items["ml"] == null)
            {
                SQL = "select * from MatHang";
            }
            else
            {
                String maLoai = Context.Items["ml"].ToString();
                SQL = "select * from MatHang where MaLoai ='" + maLoai + "'";
            }
            try
            {
                DataList2.DataSource = ketNoi.bangDuLieu(SQL);
                DataList2.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            String maHang = ((LinkButton)sender).CommandArgument;
            Context.Items["mh"] = maHang;
            Server.Transfer("ChiTietSanPham.aspx");
        }
    }
}