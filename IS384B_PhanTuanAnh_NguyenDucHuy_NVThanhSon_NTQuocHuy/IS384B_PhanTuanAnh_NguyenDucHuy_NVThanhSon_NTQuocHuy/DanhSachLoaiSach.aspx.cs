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
    public partial class DanhSachLoaiSach : System.Web.UI.Page
    {
        String connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q;
            if (Context.Items["ml"] == null)
                q = "select * from Sach";
            else
            {
                string maloai = Context.Items["ml"].ToString();
                q = "select * from Sach where MaLoai = '" + maloai + "'";
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(q, connectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dtlDanhSachSach.DataSource = dt;
                this.dtlDanhSachSach.DataBind();

                clPager.PageSize = 3;
                clPager.DataSource = dt.DefaultView;
                clPager.BindToControl = dtlDanhSachSach;
                dtlDanhSachSach.DataSource = clPager.DataSourcePaged;

            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void lbtnChiTiet_Click(object sender, EventArgs e)
        {
            String MaSach = ((LinkButton)sender).CommandArgument;
            Context.Items["ms"] = MaSach;
            Server.Transfer("ChiTietSach.aspx");
        }
    }
}