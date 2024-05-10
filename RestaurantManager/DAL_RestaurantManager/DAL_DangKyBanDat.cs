using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_RestaurantManager;

namespace DAL_RestaurantManager
{
    public class DAL_DangKyBanDat:DBConnect
    {
        public bool ThemDatBan(DTO_DangKyBanDat datBan)
        {
            connect.Open();
            string query = "INSERT INTO DangKyBanDat (soLuongNguoi, viTri, ghiChu, thoiGian) VALUES (@SoLuongNguoi, @ViTri, @GhiChu, @ThoiGian)";
            SqlCommand sqlCommand = new SqlCommand(query, connect);

            // Thêm các tham số
            sqlCommand.Parameters.AddWithValue("@SoLuongNguoi", datBan.soLuongNguoi);
            sqlCommand.Parameters.AddWithValue("@ViTri", datBan.viTri);
            sqlCommand.Parameters.AddWithValue("@GhiChu", datBan.ghiChu);
            sqlCommand.Parameters.AddWithValue("@ThoiGian", datBan.thoiGian);

            // Thực thi câu lệnh SQL
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                connect.Close(); // Đóng kết nối sau khi thực hiện thành công
                return true;
            }
            else
            {
                connect.Close(); // Đóng kết nối trong trường hợp không thành công
                return false;
            }
        }
    }
}
