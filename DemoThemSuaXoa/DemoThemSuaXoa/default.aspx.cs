using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoThemSuaXoa
{
    public partial class _default : System.Web.UI.Page
    {
        XuLyDuLieu xuLyDuLieu = new XuLyDuLieu();
        protected void Page_Load(object sender, EventArgs e)
        {
            String SQL = " select * from LOAIHANG";
            if (IsPostBack == false)
            {
                grvLoaiHang.DataSource = xuLyDuLieu.bangDuLieu(SQL);
                grvLoaiHang.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
            TextBox txtMaloai = (TextBox)grvLoaiHang.FooterRow.FindControl("txtMaloai");
            TextBox txtTenloai = (TextBox)grvLoaiHang.FooterRow.FindControl("txtTenloai");
            String SQL = "insert into LoaiHang values ('" + txtMaloai.Text + "', '"
                + txtTenloai.Text + "')";
            String maloai = txtMaloai.Text;
            String tenloai = txtTenloai.Text;
            if (xuLyDuLieu.thucThiSQL(SQL))
            {
                Response.Write("<script>alert('Thêm dữ liệu thành công!');</script>");
                grvLoaiHang.DataSource = xuLyDuLieu.bangDuLieu(" select * from LoaiHang");
                grvLoaiHang.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Thất bại của tạo hóa!');</script>");
            }
        }

        protected void grvLoaiHang_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
            String maLoai = e.Values["MaLoai"].ToString();
            String SQL = "delete from LoaiHang where MaLoai = " + maLoai;
            if (xuLyDuLieu.thucThiSQL(SQL))
            {
                Response.Write("<script>alert('Xóa thành công!');</script>");
                grvLoaiHang.DataSource = xuLyDuLieu.bangDuLieu("select * from LoaiHang");
                grvLoaiHang.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Xóa thất bại!');</script>");
            }
        }

        protected void grvLoaiHang_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvLoaiHang.EditIndex = e.NewEditIndex;
            grvLoaiHang.DataSource = xuLyDuLieu.bangDuLieu("select * from LoaiHang");
            grvLoaiHang.DataBind();
        }

        protected void grvLoaiHang_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String maLoai = e.NewValues["MaLoai"].ToString();
            String tenLoai = e.NewValues["TenLoai"].ToString();
            String SQL = " update LoaiHang set TenLoai = '" + tenLoai +
                "' where MaLoai = '" + maLoai + "'";
            if (xuLyDuLieu.thucThiSQL(SQL)) 
            {
                Response.Write("<script>alert('Cập nhật thành công!');</script>");
                grvLoaiHang.DataSource = xuLyDuLieu.bangDuLieu("select * from LoaiHang");
                grvLoaiHang.EditIndex = -1;
                grvLoaiHang.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Cập nhật thất bại!');</script>");
            }
        }

        protected void grvLoaiHang_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grvLoaiHang.EditIndex = -1;
            grvLoaiHang.DataSource = xuLyDuLieu.bangDuLieu("select * from LoaiHang");
            grvLoaiHang.DataBind();
        }

    }
}