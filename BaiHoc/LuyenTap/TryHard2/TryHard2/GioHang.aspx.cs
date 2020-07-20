using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TryHard2
{
    public partial class GioHang : System.Web.UI.Page
    {
        KetNoi ketNoi = new KetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.docDL();
        }

        public void docDL()
        {
            DataTable dtTable = (DataTable) Session["GioHang"];
            grvGioHang.DataSource = dtTable;
            grvGioHang.DataBind();
        }
    }
}