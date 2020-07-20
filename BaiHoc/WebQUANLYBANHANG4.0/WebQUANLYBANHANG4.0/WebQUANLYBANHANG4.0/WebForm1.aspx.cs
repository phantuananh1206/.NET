using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebQUANLYBANHANG4._0
{
    public partial class WebForm1 : System.Web.UI.Page
    {
    //    HiddenField HoTen;
        protected void Page_Load(object sender, EventArgs e)
        {
    //    HoTen = new HiddenField();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookUsername = new HttpCookie("UserName", txtUsername.Text);
            HttpCookie cookPassword = new HttpCookie("Password", txtPassword.Text);
            Response.Cookies.Add(cookUsername);
            Response.Cookies.Add(cookPassword);
            Response.Redirect("WebForm2.aspx");
            
        }
    }
}