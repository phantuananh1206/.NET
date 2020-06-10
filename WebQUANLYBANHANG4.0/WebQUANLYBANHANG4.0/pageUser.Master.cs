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
    public partial class MasterUser : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            String path = Server.MapPath("App_Data\\dbQUANLYBANHANGONLINE.mdf");
            XuLyDuLieu xuLy = new XuLyDuLieu(path);
            String sql = "select * from tbDANHMUC";
            this.Repeater1.DataSource = xuLy.layBangDuLieu(sql);
            this.Repeater1.DataBind();

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }
    }


}