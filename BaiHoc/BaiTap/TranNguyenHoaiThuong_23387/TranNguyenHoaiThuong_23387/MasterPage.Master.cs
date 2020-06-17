using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TranNguyenHoaiThuong_23387
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        ketnoi kn = new ketnoi();
        String ConnectionString = ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            try
            {
                String q = "select * from LOAISACH";
                this.DataList1.DataSource = kn.laydata(q);
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
            string sql = "select * from KHACHHANG where TenDN='" + ten + "' and MatKhau ='" + matkhau + "'";
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, ConnectionString);
                da.Fill(table);
            }
            catch (SqlException err)
            {
                Response.Write("<b>Error</b>" + err.Message + "<p/>");
            }

            if (table.Rows.Count != 0)
            {
                Response.Cookies["TenDN"].Value = ten;
                Session["TenDN"] = ten;
                Session["isLogin"] = "Yes";
                this.Login1.FailureText = "Đăng nhập thành công!";
            }
            else
                this.Login1.FailureText = "Tên đăng nhập hay mật khẩu không đúng!";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string maloai = ((LinkButton)sender).CommandArgument;

            Context.Items["ml"] = maloai;
            Server.Transfer("sanpham.aspx");
        }
    }
}