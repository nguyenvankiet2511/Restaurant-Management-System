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
    public class DAL_NguoiDung:DBConnect
    {
        public DAL_NguoiDung() { }
        public DTO_NguoiDung LayThongTinNguoiDung(int maNguoiDung)
        {
            string query = "SELECT * FROM NguoiDung WHERE idNguoiDung = @MaNguoiDung ";
            DTO_NguoiDung nguoiDung = new DTO_NguoiDung();
            connect.Open();
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung );
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                nguoiDung = new DTO_NguoiDung(sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(5));
            }
            connect.Close();
            return nguoiDung;
        }
        public int ThemNguoiDung(DTO_NguoiDung nguoiDung)
        {
            int maKH = -1; 
            connect.Open();
            string queryNguoiDung = "INSERT INTO NguoiDung (ten_nguoi_dung, email, soDienThoai) VALUES (@Ten, @Email, @SoDienThoai); SELECT @@IDENTITY;";
            sqlCommand = new SqlCommand(queryNguoiDung, connect);
            sqlCommand.Parameters.AddWithValue("@Ten", nguoiDung.tenNguoiDung);
            sqlCommand.Parameters.AddWithValue("@Email", nguoiDung.email);
            sqlCommand.Parameters.AddWithValue("@SoDienThoai", nguoiDung.soDienThoai);
            object result = sqlCommand.ExecuteScalar();
            if (result != DBNull.Value)
            {
                maKH = Convert.ToInt32(result); 
            }
            connect.Close(); 
            return maKH;
        }
        public int ThemNguoiDungMoi(DTO_NguoiDung nguoiDung)
        {
            connect.Open();
            int maKH = -1;
            string query = @"INSERT INTO NguoiDung (ten_nguoi_dung, email, diaChi, namSinh, soDienThoai) 
                         VALUES (@ten_nguoi_dung, @email, @diaChi, @namSinh, @soDienThoai); SELECT @@IDENTITY;";
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@ten_nguoi_dung", nguoiDung.tenNguoiDung);
            sqlCommand.Parameters.AddWithValue("@email", nguoiDung.email);
            sqlCommand.Parameters.AddWithValue("@diaChi", nguoiDung.diaChi);
            sqlCommand.Parameters.AddWithValue("@namSinh", nguoiDung.namSinh);
            sqlCommand.Parameters.AddWithValue("@soDienThoai", nguoiDung.soDienThoai);        
            object result = sqlCommand.ExecuteScalar();
            if (result != DBNull.Value)
            {
                maKH = Convert.ToInt32(result);
            }
            connect.Close();
            return maKH;      
        }
        public bool CapNhapThongTinNguoiDung(DTO_NguoiDung nguoiDungMoi)
        {
            try
            {
                string query = "UPDATE NguoiDung SET ten_nguoi_dung = @Ten, email = @Email, soDienThoai = @SoDienThoai WHERE idNguoiDung = @MaNguoiDung";

                connect.Open();
                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@Ten", nguoiDungMoi.tenNguoiDung);
                sqlCommand.Parameters.AddWithValue("@Email", nguoiDungMoi.email);
                sqlCommand.Parameters.AddWithValue("@SoDienThoai", nguoiDungMoi.soDienThoai);
                sqlCommand.Parameters.AddWithValue("@MaNguoiDung", nguoiDungMoi.idNguoiDung);
                if (sqlCommand.ExecuteNonQuery() > 0) { return true; }         
            }
            catch (Exception ex)
            {            
            }
            finally
            {
                connect.Close();
            }
            return false;
        }
        public DataTable LayDanhSachNhanVien()
        {
            string query = @"
                            SELECT 
                                ND.idNguoiDung,
                                ND.ten_nguoi_dung,
                                ND.email,
                                ND.namSinh,
                                ND.soDienThoai,
                                ND.diaChi,
                                CASE 
                                    WHEN NVTT.maNVTT IS NOT NULL THEN NVTT.bangCap
                                    WHEN NVTN.maNVTN IS NOT NULL THEN NVTN.bangCap
                                    WHEN NVSale.maNVSale IS NOT NULL THEN NVSale.bangCap
                                    WHEN QTV.maQTV IS NOT NULL THEN N'Quản trị viên'
                                END AS bangCap,
                                CASE 
                                    WHEN NVTT.maNVTT IS NOT NULL THEN NVTT.chucVu
                                    WHEN NVTN.maNVTN IS NOT NULL THEN NVTN.chucVu
                                    WHEN NVSale.maNVSale IS NOT NULL THEN NVSale.chucVu
                                    WHEN QTV.maQTV IS NOT NULL THEN QTV.chucVu
                                END AS chucVu
                            FROM 
                                NguoiDung ND
                            LEFT JOIN 
                                NhanVienTiepTan NVTT ON ND.idNguoiDung = NVTT.maNVTT
                            LEFT JOIN 
                                NhanVienThuNgan NVTN ON ND.idNguoiDung = NVTN.maNVTN
                            LEFT JOIN 
                                NhanVienSale NVSale ON ND.idNguoiDung = NVSale.maNVSale
                            LEFT JOIN 
                                QuanTriVien QTV ON ND.idNguoiDung = QTV.maQTV
                            WHERE 
                                NVTT.maNVTT IS NOT NULL 
                                OR NVTN.maNVTN IS NOT NULL 
                                OR NVSale.maNVSale IS NOT NULL 
                                OR QTV.maQTV IS NOT NULL;";
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query,connect);
            DataTable nhanVien = new DataTable();
            adapter.Fill(nhanVien);
            connect.Close();
            return nhanVien;
        }
        public bool CapNhatThongTinNhanVien(DTO_NguoiDung nguoiDung)
        {
            try
            {
                connect.Open();
                string query = @"UPDATE NguoiDung 
                         SET ten_nguoi_dung = @tenNguoiDung, 
                             email = @email, 
                             namSinh = @namSinh, 
                             soDienThoai = @soDienThoai, 
                             diaChi = @diaChi 
                         WHERE idNguoiDung = @idNguoiDung";
                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@tenNguoiDung", nguoiDung.tenNguoiDung);
                sqlCommand.Parameters.AddWithValue("@email", nguoiDung.email);
                sqlCommand.Parameters.AddWithValue("@namSinh", nguoiDung.namSinh);
                sqlCommand.Parameters.AddWithValue("@soDienThoai", nguoiDung.soDienThoai);
                sqlCommand.Parameters.AddWithValue("@diaChi", nguoiDung.diaChi);
                sqlCommand.Parameters.AddWithValue("@idNguoiDung", nguoiDung.idNguoiDung);
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
        public bool XoaNguoiDung(int maNguoiDung)
        {
            try
            {
                string query = @"DELETE FROM NguoiDung 
                         WHERE idNguoiDung = @maNguoiDung";

                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@maNguoiDung", maNguoiDung);
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

    }
}
