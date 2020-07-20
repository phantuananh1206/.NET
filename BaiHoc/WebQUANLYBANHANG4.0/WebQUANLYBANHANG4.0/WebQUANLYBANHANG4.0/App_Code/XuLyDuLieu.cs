using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data;
using System.Data.SqlClient;

namespace WebQUANLYBANHANG4._0.App_Code
{

    public class XuLyDuLieu
    {
        SqlConnection con;

        public XuLyDuLieu(String path) {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

        } 

        private void MoKetNoi()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void DongKetNoi()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    
        public DataTable BangDuLieu(String SQL) /*Thực thi select*/
        {
            DataTable tb = new DataTable();
                this.MoKetNoi();
            SqlDataAdapter adp = new SqlDataAdapter(SQL, con);
            adp.Fill(tb);
            this.DongKetNoi();
            return tb;
        }

        public DataSet DanhSachBang(String SQL)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(BangDuLieu(SQL));
            return ds;
        }

        public int ThucThiSQL(String SQL) /*Thực thi insert,delete,update*/
        {
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand(SQL,con);
            int k = cmd.ExecuteNonQuery();
            this.DongKetNoi();
            return k;
        }

        public Object layGiaTriDon(String SQL)
        {
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand(SQL, con);
            Object giaTri = cmd.ExecuteScalar();
            this.DongKetNoi();
            return giaTri;
        }

        public int thucThiThuTuc(String tenThuTuc,SqlParameter[] pr)
        {
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = tenThuTuc;
            if(pr != null)
                cmd.Parameters.AddRange(pr);
            
            int k = cmd.ExecuteNonQuery();
            this.DongKetNoi();
            return k;
        }

        public DataTable layBangThutuc(String tenThuTuc,SqlParameter[] pr)
        {
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = tenThuTuc;
            if (pr != null)
                cmd.Parameters.AddRange(pr);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
             adp.Fill(tb);
            this.DongKetNoi();
            return tb;
             

        }

        public void layDanhSachBang(ref DataSet ds,String SQL)
        {
            ds.Tables.Add(this.BangDuLieu(SQL));
        }


    }
}