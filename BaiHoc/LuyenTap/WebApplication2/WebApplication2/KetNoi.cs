using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2
{
    public class KetNoi
    {
        SqlConnection connectionString;
        public KetNoi()
        {
            connectionString = new SqlConnection();
            connectionString.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IS384_ASP\QuanLyBanHang\QuanLyBanHang\App_Data\dbQuanLyBanHang.mdf;Integrated Security=True";
        }

        public void moKetNoi()
        {
            if (connectionString.State == ConnectionState.Closed)
                connectionString.Open();
        }

        public void dongKetNoi()
        {
            if (connectionString.State == ConnectionState.Open)
                connectionString.Close();
        }

        public bool thucThiSQL(String SQL)
        {
            try
            {
                this.moKetNoi();
                SqlCommand cmd = new SqlCommand(SQL, connectionString);
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
            DataTable dt = new DataTable();
            try
            {
                this.moKetNoi();
                SqlDataAdapter adp = new SqlDataAdapter(SQL, connectionString);
                adp.Fill(dt);
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                this.dongKetNoi();
            }
            return dt;
        }
    }
}