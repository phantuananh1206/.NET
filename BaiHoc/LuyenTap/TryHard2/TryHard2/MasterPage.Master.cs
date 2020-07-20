using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TryHard2
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        KetNoi ketNoi = new KetNoi();
        String connection = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            String SQL = "select * from NHOMTHIETBI";
            dtlLoaiThietBi.DataSource = ketNoi.bangDuLieu(SQL);
            dtlLoaiThietBi.DataBind();
        }

        protected void lbtnLoaiThietBi_Click(object sender, EventArgs e)
        {
            String maNhom = ((LinkButton)sender).CommandArgument;
            Context.Items["mn"] = maNhom;
            Server.Transfer("DanhSachThietBi.aspx");
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
                Response.Write(ex.Message);
            }

            if (dtTable.Rows.Count != 0)
            {
                Response.Cookies["TenDN"].Value = tenDN;
                Response.Write("<script> alert('Đăng nhập thành công!'); </script>");
                Server.Transfer("DanhSachThietBi.aspx");
            }
            else
            {
                Login1.FailureText = "Sai tên đăng nhập hoặc mật khẩu!";
            }
        }
    }
}