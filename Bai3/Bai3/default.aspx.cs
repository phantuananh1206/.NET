using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai3
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Context.Items["gianhang"] = LinkButton1.Text;
            Server.Transfer("GianHang.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Context.Items["gianhang"] = LinkButton2.Text;
            Server.Transfer("GianHang.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Context.Items["gianhang"] = LinkButton3.Text;
            Server.Transfer("GianHang.aspx");
        }
    }
}