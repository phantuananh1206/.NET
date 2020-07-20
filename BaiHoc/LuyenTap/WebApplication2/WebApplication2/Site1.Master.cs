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
    public partial class Site1 : System.Web.UI.MasterPage
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        KetNoi ketNoi = new KetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            try
            {
                String SQL = "select * from LoaiHang";
                DataList1.DataSource = ketNoi.bangDuLieu(SQL);
                DataList1.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            String maLoai = ((LinkButton)sender).CommandArgument;
            Context.Items["ml"] = maLoai;
            Server.Transfer("DanhSachSanPham.aspx");
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            String ten = Login1.UserName;
            String matKhau = Login1.Password;

            String SQL = "select * from KhachHang where TenDangNhap ='" + ten + "' and MatKhau ='" + matKhau + "'";
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(SQL, connectionString);
                adp.Fill(table);
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
            if (table.Rows.Count != 0)
            {
                Response.Cookies["TenDangNhap"].Value = ten;
                Response.Write("<script> alert('Đăng nhập thành công!');</script>");
                Server.Transfer("DanhSachSanPham.aspx");
            }
            else
            {
                Login1.FailureText = "Tên đăng nhập hoặc mật khẩu không đúng!";
            }
        }
    }
}