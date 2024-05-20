using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL_RestaurantManager
{
    public class DAL_BanDat:DBConnect
    {
        public DAL_BanDat() { }
        public DTO_BanDat LayThongTinBan(int maban)
        {
            DTO_BanDat banDat = new DTO_BanDat();
            connect.Open();
            string query = "SELECT * FROM BanDat WHERE viTri= @MaBan";
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@MaBan", maban);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                banDat= new DTO_BanDat(sqlDataReader.GetInt32(0), sqlDataReader.GetInt32(1),sqlDataReader.GetInt32(2),sqlDataReader.GetDateTime(5), sqlDataReader.GetInt32(6),sqlDataReader.GetInt32(7));
            }
            connect.Close();
            return banDat;
        }
        public bool CapNhatThongTinBan(DTO_BanDat banDat)
        {
            try
            {
                connect.Open();
                string query = "UPDATE BanDat SET soLuongNguoi = @SoLuongNguoi, viTri = @ViTri, thoiGian = @ThoiGian WHERE maBanDat = @MaBanDat";
                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@SoLuongNguoi", banDat.soLuongNguoi);
                sqlCommand.Parameters.AddWithValue("@ViTri", banDat.viTri);
                sqlCommand.Parameters.AddWithValue("@ThoiGian", banDat.thoiGian);
                sqlCommand.Parameters.AddWithValue("@MaBanDat", banDat.maBanDat);
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return false;
        }
        public bool XoaBanDat(int maBanDat)
        {
            try
            {
                connect.Open();
                string query = "DELETE FROM BanDat WHERE maBanDat = @MaBanDat";
                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@MaBanDat", maBanDat);
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
            }
            return false;
        }
        public bool ThemBanDat(DTO_BanDat banDat)
        {
            try
            {
                connect.Open();
                string query = "INSERT INTO BanDat (soLuongNguoi, viTri, ghiChu, thoiGian, maKH, maNVTT) VALUES (@SoLuongNguoi, @ViTri, @GhiChu, @ThoiGian, @MaKH, @MaNV)";
                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@SoLuongNguoi", banDat.soLuongNguoi);
                sqlCommand.Parameters.AddWithValue("@ViTri", banDat.viTri);
                sqlCommand.Parameters.AddWithValue("@GhiChu", banDat.ghiChu);
                sqlCommand.Parameters.AddWithValue("@ThoiGian", banDat.thoiGian);
                sqlCommand.Parameters.AddWithValue("@MaKH", banDat.maKH);
                sqlCommand.Parameters.AddWithValue("@MaNV", banDat.maNV);
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    connect.Close();
                    return true;
                }
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
        public bool ThemBanDat_KHMoi(DTO_BanDat banDat,int maNguoiDungMoi)
        {
            connect.Open();
            // Thêm thông tin bàn đặt với mã người dùng mới vào bảng BanDat
            string queryBanDat = "INSERT INTO BanDat (soLuongNguoi, viTri, thoiGian, maKH, maNVTT) VALUES (@SoLuongNguoi, @ViTri, @ThoiGian, @MaKH, @MaNV)";
            SqlCommand sqlCommandBanDat = new SqlCommand(queryBanDat, connect);
            sqlCommandBanDat.Parameters.AddWithValue("@SoLuongNguoi", banDat.soLuongNguoi);
            sqlCommandBanDat.Parameters.AddWithValue("@ViTri", banDat.viTri);
            sqlCommandBanDat.Parameters.AddWithValue("@ThoiGian", banDat.thoiGian);
            sqlCommandBanDat.Parameters.AddWithValue("@MaKH", maNguoiDungMoi);
            sqlCommandBanDat.Parameters.AddWithValue("@MaNV", banDat.maNV);
            if (sqlCommandBanDat.ExecuteNonQuery() > 0)
            {
                connect.Close();
                return true;
            }             
            return false;       
        }
        public List<DTO_BanDat> LayDanhSachBanDatKH(int maKH)
        {
            List<DTO_BanDat> danhSachBanDat = new List<DTO_BanDat>();

            try
            {
                connect.Open();

                string query = "SELECT * FROM BanDat WHERE maKH = @MaKH";
                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@MaKH", maKH);

                sqlDataReader= sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    DTO_BanDat banDat = new DTO_BanDat(
                        sqlDataReader.GetInt32(0), // MaBanDat
                        sqlDataReader.GetInt32(1), // SoLuongNguoi
                        sqlDataReader.GetInt32(2), // ViTri
                        sqlDataReader.GetDateTime(5), // ThoiGian   
                        sqlDataReader.GetInt32(6) ,// MaNVTT
                        maKH // MaKH
                    );

                    danhSachBanDat.Add(banDat);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
            }

            return danhSachBanDat;
        }
        public bool LayTrangThaiBanDat(int maBanDat)
        {
            bool trangThai=false;
            connect.Open();
            string query = "SELECT TrangThai FROM BanDat WHERE MaBanDat = @MaBanDat";
            sqlCommand = new SqlCommand(query, connect);            
            sqlCommand.Parameters.AddWithValue("@MaBanDat", maBanDat);
            object result = sqlCommand.ExecuteScalar();
            if (result != null)
            {
                trangThai = Convert.ToBoolean(result);
            }
            connect.Close();
            return trangThai;
        }
        public bool CapNhatTrangThaiBanDat(int maBanDat)
        {
            try
            {
                connect.Open();
                // Lấy trạng thái hiện tại của bàn
                string queryTrangThaiHienTai = "SELECT trangThai FROM BanDat WHERE maBanDat = @MaBanDat";
                SqlCommand sqlCommandTrangThaiHienTai = new SqlCommand(queryTrangThaiHienTai, connect);
                sqlCommandTrangThaiHienTai.Parameters.AddWithValue("@MaBanDat", maBanDat);
                bool trangThaiHienTai = (bool)sqlCommandTrangThaiHienTai.ExecuteScalar();
                // Cập nhật trạng thái ngược lại của bàn
                bool trangThaiMoi = !trangThaiHienTai;
                // Cập nhật trạng thái mới của bàn vào cơ sở dữ liệu
                string queryCapNhatTrangThai = "UPDATE BanDat SET trangThai = @TrangThaiMoi WHERE maBanDat = @MaBanDat";
                sqlCommand = new SqlCommand(queryCapNhatTrangThai, connect);
                sqlCommand.Parameters.AddWithValue("@TrangThaiMoi", trangThaiMoi);
                sqlCommand.Parameters.AddWithValue("@MaBanDat", maBanDat);
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
        public int LaySoLuongBanDatTrongNgay()
        {
            int soLuongBanDat = 0;
            string query = "SELECT COUNT(*) FROM BanDat WHERE CAST(thoiGian AS DATE) = CAST(GETDATE() AS DATE)";
            try
            {
                connect.Open();
                sqlCommand = new SqlCommand(query, connect);
                soLuongBanDat = (int)sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connect.Close();
            }
            return soLuongBanDat;
        }

    }
}
