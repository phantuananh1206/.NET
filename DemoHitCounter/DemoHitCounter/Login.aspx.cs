using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoHitCounter
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.Cookies["MaTV"] != null)
                {
                    txtMaTV.Text = Request.Cookies["MaTV"].Value;
                    txtMatKhau.Text = Request.Cookies["MatKhau"].Value;
                    chkGhiNho.Checked = true;
                }
            }
            this.hienThi();
        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Length < 6)
            {
                Label1.Text = "Mật khẩu phải ít nhất 6 ký tự!";
            }
            else
            {
                HttpCookie ckiMaTV = new HttpCookie("MaTV", txtMaTV.Text);
                HttpCookie ckiMatKhau = new HttpCookie("MatKhau", txtMatKhau.Text);
                if (chkGhiNho.Checked)
                {
                    ckiMaTV.Expires = DateTime.Now.AddMonths(1);
                    ckiMatKhau.Expires = DateTime.Now.AddMonths(1);
                    Label1.Text = "Tài khoản đã được ghi nhớ!";

                    //Session["MaTV"] = txtMaTV.Text;
                    //Session["ThoiDiem"] = DateTime.Now;
                    //Session["Hinh"] = "cayto.jpg";
                }
                else
                {
                    ckiMaTV.Expires = DateTime.Now.AddMonths(-1);
                    ckiMatKhau.Expires = DateTime.Now.AddMonths(-1);
                    Label1.Text = "Tài khoản không còn ghi nhớ nữa!";
                }

                Session["MaTV"] = txtMaTV.Text;
                Session["ThoiDiem"] = DateTime.Now;
                Session["Hinh"] = "cayto.jpg";

                Response.Cookies.Add(ckiMaTV);
                Response.Cookies.Add(ckiMatKhau);

                this.hienThi();
            }
        }

        protected void lnkDangXuat_Click(object sender, EventArgs e)
        {
            Session.Remove("MaTV");
            Session.Remove("ThoiDiem");

            this.hienThi();
        }

        void hienThi()
        {
            if (Session["MaTV"] == null)
                MultiView1.ActiveViewIndex = 0;
            else
            {
                MultiView1.ActiveViewIndex = 1;
                lblMaTV.Text = Session["MaTV"].ToString();
                lblThoiDiem.Text = ((DateTime)Session["ThoiDiem"]).ToString("dd-MM-yyyy HH:mm:ss");
                Image1.ImageUrl = "~/images/" + Session["Hinh"].ToString();
            }
        }
    }
}