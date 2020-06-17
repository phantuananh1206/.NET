using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TranNguyenHoaiThuong_23387
{
    public partial class chitietsanpham : System.Web.UI.Page
    {
        ketnoi kn = new ketnoi();
        String ConnectionString = ConfigurationManager.ConnectionStrings["connec"].ConnectionString;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q;
            if (Context.Items["ms"] == null)
                q = "select * from Sach";
            else
            {
                string masach = Context.Items["ms"].ToString();
                q = "select * from Sach where MaSach = '" + masach + "'";
            }
            try
            {
                this.DataList1.DataSource = kn.laydata(q);
                this.DataList1.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }
        private void TaoGio()
        {
            dt = new DataTable();
            dt.Columns.Add("MaSach");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("Hinh");
            dt.Columns.Add("TenSach");
            dt.Columns.Add("SoLuong");
            Session["giohang"] = dt;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("giohang.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (Request.Cookies["TenDN"] == null) return;
            Button mua = (Button)sender;
            string masach = mua.CommandArgument.ToString();
            DataListItem item = (DataListItem)mua.Parent;
            string soluong = ((TextBox)item.FindControl("txtsoluong")).Text;
            if (soluong == "") return;
            string dongia = ((Label)item.FindControl("Label7")).Text;
            string tensach = ((Label)item.FindControl("Label2")).Text;
            string hinh = ((Image)item.FindControl("Image2")).ImageUrl;
            dt = (DataTable)Session["giohang"];
            bool tim = false;
            if (dt == null) TaoGio();
            foreach (DataRow dataRow in dt.Rows)
            {
                if (dataRow["MaSach"].Equals(masach))
                {
                    dataRow["SoLuong"] = Convert.ToInt32(dataRow["SoLuong"])
                        + Convert.ToInt32(soluong);
                    tim = true; break;
                }
            }
            if (!tim)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["MaSach"] = masach;
                dataRow["DonGia"] = dongia;
                dataRow["Hinh"] = hinh;
                dataRow["TenSach"] = tensach;
                dataRow["SoLuong"] = soluong;
                dt.Rows.Add(dataRow);
            }
            Session["giohang"] = dt;
        }
    }
}