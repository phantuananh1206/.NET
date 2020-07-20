using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TryHard
{
    public partial class ChiTiet : System.Web.UI.Page
    {
        KetNoi ketNoi = new KetNoi();
        DataTable dtTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            String SQL;
            if (Context.Items["ms"] == null)
                SQL = "select * from SACH";
            else
            {
                String maSach = Context.Items["ms"].ToString();
                SQL = "select * from SACH where MaSach ='" + maSach + "'";
            }
            try
            {
                DataList2.DataSource = ketNoi.bangDuLieu(SQL);
                DataList2.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        public void taoGio()
        {
            dtTable = new DataTable();
            dtTable.Columns.Add("MaSach");
            dtTable.Columns.Add("DonGia");
            dtTable.Columns.Add("SoLuong");
            Session["GioHang"] = dtTable;
        }

        protected void btnMua_Click(object sender, EventArgs e)
        {
            String tenDN;
            if (Request.Cookies["TenDN"] != null)
            {
                tenDN = Request.Cookies["TenDN"].Value;
            }else
            {
                tenDN = "";
            }
            if (tenDN == "")
            {
                Response.Write("<script> alert('Chưa đăng nhập!'); </script>");
            }else
            {
                Response.Write("<script> alert('Mua hàng thành công!'); </script>");
            }

            Button mua = (Button)sender;
            String maSach = mua.CommandArgument.ToString();
            DataListItem item = (DataListItem)mua.Parent;
            String donGia = ((Label)item.FindControl("Label1")).Text;
            String soLuong = ((DropDownList)item.FindControl("DropDownList1")).Text;
            dtTable = (DataTable)Session["GioHang"];
            bool tim = false;
            if (dtTable == null) taoGio();
            foreach(DataRow dataRow in dtTable.Rows)
            {
                if (dataRow["MaSach"].Equals(maSach))
                {
                    dataRow["SoLuong"] = Convert.ToInt32(dataRow["SoLuong"]) + Convert.ToInt32(soLuong);
                    tim = true;
                    break;
                }
            }

            if (!tim)
            {
                DataRow dtRow = dtTable.NewRow();
                dtRow["MaSach"] = maSach;
                dtRow["SoLuong"] = soLuong;
                dtRow["DonGia"] = donGia;
                dtTable.Rows.Add(dtRow);
            }
            Session["GioHang"] = dtTable;
        }

        protected void btnXemGioHang_Click(object sender, EventArgs e)
        {
            if (Session["GioHang"] == null)
            {
                Response.Write("<script> alert('Giỏ hàng còn trống!'); </script>");
                return;
            }
            Server.Transfer("GioHang.aspx");
        }
    }
}