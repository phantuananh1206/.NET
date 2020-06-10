using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using WebQUANLYBANHANG4._0.App_Code;

namespace WebQUANLYBANHANG4._0
{
    public partial class pageDANHSACHSANPHAM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String path = Server.MapPath("App_Data\\dbQUANLYBANHANGONLINE.mdf");
            XuLyDuLieu xuLy = new XuLyDuLieu(path);
            String idMaDM = Request.QueryString.Get("madanhmuc");
            if(idMaDM != null)
            {
                String sql = "select * from tbSANPHAM WHERE IDMADM='"+ idMaDM+"'";
                this.DataList1.DataSource = xuLy.layBangDuLieu(sql);
                this.DataList1.DataBind();
            }
           
        }
    }
}