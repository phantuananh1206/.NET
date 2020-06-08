using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoHitCounter
{
    public partial class ThongKe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSoLuotTC.Text = Application["SoLuotTruyCap"].ToString();
            lblOnline.Text = Application["SLOnline"].ToString();
        }
    }
}