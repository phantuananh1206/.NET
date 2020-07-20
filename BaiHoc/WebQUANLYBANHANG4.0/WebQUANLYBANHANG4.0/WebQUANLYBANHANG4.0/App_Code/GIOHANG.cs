using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace WebQUANLYBANHANG4._0.App_Code
{
    public class GIOHANG
    {
        Dictionary<String, DataRow> CART;

        public GIOHANG()
        {
            CART = new Dictionary<string, DataRow>();
        }
        
        public void deleteItem(String Key)
        {
            CART.Remove(Key);
        }


        public double tinhTongTien()
        {
            double tongTien = 0;
            foreach(DataRow row in CART.Values)
            {
                tongTien += Convert.ToUInt32(row["SOLUONG"].ToString()) * Convert.ToUInt32(row["DONGIA"].ToString());
            }
            return tongTien;
        }


        public DataTable DANHSACHGIOHANG()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("IDMASP", typeof(Int16));
            tb.Columns.Add("TENSP", typeof(String));
            tb.Columns.Add("SOLUONG", typeof(Int16));
            tb.Columns.Add("DONGIA", typeof(double));
            tb.Columns.Add("HINHANH", typeof(String));
            tb.Columns.Add("THANHTIEN", typeof(double));
           foreach(DataRow row in CART.Values)
            {
                tb.Rows.Add(row.ItemArray);
            }
            return tb;
        }


        public Boolean addItem(DataRow item, Int16 soluongton)
        {
            bool tran = false;
            String Key = item["IDMASP"].ToString();
            if (CART.ContainsKey(Key)) /*Nếu đã tồn tại trong giỏ hàng rồi thì cho vào*/
            {
                Int32 SoLuongMua = Convert.ToInt32(CART[Key]["SOLUONG"].ToString()) + Convert.ToInt32(item["SOLUONG"].ToString());

                if (SoLuongMua <= soluongton)
                {
                    CART[Key]["SOLUONG"] = SoLuongMua; //cap nhat so luong vao gio hang
                    tran = true;
                }
            }
            else
            {
                CART.Add(Key, item);
                tran = true;
            }
            return tran;

        }

    }



}