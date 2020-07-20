using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebQUANLYBANHANG4._0
{
    public partial class pageDangNhapDangKy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control hienThi = new Control();
            if(this.rbtDangNhapDangKy.SelectedItem.Value == "1")
            {
                hienThi = this.LoadControl("uscDangNhap.ascx"); 
            }
            else
            {
                hienThi = this.LoadControl("uscDangKy.ascx");
            }
            Panel1.Controls.Add(hienThi);

        }
    }
}