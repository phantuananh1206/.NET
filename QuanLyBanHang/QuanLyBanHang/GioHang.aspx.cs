using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyBanHang
{
    public partial class GioHang : System.Web.UI.Page
    {
        String connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        XuLyDuLieu xuLyDuLieu = new XuLyDuLieu();
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
            double tong = 0;
            foreach(DataRow dataRow in dt.Rows)
            {
                double thanhtien = Convert.ToDouble(dataRow["SoLuong"]) * Convert.ToDouble(dataRow["DonGia"]);
                  tong = tong + thanhtien;
            }
            //for (int i = 0; i < dt.Rows.Count; i++  )
            //{
            //    double thanhtien = Convert.ToDouble(dt.Rows[i]["SoLuong"]) * Convert.ToDouble(dt.Rows[i]["DonGia"]);
            //    tong = tong + thanhtien;
            //}
            this.Label1.Text = "Tổng tiền: " + tong;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string mahang = GridView1.DataKeys[e.RowIndex].Value.ToString();
            DataTable dt = (DataTable)Session["giohang"];
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["MaHang"].Equals(mahang))
                {
                    dr.Delete();
                    Response.Write("<script>alert('Xóa thành công!');</script>");
                    break;
                }
            }
            docDL();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            string mahang = GridView1.DataKeys[e.RowIndex].Value.ToString();
            string soluong = (row.Cells[4].Controls[0] as TextBox).Text;
            DataTable dt = (DataTable)Session["giohang"];
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["MaHang"].Equals(mahang))
                {
                    dt.Rows[row.DataItemIndex]["SoLuong"] = Convert.ToInt32(soluong);
                    Response.Write("<script>alert('Sửa thành công!');</script>");
                    Response.Redirect("GioHang.aspx");
                    break;
                }
            }
            docDL();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            docDL();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            docDL();
        }

    }
}