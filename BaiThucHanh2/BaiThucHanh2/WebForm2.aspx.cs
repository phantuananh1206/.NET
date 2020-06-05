using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace BaiThucHanh2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IS384_ASP\BaiThucHanh2\BaiThucHanh2\App_Data\dbQLSP.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            String maHang = Context.Items["mh"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                String SQL = "select * from MatHang where MaHang ='" + maHang + "'";
                SqlCommand cmd = new SqlCommand(SQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                this.DataList1.DataSource = reader;
                this.DataList1.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write("Lỗi " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button mua = (Button)sender;
            string MaHang = mua.CommandArgument.ToString();
            DataListItem item = (DataListItem)mua.Parent;
            string soluong = ((TextBox)item.FindControl("txtSoLuong")).Text;
            if (Request.Cookies["TenDangNhap"] == null) return;
            string ten = Request.Cookies["TenDangNhap"].Value;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            String query = "select * from DonHang "
                    + "where TenDangNhap ='" + ten + "' and MaHang ='" + MaHang + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                cmd = new SqlCommand(
                    "update DonHang set SoLuong = Soluong + " + soluong
                    + "where TenDangNhap ='" + ten + "' and MaHang ='" + MaHang + "'", con);
            }
            else
            {
                reader.Close();
                cmd = new SqlCommand("insert into DonHang "
                   + "(TenDangNhap, MaHang, SoLuong) values('"
                   + ten + "', '" + MaHang + "'," + soluong + ")", con);
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Server.Transfer("giohang.aspx");
        }
    }
}