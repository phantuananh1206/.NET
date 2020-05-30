using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace BaiThucHanh2
{
    public partial class LoaiHang_DropdownList : System.Web.UI.Page
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
                this.DropDownList1.DataSource = dt;
                this.DropDownList1.DataTextField = "TenLoai";
                this.DropDownList1.DataValueField = "MaLoai";
                this.DropDownList1.DataBind();
            }catch(SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}