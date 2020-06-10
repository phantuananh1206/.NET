using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebQUANLYBANHANG4._0.App_Code;
namespace WebQUANLYBANHANG4._0.QuanTriWeb
{
    public partial class pageQuanTri1 : System.Web.UI.Page
    {
        XuLyDuLieu xuly;
        String sql;
        public void loadDropDownList()
        {
            sql = "select * from tbDANHMUC";
            this.drlMaDanhMuc.DataSource = xuly.layBangDuLieu(sql);
            this.drlMaDanhMuc.DataTextField = "TENDM";
            this.drlMaDanhMuc.DataValueField = "IDMADM";
            this.drlMaDanhMuc.DataBind();

        }
        public void loadGridViewDanhMuc()
        {
            sql = "select * from tbDANHMUC";
            this.grvDanhMuc.DataSource = xuly.layBangDuLieu(sql);
           // this.grvDanhMuc.DataBinding("");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            String path = Server.MapPath("\\App_Data\\dbQUANLYBANHANGONLINE.mdf");
            xuly = new XuLyDuLieu(path);
            loadDropDownList();
            loadGridViewDanhMuc();
        }
    }
}