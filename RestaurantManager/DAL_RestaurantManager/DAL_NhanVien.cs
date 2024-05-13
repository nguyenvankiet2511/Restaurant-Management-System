using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_RestaurantManager
{
    public class DAL_NhanVien:DBConnect
    {
        public DAL_NhanVien() { }
        public bool CapNhatNhanVienTiepTan(DTO_NhanVienTiepTan nhanVienTT)
        {
            try
            {
                connect.Open();
                string query = @"UPDATE NhanVienTiepTan
                         SET 
                             bangCap = @bangCap
                         WHERE 
                             maNVTT = @maNVTT";

                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@bangCap", nhanVienTT.bangCap);
                command.Parameters.AddWithValue("@maNVTT", nhanVienTT.maNVTT);
                int rowsAffected = command.ExecuteNonQuery();
                connect.Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool CapNhatNhanVienSale(DTO_NhanVienSale nhanVienSale)
        {
            try
            {
                connect.Open();
                string query = @"UPDATE NhanVienSale
                         SET 
                             bangCap = @bangCap
                         WHERE 
                             maNVSale = @maNVSale";

                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@bangCap", nhanVienSale.bangCap);
                command.Parameters.AddWithValue("@maNVSale", nhanVienSale.maNVSale);
                int rowsAffected = command.ExecuteNonQuery();
                connect.Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool CapNhatNhanVienThuNgan(DTO_NhanVienThuNgan nhanVienThuNgan)
        {
            try
            {
                connect.Open();
                string query = @"UPDATE NhanVienThuNgan
                         SET 
                             bangCap = @bangCap
                         WHERE 
                             maNVTN = @maNVTN";

                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@bangCap", nhanVienThuNgan.bangCap);
                sqlCommand.Parameters.AddWithValue("@maNVTN", nhanVienThuNgan.maNVTN);          
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                connect.Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool ThemNhanVienTiepTan(DTO_NhanVienTiepTan nhanVienTiepTan)
        {
            try
            {
                string query = @"INSERT INTO NhanVienTiepTan (maNVTT, bangCap,chucVu) 
                         VALUES (@maNVTT, @bangCap,@chucVu)";

                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@maNVTT", nhanVienTiepTan.maNVTT);
                sqlCommand.Parameters.AddWithValue("@bangCap", nhanVienTiepTan.bangCap);
                sqlCommand.Parameters.AddWithValue("@chucVu", nhanVienTiepTan.chucVu);
                connect.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                connect.Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        public bool ThemNhanVienSale(DTO_NhanVienSale nhanVienSale)
        {
            try
            {
                string query = @"INSERT INTO NhanVienSale (maNVSale, bangCap,chucVu) 
                         VALUES (@maNVSale, @bangCap,@chucVu)";

                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@maNVSale", nhanVienSale.maNVSale);
                sqlCommand.Parameters.AddWithValue("@bangCap", nhanVienSale.bangCap);
                sqlCommand.Parameters.AddWithValue("@chucVu", nhanVienSale.chucVu);

                connect.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                connect.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần thiết
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        public bool ThemNhanVienThuNgan(DTO_NhanVienThuNgan nhanVienThuNgan)
        {
            try
            {
                string query = @"INSERT INTO NhanVienThuNgan (maNVTN, bangCap, chucVu) 
                         VALUES (@maNVTN, @bangCap,@chucVu)";
                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@maNVTN", nhanVienThuNgan.maNVTN);
                sqlCommand.Parameters.AddWithValue("@bangCap", nhanVienThuNgan.bangCap);
                sqlCommand.Parameters.AddWithValue("@chucVu", nhanVienThuNgan.chucVu);
                connect.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                connect.Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool XoaNhanVienTiepTan(int maNhanVien)
        {
            try
            {
                string query = @"DELETE FROM NhanVienTiepTan 
                         WHERE maNVTT = @maNhanVien";

                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@maNhanVien", maNhanVien);

                connect.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connect.Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {               
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        public bool XoaNhanVienSale(int maNhanVien)
        {
            try
            {
                string query = @"DELETE FROM NhanVienSale 
                         WHERE maNVSale = @maNhanVien";

                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@maNhanVien", maNhanVien);

                connect.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connect.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {  
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        public bool XoaNhanVienThuNgan(int maNhanVien)
        {
            try
            {
                string query = @"DELETE FROM NhanVienThuNgan 
                         WHERE maNVTN = @maNhanVien";

                SqlCommand command = new SqlCommand(query, connect);
                command.Parameters.AddWithValue("@maNhanVien", maNhanVien);

                connect.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connect.Close();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {    
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }


    }
}
