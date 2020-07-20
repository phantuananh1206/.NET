using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;              /*-----Disconnect*/
using System.Data.SqlClient;    /*-----Connect Database Server*/
using WebQUANLYBANHANG4._0.App_Code;
namespace WebQUANLYBANHANG4._0
{
    public partial class pageDANHSACHSANPHAM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String path = Server.MapPath("\\App_Data\\dbQUANLYBANHANG.mdf");
            XuLyDuLieu xulydulieu = new App_Code.XuLyDuLieu(path);

            String IDMADM = Request.QueryString.Get("linkForID");

          
            if (IDMADM != null)
            {
                String SQL = "SELECT * FROM tbSANPHAM WHERE IDMADM = " + IDMADM;
                this.DataList1.DataSource = xulydulieu.BangDuLieu(SQL);
                this.DataList1.DataBind();
            }
           
        }


    }
}