using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DemoDB
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT * from KhachHang where TenDN ='{0}' AND MatKhau ='{1}'";
            SQL = String.Format(SQL, txtTenDangNhap.Text, txtMatKhau.Text);
            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IS384_ASP\DemoDB\DemoDB\App_Data\dbDemo.mdf;Integrated Security=True";
            SqlConnection connect = new SqlConnection(connectionString);
            SqlDataAdapter adap = new SqlDataAdapter(SQL, connect);
            DataTable table = new DataTable();
            adap.Fill(table);
            if (table.Rows.Count == 0)
            {
                lblThongBao.Text = "Ban nhap sai";
                
            }
            else
            {
                lblThongBao.Text = "Chào " + table.Rows[0]["TenKH"];
            }
        }
    }
}