using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebQUANLYBANHANG4._0
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookUser = Request.Cookies["UserName"];
            Response.Write(cookUser.Value);
            Response.Write("<br>");
            HttpCookie cookPassword = Request.Cookies["Password"];
            Response.Write(cookUser.Value);
        }
    }
}