using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Exam
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
            DataTable dt = (DataTable)Session["giohang"];
            GridView1.DataSource = dt;
            GridView1.DataBind();           
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            DataTable dt = (DataTable)Session["giohang"];
            GridViewRow row = (GridViewRow)((LinkButton)e.CommandSource).Parent.Parent;
            string masach = ((LinkButton)e.CommandSource).CommandArgument;
            dt.Rows[row.DataItemIndex].Delete();
            Session["giohang"] = dt;
            this.docDL();
        }
    }
}