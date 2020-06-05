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
    public partial class _default : System.Web.UI.Page
    {
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IS384_ASP\BaiThucHanh2\BaiThucHanh2\App_Data\dbQLSP.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            String SQL = "select * from LoaiHang";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(SQL, connectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //this.rdlLoaiHang.DataSource = dt;
                //this.rdlLoaiHang.DataTextField = "TenLoai";
                //this.rdlLoaiHang.DataValueField = "Maloai";
                //this.rdlLoaiHang.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void rblLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void rdlLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String MaLoai = this.rdlLoaiHang.SelectedItem.Value;
            //Context.Items["m1"] = MaLoai;
            //Server.Transfer("WebForm1.aspx");
        }
    }
}