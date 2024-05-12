using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_RestaurantManager;

namespace DAL_RestaurantManager
{
    public class DAL_DangKyBanDat:DBConnect
    {
        public List<DTO_DangKyBanDat> DanhSachDonBanDat()
        {
            List<DTO_DangKyBanDat> danhSachBanDat = new List<DTO_DangKyBanDat>();

            connect.Open();
            string query = "SELECT * FROM DangKyBanDat";
            sqlCommand = new SqlCommand(query, connect);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {

                danhSachBanDat.Add(new DTO_DangKyBanDat(
                    sqlDataReader.GetInt32(0),
                    sqlDataReader.GetInt32(1),
                    sqlDataReader.GetInt32(2),
                    sqlDataReader.GetString(3),
                    sqlDataReader.GetBoolean(4),
                    sqlDataReader.GetDateTime(5),
                    sqlDataReader.GetInt32(6)));

            }
            return danhSachBanDat;

        }
        public bool ThemDatBan(DTO_DangKyBanDat datBan)
        {
            connect.Open();
            string query = "INSERT INTO DangKyBanDat (soLuongNguoi, viTri, ghiChu, thoiGian, maKH) VALUES (@SoLuongNguoi, @ViTri, @GhiChu, @ThoiGian, @MaKH)";
            SqlCommand sqlCommand = new SqlCommand(query, connect);

            // Thêm các tham số
            sqlCommand.Parameters.AddWithValue("@SoLuongNguoi", datBan.soLuongNguoi);
            sqlCommand.Parameters.AddWithValue("@ViTri", datBan.viTri);
            sqlCommand.Parameters.AddWithValue("@GhiChu", datBan.ghiChu);
            sqlCommand.Parameters.AddWithValue("@ThoiGian", datBan.thoiGian);
            sqlCommand.Parameters.AddWithValue("@MaKH", datBan.maKH);
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
        public void XoaDangKyBanDat(int maDK)
        {
            //try
            //{
                connect.Open();
                string query = "DELETE FROM DangKyBanDat WHERE maDK = @MaDK";
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@MaDK", maDK);
                sqlCommand.ExecuteNonQuery();
                connect.Close();
            //}
            //catch (Exception ex)
            //{
                
            //}
            //finally
            //{
            //     connect.Close();
            //}
        }

    }
}
