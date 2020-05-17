using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebForm
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            lblHienThi.Text = "Xin chào " + txt1.Text; 
        }
    }
}