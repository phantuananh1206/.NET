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
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            query = "select * from LOAISACH";
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

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string tendn = tbUser.Text;
            string matkhau = tbPass.Text;
            query = "select * from KHACHHANG where tendn='" + tendn + "' and matkhau='" + matkhau + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connectionString);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 0)
            {
                lblUser.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            else
            {
                Response.Cookies["tendn"].Value = tendn;
                Server.Transfer("Default.aspx");
            }
            
        }

        protected void LinkBtnDanhMucLoaiSach_Click(object sender, EventArgs e)
        {
            string tendn = Request.Cookies["tendn"] != null ? Request.Cookies["tendn"].Value : "";
            if (tendn == "")
            {
                Response.Write("<script>alert('Vui lòng đăng nhập trước');</script>");
                return;
            }
            Context.Items["maloai"] = ((LinkButton)sender).CommandArgument.ToString();
            Server.Transfer("SachTheoLoai.aspx");
        }
    }
}