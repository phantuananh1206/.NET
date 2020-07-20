using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebQUANLYBANHANG4._0.App_Code;

namespace WebQUANLYBANHANG4._0
{
    public partial class pageGioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["CART"] != null && !IsPostBack)
            {
                GIOHANG CART = (GIOHANG) Session["CART"];
                this.GridView1.DataSource = CART.DANHSACHGIOHANG();
                this.GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LoadCART(GIOHANG CART)
        {
            this.GridView1.DataSource = CART.DANHSACHGIOHANG();
            this.GridView1.DataBind();
            this.GridView1.FooterRow.Cells[4].Text = "Tổng tiền : ";
            this.GridView1.FooterRow.Cells[5].Text = CART.tinhTongTien().ToString();
        }

        protected void btnXOA_Click(object sender, EventArgs e)
        {
            if (Session["CART"] != null) { 
            GIOHANG CART = (GIOHANG)Session["CART"];
            foreach (GridViewRow row in this.GridView1.Rows)
            {
                CheckBox ckbitem = (CheckBox) row.FindControl("ckblITEM");
                if (ckbitem.Checked)
                {
                    String MaSP = row.Cells[0].Text;
                    CART.deleteItem(MaSP);
                }
            }
            Session["CART"] = CART;
            LoadCART(CART);
            }
        }

        protected void btnTHANHTOAN_Click(object sender, EventArgs e)
        {
            GIOHANG CART = (GIOHANG)Session["CART"];
            LoadCART(CART);
        }
    }
}