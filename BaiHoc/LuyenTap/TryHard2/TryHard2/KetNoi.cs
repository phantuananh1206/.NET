using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TryHard2
{
    public class KetNoi
    {
        private SqlConnection connection;
        public KetNoi()
        {
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IS384_ASP\BaiHoc\LuyenTap\TryHard2\TryHard2\App_Data\dbTHIETBIMAYTINHCU.mdf;Integrated Security=True";
        }

        public void moKetNoi()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void dongKetNoi()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public bool thucThiSQL(String SQL)
        {
            try
            {
                this.moKetNoi();
                SqlCommand cmd = new SqlCommand(SQL, connection);
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
            DataTable dtTable = new DataTable();
            try
            {
                this.moKetNoi();
                SqlDataAdapter adp = new SqlDataAdapter(SQL, connection);
                adp.Fill(dtTable);
            }
            catch (SqlException ex)
            {
                dtTable = null;
            }
            finally
            {
                this.dongKetNoi();
            }
            return dtTable;
        }
    }
}