using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using WebQUANLYBANHANG4._0.App_Code;

namespace WebQUANLYBANHANG4._0
{


    public partial class pageCHITIETSANPHAM : System.Web.UI.Page
    {
        XuLyDuLieu xulydulieu;

        protected void Page_Load(object sender, EventArgs e)
        {
            String path = Server.MapPath("\\App_Data\\dbQUANLYBANHANG.mdf");
            xulydulieu = new App_Code.XuLyDuLieu(path);

            String LINKIDMASP = Request.QueryString.Get("LINKIDMASP");
            if (LINKIDMASP != null)
            {
             
                String SQL = "SELECT * FROM tbSANPHAM WHERE IDMASP = " + LINKIDMASP;
                DataTable tb = xulydulieu.BangDuLieu(SQL);
                this.Repeater2.DataSource = tb;
                this.Repeater2.DataBind();
                SoLuong(Convert.ToUInt16(tb.Rows[0]["SOLUONG"]));
            }
        }


        public void SoLuong(int SoLuong)
        {
            for (int i = 1; i <= SoLuong;i++)
            {
                this.drlSOLUONG.Items.Add(i.ToString());
            }
        }



        protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void btnGIOHANG_Click(object sender, EventArgs e)
        {
            String LINKIDMASP = Request.QueryString.Get("LINKIDMASP");
            if (LINKIDMASP != null)
            {
                string SQLGIOHANG = "SELECT IDMASP,TENSP,SOLUONG="+drlSOLUONG.SelectedValue
                    +",DONGIA,HINHANH,"+drlSOLUONG.SelectedValue+" * DONGIA AS THANHTIEN FROM tbSANPHAM WHERE IDMASP="+LINKIDMASP;
                DataTable TB = xulydulieu.BangDuLieu(SQLGIOHANG);
                GIOHANG CART = null;
                Session.Timeout = 1;
                if(Session["CART"] == null)
                {
                    CART = new GIOHANG();
                    //CART.addItem(TB.Rows[0]);
                }else
                {
                    CART = (GIOHANG)Session["CART"];
                  //  CART.addItem(TB.Rows[0]);
                }
                Int16 SoLuongTon = Convert.ToInt16(drlSOLUONG.Items[drlSOLUONG.Items.Count - 1].Value);
                if (CART.addItem(TB.Rows[0], SoLuongTon))
                {
                    Session["CART"] = CART;
                    Response.Redirect("pageGIOHANG.aspx");
                }else
                {
                    Response.Write("Số lượng trong giỏ hàng nhiều hơn kho");
                }
               
            }
        }
    }
}