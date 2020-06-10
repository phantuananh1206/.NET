using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebQUANLYBANHANG4._0
{
    public partial class pageDANGNHAP_DANGKI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control hienThi = new Control();
            if (this.RadioButtonList1.SelectedItem.Value == "1")
                hienThi = LoadControl("userLOGIN.ascx");
            else
                hienThi = LoadControl("userDANGKI.ascx");

            this.Panel1.Controls.Add(hienThi);
        }
    }
}