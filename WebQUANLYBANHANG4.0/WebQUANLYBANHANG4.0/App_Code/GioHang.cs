using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebQUANLYBANHANG4._0.App_Code
{
    public class GioHang
    {
        
        Dictionary<String, DataRow> cart;

        public GioHang()
        {
            cart = new Dictionary<string, DataRow>();

        }
        public void addItem (DataRow itemRow)
        {
            String key = itemRow["IDMASP"].ToString();
            if (cart.ContainsKey(key))
            {
                cart[key]["SOLUONG"] = Convert.ToInt32(cart[key]["SOLUONG"].ToString()) + Convert.ToInt32(itemRow["SOLUONG"].ToString());

            }else
            {
                cart.Add(key, itemRow);
            }
        }
        public void xoaSanPham(String key)
        {
            cart.Remove(key);
        }

        public double tinhTongTien()
        {
            double tongTien = 0;
            foreach(DataRow row in cart.Values)
            {
                tongTien += Convert.ToInt32(row["SOLUONG"].ToString()) * Convert.ToInt32(row["DONGIA"].ToString());
            }
            return tongTien;
        }
        public DataTable loadDanhSachSanPham()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("IDMASP", typeof(Int32));
            tb.Columns.Add("TENSP", typeof(String));
            tb.Columns.Add("SOLUONG", typeof(Int32));
            tb.Columns.Add("DONGIA", typeof(double));
            tb.Columns.Add("HINHANH", typeof(String));
            tb.Columns.Add("THANHTIEN", typeof(double));
            foreach(DataRow row in cart.Values)
            {
                DataRow rowItem = tb.NewRow();
                rowItem["IDMASP"] = row["IDMASP"];
                rowItem["TENSP"] = row["TENSP"];
                rowItem["SOLUONG"] = row["SOLUONG"];
                rowItem["DONGIA"] = row["DONGIA"];
                rowItem["HINHANH"] = row["HINHANH"];
                rowItem["THANHTIEN"] = Convert.ToInt32(row["SOLUONG"].ToString()) *
                    Convert.ToInt32(row["DONGIA"].ToString());
                tb.Rows.Add(rowItem);
            }
            return tb;
        }

    }
}