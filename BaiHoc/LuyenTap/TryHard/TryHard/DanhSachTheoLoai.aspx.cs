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
    public partial class DanhSachTheoLoai : System.Web.UI.Page
    {
        KetNoi ketNoi = new KetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            String SQL;
            if (Context.Items["ml"] == null)
                SQL = "select * from SACH";
            else
            {
                String maLoai = Context.Items["ml"].ToString();
                SQL = "select * from SACH where MaLoai ='" + maLoai + "'";
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

        protected void lbtnChiTiet_Click(object sender, EventArgs e)
        {
            String maSach = ((LinkButton)sender).CommandArgument;
            Context.Items["ms"] = maSach;
            Server.Transfer("ChiTiet.aspx");
        }
    }
}