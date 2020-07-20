using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TryHard2
{
    public partial class DanhSachThietBi : System.Web.UI.Page
    {
        KetNoi ketNoi = new KetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            String SQL;
            if (Context.Items["mn"] == null)
            {
                SQL = "select * from THIETBI";
            }
            else
            {
                String maNhom = Context.Items["mn"].ToString();
                SQL = "select * from THIETBI where MaNhom ='" + maNhom + "'";
            }
            try
            {
                dtlDanhSachThietBi.DataSource = ketNoi.bangDuLieu(SQL);
                dtlDanhSachThietBi.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void lbtnChiTiet_Click(object sender, EventArgs e)
        {
            String maThietBi = ((LinkButton)sender).CommandArgument;
            Context.Items["mtb"] = maThietBi;
            Server.Transfer("ChiTietThietBi.aspx");
        }
    }
}