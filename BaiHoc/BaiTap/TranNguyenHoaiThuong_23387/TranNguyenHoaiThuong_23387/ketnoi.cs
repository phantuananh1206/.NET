using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace TranNguyenHoaiThuong_23387
{
    public class ketnoi
    {
        SqlConnection con;
        private void layknoi()
        {
            con  =  new  SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\TranNguyenHoaiThuong_23387\TranNguyenHoaiThuong_23387\App_Data\QuanLyBanSach.mdf;Integrated Security=True");
            con.Open();
        }

        private void dongketnoi()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        public int capnhat(string sql)
        {
            int kq = 0;
            try
            {
                layknoi();
                SqlCommand cmd = new SqlCommand(sql, con);
                kq = cmd.ExecuteNonQuery();
            }
            catch
            {
                kq = 0;
            }
            finally
            {
                dongketnoi();
            }
            return kq;
        }

        public DataTable laydata(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                layknoi();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch
            {
                dt = null;
            }
            finally
            {
                dongketnoi();
            }
            return dt;
        }
    }
}