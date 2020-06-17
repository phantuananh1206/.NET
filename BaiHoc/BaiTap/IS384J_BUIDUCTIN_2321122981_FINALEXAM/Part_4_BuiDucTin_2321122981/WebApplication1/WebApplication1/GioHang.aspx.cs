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
    public partial class GioHang1 : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            string tendn = Request.Cookies["tendn"] != null ? Request.Cookies["tendn"].Value : "";
            if(tendn == "")
            {
                Server.TransferRequest("Default.aspx");  
            }
            if (Page.IsPostBack) return;
            try
            {
                DataTable dataTable = (DataTable)Session["GioHangDB"];
                GridView1.DataSource = dataTable;
                GridView1.DataBind();

                double tong = 0;
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    double thanhtien = Convert.ToDouble(dataTable.Rows[i]["soluong"]) * Convert.ToDouble(dataTable.Rows[i]["dongia"]);
                    tong = tong + thanhtien;
                }
                this.Label1.Text = "Tổng cộng: " + tong;
            }catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)Session["GioHangDB"];
            try
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    for (int i = GridView1.Rows.Count - 1; i >= 0; i--)
                    {
                        GridViewRow row = GridView1.Rows[i];

                        bool isChecked = ((CheckBox)row.FindControl("CheckBox1")).Checked;
                        if (((CheckBox)row.FindControl("CheckBox1")).Checked)
                        {
                            dataTable.Rows[i].Delete();
                        }
                    }
                    Response.Redirect(Request.RawUrl);
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnThanhToan_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DataTable dataTable = (DataTable)Session["GioHangDB"];
            try
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    string query = "insert into DONHANG values('" + dataRow["tendn"] + "','" + dataRow["masach"] + "','" + dataRow["soluong"] + "')";
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();
                Server.Transfer("Default.aspx");
            }catch
            {
                
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string masach = ((LinkButton)sender).CommandArgument;
            Context.Items["masach"] = masach;
            Server.Transfer("ChiTietSach.aspx");
        }
    }
}