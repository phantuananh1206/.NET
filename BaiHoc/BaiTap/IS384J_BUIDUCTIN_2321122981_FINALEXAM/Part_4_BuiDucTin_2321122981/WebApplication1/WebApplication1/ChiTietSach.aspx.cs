using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ChiTietSach : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        string masach;
        string query;
        DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string tendn = Request.Cookies["tendn"] != null ? Request.Cookies["tendn"].Value : "";
            if (tendn == "")
            {
                Response.Write("<script>alert('Chưa Đăng Nhập');</script>");
                Server.Transfer("Default.aspx");
            }
            masach = Context.Items["masach"] != null ? Context.Items["masach"].ToString() : null;
            if (masach == null)
            {
                Response.Write("<script>alert('Chưa chọn sách');</script>");
                Server.Transfer("Default.aspx");
            }
            query = "select * from SACH where masach = '" + masach + "'";
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connectionString);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                this.DataList1.DataSource = dataTable;
                this.DataList1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
        protected void TaoGio()
        {
            dataTable = new DataTable();
            dataTable.Rows.Clear();
            dataTable.Columns.Add("tendn", typeof(string));
            dataTable.Columns.Add("masach", typeof(string));
            dataTable.Columns.Add("tensach", typeof(string));
            dataTable.Columns.Add("soluong", typeof(int));
            dataTable.Columns.Add("dongia", typeof(double));
            dataTable.Columns.Add("hinh", typeof(string));
            Session["GioHangDB"] = dataTable; 
        }

        protected void btnAddToCard_Click(object sender, EventArgs e)
        {
            Button add = (Button)sender;
            DataListItem item = (DataListItem)add.Parent;

            string hinh = "";
            string tendn = Request.Cookies["tendn"].Value.ToString();
            string tensach = ((Label)item.FindControl("Label2")).Text;
            string dongia = ((Label)item.FindControl("lblDonGia")).Text;
            string masach = add.CommandArgument.ToString();
            string soluong = ((DropDownList)item.FindControl("DropDownList1")).SelectedValue;
            bool confirm = false;

            Image image = (Image)item.FindControl("Image1");

            string getUrl = image.ImageUrl.ToString();
            string[] arrListStr = getUrl.Split('/');

            for (int i = 0; i < arrListStr.Length; i++)
            {
                hinh = arrListStr[arrListStr.Length - 1];
            }
            
            dataTable = (DataTable)Session["GioHangDB"];

            if (dataTable == null) TaoGio();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow["tendn"].Equals(tendn))
                {
                    if (dataRow["masach"].Equals(masach))
                    {
                        dataRow["soluong"] = Convert.ToInt32(soluong);
                        confirm = true;
                        break;
                    }
                }
            }
            if (!confirm)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["tendn"] = tendn;
                dataRow["masach"] = masach;
                dataRow["tensach"] = tensach;
                dataRow["soluong"] = soluong;
                dataRow["dongia"] = dongia;
                dataRow["hinh"] = hinh;
                dataTable.Rows.Add(dataRow);
            }
            Session["GioHangDB"] = dataTable;
        }

        protected void btnCardView_Click(object sender, EventArgs e)
        {
            if (Session["GioHangDB"] == null)
            {
                Response.Write("<script>alert('Giỏ Hàng hiện tại đang trống');</script>");
                return;
            }
            Server.Transfer("GioHang.aspx");
        }

        
    }
}