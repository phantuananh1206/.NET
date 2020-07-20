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
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        String connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q;
            if (Context.Items["mh"] == null)
                q = "select * from MatHang";
            else
            {
                string mahang = Context.Items["mh"].ToString();
                q = "select * from MatHang where MaHang = '" + mahang + "'";
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(q, connectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.DataList1.DataSource = dt;
                this.DataList1.DataBind();

            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        private void TaoGio()
        {
            dt = new DataTable();
            dt.Columns.Add("MaHang");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("TenHang");
            dt.Columns.Add("Hinh");
            dt.Columns.Add("SoLuong");
            Session["giohang"] = dt;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string tendn;
            if (Request.Cookies["TenDangNhap"] != null)
                tendn = Request.Cookies["TenDangNhap"].Value;
            else
                tendn = "";
            if (tendn == "")
            {
                Response.Write("<script>alert('Chưa Đăng Nhập!');</script>");
                return;
            }
            else
            {
                Response.Write("<script>alert('Mua hàng thành công!');</script>");
            }
            Button mua = (Button)sender;
            string maHang = mua.CommandArgument.ToString();
            DataListItem item = (DataListItem)mua.Parent;
            string soluong = ((TextBox)item.FindControl("txtsoluong")).Text;
            if (soluong == "") return;
            string dongia = ((Label)item.FindControl("lblDonGia")).Text;
            string ten = ((Label)item.FindControl("lblTenHang")).Text;
            string hinh = ((Image)item.FindControl("Image2")).ImageUrl;
            dt = (DataTable)Session["giohang"];
            bool tim = false;
            if (dt == null) TaoGio();
            foreach (DataRow dataRow in dt.Rows)
            {
                if (dataRow["MaHang"].Equals(maHang))
                {
                    dataRow["SoLuong"] = Convert.ToInt32(dataRow["SoLuong"])
                        + Convert.ToInt32(soluong);
                    tim = true;
                    break;
                }
            }
            if (!tim)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["MaHang"] = maHang;
                dataRow["DonGia"] = dongia;
                dataRow["TenHang"] = ten;
                dataRow["Hinh"] = hinh;
                dataRow["SoLuong"] = soluong;
                dt.Rows.Add(dataRow);
            }
            Session["giohang"] = dt;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (Session["giohang"] == null)
            {
                Response.Write("<script>alert('Giỏ Hàng hiện tại đang trống');</script>");
                return;
            }
            Server.Transfer("GioHang.aspx");
        }
    }
}