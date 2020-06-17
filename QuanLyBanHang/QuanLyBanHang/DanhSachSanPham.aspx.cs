using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;

namespace QuanLyBanHang
{
    public partial class DanhSachSanPham : System.Web.UI.Page
    {
        String connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q;
            if (Context.Items["ml"] == null)
                q = "select * from MatHang";
            else
            {
                string maloai = Context.Items["ml"].ToString();
                q = "select * from MatHang where MaLoai = '" + maloai + "'";
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(q, connectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //this.DataList2.DataSource = dt;
                //this.DataList2.DataBind();

                clPager.PageSize = 6;
                clPager.DataSource = dt.DefaultView;
                clPager.BindToControl = DataList2;
                DataList2.DataSource = clPager.DataSourcePaged;

            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            String MaHang = ((LinkButton)sender).CommandArgument;
            Context.Items["mh"] = MaHang;
            Server.Transfer("ChiTietSanPham.aspx");
        }
    }
}