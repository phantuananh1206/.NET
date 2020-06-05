using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace DemoHitCounter
{
    public class DBClass
    {
        public static int TruyVan_XuLy(String sql)
        {
            //String connectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IS384_ASP\DemoHitCounter\DemoHitCounter\App_Data\dbhitcounter.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Connection.Open();
            int soDong = command.ExecuteNonQuery();
            command.Connection.Close();

            return soDong;
        }

        public static DataTable TruyVan_TraVeTable(String sql)
        {
            //String connectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IS384_ASP\DemoHitCounter\DemoHitCounter\App_Data\dbhitcounter.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}