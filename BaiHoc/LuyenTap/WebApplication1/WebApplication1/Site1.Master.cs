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
    public partial class Site1 : System.Web.UI.MasterPage
    {
        SqlConnection con = new SqlConnection();
        XuLyDuLieu xuLyDuLieu = new XuLyDuLieu();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IS384_ASP\QuanLyBanHang\QuanLyBanHang\App_Data\dbQuanLyBanHang.mdf;Integrated Security=True";
            if (Page.IsPostBack) return;
            String SQL = "select * from LoaiHang ";

            DataList1.DataSource = xuLyDuLieu.bangDuLieu(SQL);
            DataList1.DataBind();
        }

        protected void lbtnLoaiHang_Click(object sender, EventArgs e)
        {
            String maLoai = ((LinkButton)sender).CommandArgument;
            Context.Items["ml"] = maLoai;
            Server.Transfer("DanhSachSanPham.aspx");
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            String ten = Login1.UserName;
            String matkhau = Login1.Password;
            String SQL = " select * from KhachHang where TenDangNhap ='" + ten +
                "' and MatKhau ='" + matkhau + "'";
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(SQL, con);
                adp.Fill(table);
            }catch(SqlException ex)
            {
                Response.Write("Lỗi :" + ex.Message);
            }
            if (table.Rows.Count != 0)
            {
                Response.Cookies["TenDangNhap"].Value = ten;
                Response.Write("<script> alert('Đăng nhập thành công!'); </script>");
                Server.Transfer("DanhSachSanPham.aspx");
            }
            else
            {
                this.Login1.FailureText = "Tên đăng nhập hoặc mật khẩu không đúng!";
            }
        }
    }
}