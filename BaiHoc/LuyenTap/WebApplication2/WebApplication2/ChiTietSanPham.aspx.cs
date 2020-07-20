using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication2
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        String connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        KetNoi ketNoi = new KetNoi();
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            String SQL;
            if (Context.Items["mh"] == null)
                SQL = "select * from MatHang";
            else
            {
                String maHang = Context.Items["mh"].ToString();
                SQL = "select * from MatHang where MaHang ='" + maHang + "'";
            }
            try
            {
                DataList2.DataSource = ketNoi.bangDuLieu(SQL);
                DataList2.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        private void taoGio()
        {
            dt = new DataTable();
            dt.Columns.Add("MaHang");
            dt.Columns.Add("TenHang");
            dt.Columns.Add("Hinh");
            dt.Columns.Add("SoLuong");
            Session["Giohang"] = dt;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String tenDN;
            if (Request.Cookies["TenDangNhap"] != null)
            {
                tenDN = Request.Cookies["TenDangNhap"].Value;
            }else
            {
                tenDN = "";
            }
            if (tenDN == "")
            {
                Response.Write("<script> alert('Bạn chưa đăng nhập!');</script>");
            }else
            {
                Response.Write("<script> alert('Mua hàng thành công!');</script>");
            }

            Button mua = (Button)sender;
            String maHang = mua.CommandArgument.ToString();
            DataListItem item = (DataListItem)mua.Parent;
            String soLuong = ((DropDownList)item.FindControl("DropDownList1")).Text;
            if (soLuong == "") return;
            String tenHang = ((Label)item.FindControl("Label1")).Text;
            String hinh = ((Image)item.FindControl("Image1")).ImageUrl;
            dt = (DataTable)Session["GioHang"];
            bool tim = false;
            if (dt == null) taoGio();
            foreach(DataRow dataRow in dt.Rows)
            {
                if (dataRow["MaHang"].Equals(maHang))
                {
                    dataRow["SoLuong"] = Convert.ToInt32(dataRow["SoLuong"]) + Convert.ToInt32(soLuong);
                    tim = true;
                    break;
                }
            }

            if (!tim)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["MaHang"] = maHang;
                dataRow["TenHang"] = tenHang;
                dataRow["SoLuong"] = soLuong;
                dataRow["Hinh"] = hinh;
                dt.Rows.Add(dataRow);
            }
            Session["GioHang"] = dt;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            if (Session["GioHang"] == null)
            {
                Response.Write("<script> alert('Giỏ hàng còn trống!');</script>");
                return;
            }
            Server.Transfer("GioHang.aspx");
        }
    }
}