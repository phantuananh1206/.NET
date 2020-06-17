using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyBanHang
{
    public partial class QuanLyBanHang : System.Web.UI.MasterPage
    {
        String connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            try
            {
                String SQL = "select * from LoaiHang";
                SqlDataAdapter da = new SqlDataAdapter(SQL, connectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.DataList1.DataSource = dt;
                this.DataList1.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string ten = this.Login1.UserName;
            string matkhau = this.Login1.Password;
            string sql = "select * from KhachHang where TenDangNhap='" + ten
                + "' and MatKhau ='" + matkhau + "'";
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, connectionString);
                da.Fill(table);
            }
            catch (SqlException err)
            {
                Response.Write("<b>Error</b>" + err.Message + "<p/>");
            }
            if (table.Rows.Count != 0)
            {
                Response.Cookies["TenDangNhap"].Value = ten;
                Response.Write("<script>alert('Đăng nhập thành công')</script>");
                Server.Transfer("DanhSachSanPham.aspx");
            }
            else
            {
                this.Login1.FailureText = "Tên đăng nhập hay mật khẩu không đúng!";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string MaLoai = ((LinkButton)sender).CommandArgument;
            Context.Items["ml"] = MaLoai;
            Server.Transfer("DanhSachSanPham.aspx");
        }
    }
}