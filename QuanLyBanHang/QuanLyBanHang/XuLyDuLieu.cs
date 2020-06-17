using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanHang
{
    public class XuLyDuLieu
    {
        private SqlConnection con;

        public XuLyDuLieu()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IS384_ASP\QuanLyBanHang\QuanLyBanHang\App_Data\dbQuanLyBanHang.mdf;Integrated Security=True";
        }
        private void moKetNoi()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        private void dongKetNoi()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        public bool thucThiSQL(String SQL)
        {
            try
            {
                this.moKetNoi();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.con;
                cmd.CommandText = SQL;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                this.dongKetNoi();
            }
            return false;
        }

        public DataTable bangDuLieu(String SQL)
        {
            DataTable tb = new DataTable();
            this.moKetNoi();
            SqlDataAdapter adp = new SqlDataAdapter(SQL, this.con);
            adp.Fill(tb);
            this.dongKetNoi();
            return tb;
        }
    }
}