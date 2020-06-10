using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebQUANLYBANHANG4._0.App_Code;
using System.Data;

namespace WebQUANLYBANHANG4._0

{
    public partial class pageCHITIETSANPHAMaspx : System.Web.UI.Page
    {
        XuLyDuLieu xuLy;
        protected void Page_Load(object sender, EventArgs e)
        {
            String path = Server.MapPath("App_Data\\dbQUANLYBANHANGONLINE.mdf");
            xuLy = new XuLyDuLieu(path);
            String idMaSP = Request.QueryString.Get("MaSanPham");
            if (idMaSP != null)
            {
                String sql = "select * from tbSANPHAM WHERE IDMASP='" + idMaSP + "'";
                DataTable tb = xuLy.layBangDuLieu(sql);
                this.Repeater2.DataSource = xuLy.layBangDuLieu(sql);
                this.Repeater2.DataBind();
                soLuongSP(Convert.ToInt32(tb.Rows[0]["SOLUONG"]));
            }
        }
        public void soLuongSP(int soLuong)
        {
            for (int i = 1; i <= soLuong; i++)
                this.drlSoLuong.Items.Add(i.ToString());
        }

        protected void btnGioHang_Click(object sender, EventArgs e)
        {
            String maSP = Request.QueryString.Get("MaSanPham");
            if (maSP != null)
            {
                String sql = "select IDMASP,TENSP,"+ drlSoLuong.SelectedValue + "AS SOLUONG,DONGIA,HINHANH,(SOLUONG * DONGIA) AS THANHTIEN from tbSANPHAM WHERE IDMASP='" + maSP + "'";
                DataTable tb = xuLy.layBangDuLieu(sql);
                GioHang gioHang = null;
                Session.Timeout = 1;
                if(Session["gioHang"] == null)
                {
                    gioHang = new GioHang();
                    gioHang.addItem(tb.Rows[0]);
                }else
                {
                    gioHang = (GioHang) Session["gioHang"];
                    gioHang.addItem(tb.Rows[0]);
                }
                Session["gioHang"] = gioHang;
                Response.Redirect("pageGIOHANG.aspx");
            }
        }
    }
}