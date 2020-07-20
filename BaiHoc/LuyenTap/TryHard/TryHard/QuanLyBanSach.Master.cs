using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace TryHard
{
    public partial class QuanLyBanSach : System.Web.UI.MasterPage
    {
        String connection = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        KetNoi ketNoi = new KetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            String SQL = "select * from LOAISACH";
            try
            {
                DataList1.DataSource = ketNoi.bangDuLieu(SQL);
                DataList1.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }

        }

        protected void lbtnLoaiSach_Click(object sender, EventArgs e)
        {
            String maLoai = ((LinkButton)sender).CommandArgument;
            Context.Items["ml"] = maLoai;
            Server.Transfer("DanhSachTheoLoai.aspx");
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            String tenDN = Login1.UserName;
            String matKhau = Login1.Password;

            String SQL = "select * from KHACHHANG where TenDN ='" + tenDN + "' and MatKhau ='" + matKhau + "'";
            DataTable dtTable = new DataTable();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(SQL, connection);
                adp.Fill(dtTable);
            }
            catch (SqlException ex)
            {

            }
            if (dtTable.Rows.Count != 0)
            {
                Response.Cookies["TenDN"].Value = tenDN;
                Response.Write("<script> alert('Đăng nhập thành công!'); </script>");
                Server.Transfer("DanhSachTheoLoai.aspx");
            }else
            {
                Login1.FailureText = "Sai tên đăng nhập hoặc mật khẩu!";
            }
        }
    }
}