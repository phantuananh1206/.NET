using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        XuLyDuLieu xuLyDuLieu = new XuLyDuLieu();
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            String SQL;
            if (Context.Items["mh"] == null)
            {
                SQL = "Select * from MatHang";
            }else
            {
                String maHang = Context.Items["mh"].ToString();
                SQL = "select * from MatHang where MaHang ='" + maHang + "'";
            }
            try
            {
                DataList2.DataSource = xuLyDuLieu.bangDuLieu(SQL);
                DataList2.DataBind();
            }catch(SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        private void taoGio()
        {
            dt = new DataTable();
            dt.Columns.Add("MaHang");
            dt.Columns.Add("TenHang");
            dt.Columns.Add("SoLuong");
            Session["GioHang"] = dt;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            String tenDn;
            if (Request.Cookies["TenDangNhap"] != null)
                tenDn = Request.Cookies["TenDangNhap"].ToString();
            else
                tenDn = "";
            if (tenDn == "")
            {
                Response.Write("<script> alert('Bạn chưa đăng nhập!'); </script>");
                return;
            }
            else
                Response.Write("<script> alert('Mua hàng thành công!'); </script>");

            LinkButton mua = (LinkButton)sender;
            string maHang = mua.CommandArgument.ToString();
            DataListItem item = (DataListItem)mua.Parent;
            String soLuong = ((DropDownList)item.FindControl("ddlSoLuong")).SelectedValue;
            String tenHang = ((Label)item.FindControl("Label1")).Text;
            dt = (DataTable)Session["Giohang"];
            bool tim = false;
            if (dt == null) taoGio();
            foreach(DataRow dataRow in dt.Rows)
            {
                if (dataRow["MaHang"].Equals(maHang))
                {
                    dataRow["SoLuong"] = Convert.ToInt32(dataRow["SoLuong"])
                        + Convert.ToInt32(soLuong);
                    tim = true;
                    break;
                }
            }
            if (!tim)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["MaHang"] = maHang;
                dataRow["SoLuong"] = soLuong;
                dataRow["TenHang"] = tenHang;
                dt.Rows.Add(dataRow);
            }
            Session["Giohang"] = dt;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            if (Session["GioHang"] == null)
            {
                Response.Write("<script> alert('Giỏ hàng còn trống!') </script>");
                return;
            }
            Server.Transfer("GioHang.aspx");
        }
    }
}