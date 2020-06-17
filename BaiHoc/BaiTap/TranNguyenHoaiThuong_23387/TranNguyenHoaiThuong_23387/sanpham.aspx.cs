using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TranNguyenHoaiThuong_23387
{

    public partial class sanpham : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        String ConnectionString = ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q;
            if (Context.Items["ml"] == null)
                q = "select * from SACH";
            else
            {
                string maloai = Context.Items["ml"].ToString();
                q = "select * from SACH where MaLoai = '" + maloai + "'";
            }
            try
            {
                this.DataList1.DataSource = kn.laydata(q);
                this.DataList1.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string masach = ((ImageButton)sender).CommandArgument;
            Context.Items["ms"] = masach;
            Server.Transfer("chitietsanpham.aspx");
        }
    }
}