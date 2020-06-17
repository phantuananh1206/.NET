using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace IS384B_PhanTuanAnh_NguyenDucHuy_NVThanhSon_NTQuocHuy
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        String connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            try
            {
                String SQL = "select * from LoaiSach";
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

        protected void lbtnLoaiSach_Click1(object sender, EventArgs e)
        {
            String MaLoai = ((LinkButton)sender).CommandArgument;
            Context.Items["m1"] = MaLoai;
            Server.Transfer("DanhSachLoaiSach.aspx");
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string ten = this.Login1.UserName;
            string matkhau = this.Login1.Password;
            string sql = "select * from KhachHang where TenDN='" + ten
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
                Server.Transfer("DanhSachLoaiSach.aspx");
            }
            else
            {
                this.Login1.FailureText = "Tên đăng nhập hay mật khẩu không đúng!";
            }
        }
    }
}