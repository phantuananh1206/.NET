using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace IS384B_PhanTuanAnh_NguyenDucHuy_NVThanhSon_NTQuocHuy
{
    public partial class ChiTietSach : System.Web.UI.Page
    {
        String connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            String maSach = Context.Items["ms"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                String SQL = "select * from Sach where MaSach ='" + maSach + "'";
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

        protected void btnMuaSach_Click(object sender, EventArgs e)
        {
            Button mua = (Button)sender;
            string MaSach = mua.CommandArgument.ToString();
            DataListItem item = (DataListItem)mua.Parent;
            string soluong = ((TextBox)item.FindControl("txtSoLuong")).Text;
            if (Request.Cookies["TenDN"] == null) return;
            String ten = Request.Cookies["TenDN"].Value;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            String query = "select * from DonHang "
                    + "where TenDN ='" + ten + "' and MaSach ='" + MaSach + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                cmd = new SqlCommand(
                    "update DonHang set SoLuong = Soluong + " + soluong
                    + "where TenDN ='" + ten + "' and MaSach ='" + MaSach + "'", con);
            }
            else
            {
                reader.Close();
                cmd = new SqlCommand("insert into DonHang "
                   + "(TenDN, MaSach, SoLuong) values('"
                   + ten + "', '" + MaSach + "'," + soluong + ")", con);
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void lbtnGioHang_Click(object sender, EventArgs e)
        {
            Server.Transfer("GioHang.aspx");
        }
    }
}