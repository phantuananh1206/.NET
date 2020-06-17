using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Final_Exam
{
    public partial class ChiTietSP : System.Web.UI.Page
    {
        string connect = ConfigurationManager.ConnectionStrings["QuanLyBanSach"].ConnectionString;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q;
            if (Context.Items["mh"] == null)
                q = "SELECT * FROM SACH";
            else
            {
                string masach = Context.Items["mh"].ToString();
                q = "SELECT * FROM SACH WHERE MaSach = '" + masach + "'";
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(q, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.DataList1.DataSource = dt;
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
            Session["giohang"] = dt;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["TenDN"] == null) return;
            Button mua = (Button)sender;
            string masach = mua.CommandArgument.ToString();
            DataListItem item = (DataListItem)mua.Parent;
            string dongia = ((Label)item.FindControl("Label2")).Text;
            string ten = ((Label)item.FindControl("tensach")).Text;
            string hinh = ((Image)item.FindControl("Image1")).ImageUrl;
            dt = (DataTable)Session["giohang"];
            bool tim = false;
            if (dt == null) TaoGio();
            foreach(DataRow dataRow in dt.Rows)
            {
                if (dataRow["MaSach"].Equals(masach))
                {
                    tim = true;
                    break;
                }
            }
            if (!tim)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["MaSach"] = masach;
                dataRow["DonGia"] = dongia;
                dataRow["Hinh"] = hinh;
                dataRow["TenSach"] = ten;
                dt.Rows.Add(dataRow);
            }
            Session["giohang"] = dt;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Server.Transfer("GioHang.aspx");
        }
    }
}