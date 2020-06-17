using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SachTheoLoai : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        string query;
        string masach;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string tendn = Request.Cookies["tendn"] != null ? Request.Cookies["tendn"].Value : "";
            string maloai = Context.Items["maloai"] != null ? Context.Items["maloai"].ToString() : null;
            if (tendn == "")
            {
                Response.Write("<script>alert('Chưa Đăng Nhập');</script>");
                Server.Transfer("Default.aspx");
            }

            if (maloai == null)
            {
                query = "select * from Sach";
                Response.Write("<script>alert('Chưa chọn loại sách, đây là tất cả sách');</script>");
            }
            else
            {
                query = "select * from SACH where maloai ='" + maloai + "'";
            }
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connectionString);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                this.DataList1.DataSource = dataTable;
                this.DataList1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            masach = ((LinkButton)sender).CommandArgument;
            TransferTo();
        }

        protected void Image_Click(object sender, ImageClickEventArgs e)
        {
            masach = ((ImageButton)sender).CommandArgument;
            TransferTo();

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            masach = ((LinkButton)sender).CommandArgument;
            TransferTo();
        }

        protected void TransferTo()
        {
            Context.Items["masach"] = masach;
            Server.Transfer("ChiTietSach.aspx");
        }
    }
}