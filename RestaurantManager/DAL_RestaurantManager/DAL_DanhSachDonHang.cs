using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_RestaurantManager
{
    public class DAL_DanhSachDonHang : DBConnect
    {
        public DAL_DanhSachDonHang() { }
        public bool ThemDonHangDat(DTO_DanhSachDonHang donHang)
        {
            connect.Open();
            string query = "INSERT INTO DanhSachDonHang ( tenMon, soLuong, maMonAn, maKH) " +
                            "VALUES ( @TenMon, @SoLuong, @MaMonAn, @MaKH)";
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@TenMon", donHang.tenMon);
            sqlCommand.Parameters.AddWithValue("@SoLuong", donHang.soLuong);
            sqlCommand.Parameters.AddWithValue("@MaMonAn", donHang.maMonAn);
            sqlCommand.Parameters.AddWithValue("@MaKH", donHang.maKH);
            int result = sqlCommand.ExecuteNonQuery();
            connect.Close();
            return result > 0;

        }
        public List<DTO_DanhSachDonHang> LayDanhSachDonDat(int maKH)
        {
            List<DTO_DanhSachDonHang> danhSachDonHang = new List<DTO_DanhSachDonHang>();
            try
            {
                connect.Open();
                string query = "SELECT maDSDH, ngayDat, tenMon, soLuong, maMonAn, maKH FROM DanhSachDonHang WHERE maKH = @MaKH";
                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@MaKH", maKH);
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    danhSachDonHang.Add(new DTO_DanhSachDonHang(
                         sqlDataReader.GetInt32(0),
                         sqlDataReader.GetDateTime(1),
                         sqlDataReader.GetString(2),
                         sqlDataReader.GetInt32(3),
                         sqlDataReader.GetInt32(4),
                         sqlDataReader.GetInt32(5))
                        );
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connect.Close();
            }

            return danhSachDonHang;
        }
        public bool XoaDonHangDat(int maDSDH)
        {
            try
            {
                connect.Open();
                string query = "DELETE FROM DanhSachDonHang WHERE maDSDH = @MaDSDH";
                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@MaDSDH", maDSDH);
                int result = sqlCommand.ExecuteNonQuery();
                return result > 0;
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
        public bool CapNhatDonHangDat(DTO_DanhSachDonHang donHang)
        {
            try
            {
                connect.Open();
                string updateQuery = "UPDATE DanhSachDonHang SET  tenMon = @TenMon, soLuong = @SoLuong, maMonAn = @MaMonAn WHERE maDSDH = @MaDSDH";
                sqlCommand = new SqlCommand(updateQuery, connect);
                sqlCommand.Parameters.AddWithValue("@TenMon", donHang.tenMon);
                sqlCommand.Parameters.AddWithValue("@SoLuong", donHang.soLuong);
                sqlCommand.Parameters.AddWithValue("@MaMonAn", donHang.maMonAn);
                sqlCommand.Parameters.AddWithValue("@MaDSDH", donHang.maDSDH);
                int result = sqlCommand.ExecuteNonQuery();
                connect.Close();
                return result > 0;
            }
            catch(Exception ex) { }
            finally
            {
                connect.Close();
            }
            return false;
        }
    }
}

