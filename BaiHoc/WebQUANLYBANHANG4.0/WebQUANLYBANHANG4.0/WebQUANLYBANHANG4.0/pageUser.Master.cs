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
    public partial class MasterUser : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String path = Server.MapPath("\\App_Data\\dbQUANLYBANHANG.mdf");
            XuLyDuLieu xulydulieu = new App_Code.XuLyDuLieu(path);

            String SQL = "SELECT * FROM tbDANHMUC";
            this.Repeater1.DataSource = xulydulieu.BangDuLieu(SQL);
            this.Repeater1.DataBind();

          /*  String IDMADM = Request.QueryString.Get("linkForID");
                    if (IDMADM != null)
           {
                String SQL = "SELECT * FROM tbDANHMUC WHERE IDMADM = " + IDMADM;
                this.Repeater1.DataSource = xulydulieu.BangDuLieu(SQL);
                this.Repeater1.DataBind();
            }
          */
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}