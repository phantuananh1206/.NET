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
    public partial class GioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            this.docDL();
        }

        private void docDL()
        {
            DataTable dt = (DataTable)Session["GioHang"];
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}