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
    public partial class LoaiHang_RadioButtonList : System.Web.UI.Page
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
                this.RadioButtonList1.DataSource = dt;
                this.RadioButtonList1.DataTextField = "TenLoai";
                this.RadioButtonList1.DataValueField = "Maloai";
                this.RadioButtonList1.DataBind();
            }
            catch(SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String MaLoai = this.RadioButtonList1.SelectedItem.Value;
            Context.Items["m1"] = MaLoai;
            Server.Transfer("MatHangTheoLoai.aspx");
        }
    }
}