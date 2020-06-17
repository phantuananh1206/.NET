using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Final_Exam
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        string connect = ConfigurationManager.ConnectionStrings["QuanLyBanSach"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            try
            {
                string q = "SELECT * FROM LOAISACH";
                SqlDataAdapter da = new SqlDataAdapter(q, connect);
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string maloai = ((LinkButton)sender).CommandArgument;
            Context.Items["ml"] = maloai;
            Server.Transfer("SanPham.aspx");
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string ten = this.Login1.UserName;
            string matkhau = this.Login1.Password;
            string sql = "SELECT * FROM KHACHHANG WHERE TenDN = '" + ten + "' AND MatKhau = '" + matkhau + "'";
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, connect);
                da.Fill(table);
            }
            catch (SqlException ex)
            {
                Response.Write("<b>Errorr</b>" + ex.Message + "<p/>");
            }
            if (table.Rows.Count != 0)
            {
                Response.Cookies["TenDN"].Value = ten;
                Server.Transfer("SanPham.aspx");
            }
            else
                this.Login1.FailureText = "Tên đăng nhập hay mật khẩu không đúng";
        }
    }
}