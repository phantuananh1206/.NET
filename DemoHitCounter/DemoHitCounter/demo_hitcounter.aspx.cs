using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace DemoHitCounter
{
    public partial class demo_hitcounter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string page_name = Request.ServerVariables["SCRIPT_NAME"].ToString();
                if (Request.Cookies["visited"] == null)
                {
                    HttpCookie ck = new HttpCookie("visited");
                    ck.Expires = DateTime.Now.AddMinutes(1);
                    Response.Cookies.Add(ck);

                    string sql = "update hitcounter set counter = counter + 1 ";
                    sql += " where page_name = '" + page_name + "'";
                    int sodong = DBClass.TruyVan_XuLy(sql);
                }

                string sq12 = "Select * from hitcounter where page_name = '" + page_name + "'";
                DataTable kq = DBClass.TruyVan_TraVeTable(sq12);
                Label1.Text = kq.Rows[0]["counter"].ToString(); 
            }
        }
    }
}