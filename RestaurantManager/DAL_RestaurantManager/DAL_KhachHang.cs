using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_RestaurantManager
{
    public class DAL_KhachHang:DBConnect
    {
        public DAL_KhachHang() { }
        public bool ThemKhachHang(int maNguoiDung)
        {
            connect.Open();
            string query = "INSERT INTO KhachHang (maKH) VALUES (@MaKH)";
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@MaKH", maNguoiDung);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable LayThongTinKhachHangDatBanTrongHomNay()
        {
            DataTable thongTinKH = new DataTable();
            string query = @"
                    SELECT 
                        nd.ten_nguoi_dung,  
                        nd.diaChi, 
                        nd.soDienThoai, 
                        bd.maBanDat, 
                        bd.soLuongNguoi, 
                        bd.viTri, 
                        bd.thoiGian
                    FROM 
                        BanDat bd
                    INNER JOIN 
                        KhachHang kh ON bd.maKH = kh.maKH
                    INNER JOIN 
                        NguoiDung nd ON kh.maKH = nd.idNguoiDung
                    WHERE 
                        CAST(bd.thoiGian AS DATE) = CAST(GETDATE() AS DATE)";
            try
            {
                connect.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
                dataAdapter.Fill(thongTinKH);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connect.Close();
            }

            return thongTinKH;
        }

    }
}
