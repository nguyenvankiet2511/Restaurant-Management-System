using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
    }
}
