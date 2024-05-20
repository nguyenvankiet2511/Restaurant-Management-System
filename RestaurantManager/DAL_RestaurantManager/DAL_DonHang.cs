using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace DAL_RestaurantManager
{
    public class DAL_DonHang:DBConnect
    {
        public DAL_DonHang() { }
        public bool ThemDonHang(DTO_DonHang donHang)
        {
            connect.Open();
            string query = "INSERT INTO DonHang(ngayDat,soLuong, maKH, maMonAn, maNVSale) VALUES (@ngayDat,@soLuong,@maKH,@maMonAn, @maNVSale)";
            sqlCommand= new SqlCommand(query,connect);
            sqlCommand.Parameters.AddWithValue("@ngayDat", donHang.ngayDat);
            sqlCommand.Parameters.AddWithValue("@soLuong", donHang.soLuong);
            sqlCommand.Parameters.AddWithValue("@maKH", donHang.maKH);
            sqlCommand.Parameters.AddWithValue("@maMonAn", donHang.maMonAn);
            sqlCommand.Parameters.AddWithValue("@maNVSale", donHang.maNVSale);
            int result = sqlCommand.ExecuteNonQuery();
            connect.Close();
            return result > 0;
        }
        public DataTable LayDanhSachDonHang()
        {
            string query = "SELECT * FROM DonHang WHERE trangThai = 1";
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            DataTable dsDonHang = new DataTable();
            adapter.Fill(dsDonHang);
            connect.Close();
            return dsDonHang;
        }
        public bool XoaDonHang(int maDonHang)
        {
            connect.Open();
            string query = "DELETE FROM DonHang WHERE maDonHang = @maDonHang";
            SqlCommand sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@maDonHang", maDonHang);
            int result = sqlCommand.ExecuteNonQuery();
            connect.Close();
            return result > 0;
        }
        public bool CapNhatDonHang(DTO_DonHang donHang)
        {
            connect.Open();
            string query = "UPDATE DonHang SET ngayDat = @ngayDat, ngayXacNhan= @ngayXacNhan, soLuong = @soLuong, maKH = @maKH, maMonAn = @maMonAn WHERE maDonHang = @maDonHang";
            SqlCommand sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@ngayDat", donHang.ngayDat);
            sqlCommand.Parameters.AddWithValue("@ngayXacNhan", donHang.ngayXacNhan);
            sqlCommand.Parameters.AddWithValue("@soLuong", donHang.soLuong);
            sqlCommand.Parameters.AddWithValue("@maKH", donHang.maKH);
            sqlCommand.Parameters.AddWithValue("@maMonAn", donHang.maMonAn);
            sqlCommand.Parameters.AddWithValue("@maDonHang", donHang.maDonHang);
            int result = sqlCommand.ExecuteNonQuery();
            connect.Close();
            return result > 0;
        }
        public bool DoiTrangThaiDonHang(int maDonHang)
        {
            string query = "UPDATE DonHang SET trangThai = @trangThaiMoi WHERE maDonHang = @maDonHang";
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@trangThaiMoi", false);
            sqlCommand.Parameters.AddWithValue("@maDonHang", maDonHang);

            connect.Open();
            int rowsAffected = sqlCommand.ExecuteNonQuery();
            connect.Close();

            return rowsAffected > 0;

        }
    }
}
