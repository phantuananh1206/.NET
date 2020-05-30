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
    public partial class MatHangTheoLoai : System.Web.UI.Page
    {
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IS384_ASP\BaiThucHanh2\BaiThucHanh2\App_Data\dbQLSP.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            String maLoai = Context.Items["m1"].ToString();
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                String SQL = "select * from MatHang where MaLoai ='" + maLoai + "'";
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            String MaHang = ((LinkButton)sender).CommandArgument;
            Context.Items["mh"] = MaHang;
            Server.Transfer("ChiTietMatHang.aspx");
        }
    }
}