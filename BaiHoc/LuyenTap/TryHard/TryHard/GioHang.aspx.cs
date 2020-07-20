using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TryHard
{
    public partial class GioHang : System.Web.UI.Page
    {
        KetNoi ketNoi = new KetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            docDL();
        }

        public void docDL()
        {
            DataTable dtTable = (DataTable)Session["GioHang"];
            GridView1.DataSource = dtTable;
            GridView1.DataBind();
        }
    }
}