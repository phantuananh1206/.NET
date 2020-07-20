using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;              
using System.Data.SqlClient;  
using WebQUANLYBANHANG4._0.App_Code;

namespace WebQUANLYBANHANG4._0.QUANTRIWEB
{
    public partial class pageQUANLYDANHMUC : System.Web.UI.Page
    {
        XuLyDuLieu xulydulieu;
        String SQL;



        protected void Page_Load(object sender, EventArgs e)
        {
            String path = Server.MapPath("\\App_Data\\dbQUANLYBANHANG.mdf");
            xulydulieu = new XuLyDuLieu(path);
            DanhMucCha();
            GridViewDanhMuc();
        }

        public void DanhMucCha()
        {
            SQL = "select * from tbDANHMUC";
            this.drlDANHMUCCHA.DataSource = xulydulieu.BangDuLieu(SQL);
            this.drlDANHMUCCHA.DataTextField = "TENDM";
            this.drlDANHMUCCHA.DataValueField = "IDMADM";     
            this.drlDANHMUCCHA.DataBind();
        }

        public void GridViewDanhMuc()
        {
            SQL = "select * from tbDANHMUC";
            this.GridView1.DataSource = xulydulieu.BangDuLieu(SQL);
            this.GridView1.DataBind();
        }

      

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            GridViewDanhMuc();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.GridView1.EditIndex = e.NewEditIndex;
            GridViewDanhMuc();
            SQL = "select * from tbDANHMUC";
            DropDownList drl = (DropDownList)GridView1.Rows[e.NewEditIndex].FindControl("drlDANHMUCCHA");
            drl.DataSource = xulydulieu.BangDuLieu(SQL);
            drl.DataTextField = "TENDM";
            drl.DataValueField = "IDMADM";
            drl.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lbelIDMADM = (Label)GridView1.Rows[e.RowIndex].FindControl("lbelIDMADM");
            TextBox txtTENDM = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtTENDM");
            DropDownList drl = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("drlDANHMUCCHA");
            String 
                SQL = "UPDATE tbDANHMUC SET "
                + "TENDM =" + txtTENDM + ","
                + "IDPARENT =" + drl.SelectedValue
                + " WHERE IDMADM = " + GridView1.Rows[e.RowIndex].Cells[0].Text;
            GridView1.EditIndex = -1;
            xulydulieu.ThucThiSQL(SQL);
            GridViewDanhMuc();
        }
    }
}