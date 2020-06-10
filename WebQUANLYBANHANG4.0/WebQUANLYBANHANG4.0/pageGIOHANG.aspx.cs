using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebQUANLYBANHANG4._0.App_Code;

namespace WebQUANLYBANHANG4._0
{
    public partial class pageGIOHANG : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["gioHang"] != null)
            {
                GioHang gioHang = (GioHang)Session["gioHang"];
                this.grvGioHang.DataSource = gioHang.loadDanhSachSanPham();
                this.grvGioHang.DataBind();

            }
        }
    }
}