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
            string query = "INSERT INTO DonHang(ngayDat, maKH, maMonAn, maNVSale) VALUES (@ngayDat,@maKH,@maMonAn, @maNVSale)";
            sqlCommand= new SqlCommand(query,connect);
            sqlCommand.Parameters.AddWithValue("@ngayDat", donHang.ngayDat);
            sqlCommand.Parameters.AddWithValue("@maKH", donHang.maKH);
            sqlCommand.Parameters.AddWithValue("@maMonAn", donHang.maMonAn);
            sqlCommand.Parameters.AddWithValue("@maNVSale", donHang.maNVSale);
            int result = sqlCommand.ExecuteNonQuery();
            connect.Close();
            return result > 0;
        }
        public DataTable LayDanhSachDonHang()
        {
            string query = "SELECT * FROM DonHang";
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            DataTable dsDonHang = new DataTable();
            adapter.Fill(dsDonHang);
            connect.Close();
            return dsDonHang;
        }
    }
}
