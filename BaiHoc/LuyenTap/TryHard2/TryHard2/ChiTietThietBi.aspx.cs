using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TryHard2
{
    public partial class ChiTietThietBi : System.Web.UI.Page
    {
        KetNoi ketNoi = new KetNoi();
        String connection = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
        DataTable dtTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            String SQL;
            if (Context.Items["mtb"] == null)
            {
                SQL = "select * from THIETBI";
            }
            else
            {
                String maThietBi = Context.Items["mtb"].ToString();
                SQL = "select * from THIETBI where MaThietBi ='" + maThietBi + "'";
            }
            try
            {
                dtlChiTietThietBi.DataSource = ketNoi.bangDuLieu(SQL);
                dtlChiTietThietBi.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        public void taoGio()
        {
            dtTable = new DataTable();
            dtTable.Columns.Add("MaThietBi");
            dtTable.Columns.Add("TenThietBi");
            dtTable.Columns.Add("DonGia");
            dtTable.Columns.Add("SoLuong");
            Session["GioHang"] = dtTable;
        }

        protected void btnGioHang_Click(object sender, EventArgs e)
        {
            String tenDN = Request.Cookies["TenDN"] != null ? Request.Cookies["TenDN"].Value : "";
            if (tenDN == "")
            {
                Response.Write("<script> alert('Bạn chưa đăng nhập!'); </script>");
            }
            else
            {
                Response.Write("<script> alert('Mua hàng thành công!'); </script>");
            }

            Button gioHang = (Button)sender;
            String maThietBi = gioHang.CommandArgument;
            DataListItem item = (DataListItem)gioHang.Parent;
            String tenThietBi = ((Label)item.FindControl("lblTenThietBi")).Text;
            String donGia = ((Label)item.FindControl("lblDonGia")).Text;
            String soLuong = ((DropDownList)item.FindControl("ddlSoLuong")).Text;
            dtTable = (DataTable) Session["GioHang"];
            bool tim = false;
            if (dtTable == null) taoGio();
            foreach(DataRow dataRow in dtTable.Rows)
            {
                if (dataRow["MaThietBi"].Equals(maThietBi))
                {
                    dataRow["SoLuong"] = Convert.ToInt32(dataRow["SoLuong"]) + Convert.ToInt32(soLuong);
                    tim = true;
                    break;
                }
            }
            
            if (!tim)
            {
                DataRow dataRow = dtTable.NewRow();
                dataRow["MaThietBi"] = maThietBi;
                dataRow["TenThietBi"] = tenThietBi;
                dataRow["SoLuong"] = soLuong;
                dataRow["DonGia"] = donGia;
                dtTable.Rows.Add(dataRow);
            }
            Session["GioHang"] = dtTable;
            Server.Transfer("GioHang.aspx");
        }
    }
}