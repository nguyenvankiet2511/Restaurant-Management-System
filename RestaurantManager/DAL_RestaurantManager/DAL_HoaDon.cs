using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_RestaurantManager
{
    public class DAL_HoaDon:DBConnect
    {
      public  DAL_HoaDon() { }
        public bool ThemHoaDon(DTO_HoaDon hoaDon)
        {
            connect.Open();
            string query = "INSERT INTO HoaDon(thanhTien, maNVTN,maBanDat) VALUES (@thanhTien, @maNVTN,@maBanDat)";
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@thanhTien", hoaDon.thanhTien);
            sqlCommand.Parameters.AddWithValue("@maNVTN", hoaDon.maNVTN);
            sqlCommand.Parameters.AddWithValue("@maBanDat", hoaDon.maBanDat);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable LayDanhSachHoaDon()
        {
            string query = @"SELECT * FROM HoaDon";
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            DataTable danhSachHoaDon = new DataTable();
            adapter.Fill(danhSachHoaDon);
            connect.Close();
            return danhSachHoaDon;
        }
    }
}
