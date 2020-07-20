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
    public partial class GioHang : System.Web.UI.Page
    {
        String connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        KetNoi ketNoi = new KetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            docDL();
        }

        public void docDL()
        {
            DataTable dt = (DataTable)Session["GioHang"];
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}