using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanHang
{
    public partial class GioHang : System.Web.UI.Page
    {
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IS384_ASP\QuanLyBanHang\QuanLyBanHang\App_Data\dbQuanLyBanHang.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string q = "select DonHang.MaHang,TenHang,MoTa,DonGia,SoLuong,"
                    + "SoLuong*DonGia as ThanhTien from DonHang,MatHang"
                    + " where MatHang.MaHang = DonHang.MaHang";
                SqlDataAdapter da = new SqlDataAdapter(q, connectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.GridView1.DataSource = dt;
                this.GridView1.DataBind();
                double tong = 0;
                foreach (DataRow row in dt.Rows)
                {
                    double thanhtien = Convert.ToDouble(row["thanhtien"]);
                    tong = tong + thanhtien;
                }
                this.Label1.Text = "Tổng thành tiền: " + tong + " đồng";
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}