using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeWork1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        private void tinhToan()
        {
            try
            {
                double kq = 0;
                double A = Convert.ToDouble(txtA.Text);
                double B = Convert.ToDouble(txtB.Text);
                switch (ddlToanTu.SelectedValue)
                {
                    case "+":
                        kq = A + B;
                        break;
                    case "-":
                        kq = A - B;
                        break;
                    case "*":
                        kq = A * B;
                        break;
                    case "/":
                        kq = A / B;
                        break;
                }
                txtKetQua.Text = kq.ToString();
            }
            catch(Exception ex)
            {
                
            }
            
        }

        protected void btnTinh_Click1(object sender, EventArgs e)
        {
            tinhToan();
            //Response.Write("Bạn thực hiện phép tính " + ddlToanTu.SelectedItem + "!");
            lblHienThi.Text = "Bạn thực hiện phép tính " + ddlToanTu.SelectedItem + "!";
        }
    }
}