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
    public partial class giohang : System.Web.UI.Page
    {
        String ConnectionString = ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            this.docDL();

        }

        private void docDL()
        {
            DataTable dt = (DataTable)Session["giohang"];
            GridView1.DataSource = dt;
            GridView1.DataBind();        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSach");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("Hinh");
            dt.Columns.Add("TenSach");
            dt.Columns.Add("SoLuong");
            foreach(GridViewRow row in GridView1.Rows)
            {
                CheckBox checkbox = (CheckBox)row.FindControl("CheckBox1");
                if(!checkbox.Checked)
                {
                    DataRow dataRow = dt.NewRow();
                    dataRow["MaSach"] = row.Cells[0].Text.ToString();
                    dataRow["DonGia"] = row.Cells[1].Text.ToString();
                    dataRow["Hinh"] = ((Image)row.FindControl("Image1")).ImageUrl;
                    dataRow["TenSach"] = row.Cells[3].Text.ToString();
                    dataRow["SoLuong"] = row.Cells[4].Text.ToString();
                    dt.Rows.Add(dataRow);
                }
            }
            Session["giohang"] = dt;
            docDL();
        }
    }
}