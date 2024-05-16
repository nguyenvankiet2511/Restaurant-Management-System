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
        public bool ThemHoaDonDonHang(DTO_HoaDonDonHang hoaDon)
        {
            connect.Open();
            string query = "INSERT INTO HoaDonDonHang(tenMon, giaMon, soLuong, thanhTien, maDonHang) VALUES (@tenMon, @giaMon, @soLuong, @thanhTien, @maDonHang)";
            SqlCommand sqlCommand = new SqlCommand(query, connect);

            sqlCommand.Parameters.AddWithValue("@tenMon", hoaDon.tenMon);
            sqlCommand.Parameters.AddWithValue("@giaMon", hoaDon.giaMon);
            sqlCommand.Parameters.AddWithValue("@soLuong", hoaDon.soLuong);
            sqlCommand.Parameters.AddWithValue("@thanhTien", hoaDon.thanhTien);
            sqlCommand.Parameters.AddWithValue("@maDonHang", hoaDon.maDonHang);

            int result = sqlCommand.ExecuteNonQuery();
            connect.Close();
            return result > 0;
        }
    }
}
