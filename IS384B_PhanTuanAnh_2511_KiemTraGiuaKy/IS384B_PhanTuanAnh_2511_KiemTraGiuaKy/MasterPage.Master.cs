using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace IS384B_PhanTuanAnh_2511_KiemTraGiuaKy
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        String connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNgayThangNam.Text = Convert.ToString(DateTime.Now);
            if (Page.IsPostBack) return;
            try
            {
                String SQL = "select * from LOAISACH";
                SqlDataAdapter da = new SqlDataAdapter(SQL, connectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dtlLoaiSach.DataSource = dt;
                this.dtlLoaiSach.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void lbtnLoaiSach_Click(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string ten = this.Login1.UserName;
            string matkhau = this.Login1.Password;
            string sql = "select * from KHACHHANG where TenDN = '" + ten
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
                Response.Cookies["TenDN"].Value = ten;
                Response.Write("<script>alert('Đăng nhập thành công')</script>");
                Server.Transfer("default.aspx");
            }
            else
            {
                Response.Write("<script>alert('Sai tên tài khoản hoặc mật khẩu')</script>");
            }
        }
    }
}