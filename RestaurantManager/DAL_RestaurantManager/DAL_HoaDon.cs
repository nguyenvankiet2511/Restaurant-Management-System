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
    public class DAL_HoaDon:DBConnect
    {
      public  DAL_HoaDon() { }
        public bool ThemHoaDon(DTO_HoaDon hoaDon)
        {

            connect.Open();
            string query = "INSERT INTO HoaDon(thanhTien, maNVTN,maBanDat) VALUES (@thanhTien, @maNVTN,@maBanDat)";
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@thanhTien", hoaDon.thanhTien);
            sqlCommand.Parameters.AddWithValue("@maNVTN", hoaDon.maNVTN);
            sqlCommand.Parameters.AddWithValue("@maBanDat", hoaDon.maBanDat);
            int result = sqlCommand.ExecuteNonQuery();
            connect.Close();
            return result > 0;
        }
        public DataTable LayDanhSachHoaDon()
        {
            string query = @"SELECT * FROM HoaDon";
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            DataTable danhSachHoaDon = new DataTable();
            adapter.Fill(danhSachHoaDon);
            connect.Close();
            return danhSachHoaDon;
        }
        public bool ThemHoaDonDonHang(DTO_HoaDonDonHang hoaDon)
        {
            connect.Open();
            string query = "INSERT INTO HoaDonDonHang(tenMon, giaMon, soLuong, thanhTien, maDonHang) VALUES (@tenMon, @giaMon, @soLuong, @thanhTien, @maDonHang)";
            SqlCommand sqlCommand = new SqlCommand(query, connect);

            sqlCommand.Parameters.AddWithValue("@tenMon", hoaDon.tenMon);
            sqlCommand.Parameters.AddWithValue("@giaMon", hoaDon.giaMon);
            sqlCommand.Parameters.AddWithValue("@soLuong", hoaDon.soLuong);
            sqlCommand.Parameters.AddWithValue("@thanhTien", hoaDon.thanhTien);
            sqlCommand.Parameters.AddWithValue("@maDonHang", hoaDon.maDonHang);

            int result = sqlCommand.ExecuteNonQuery();
            connect.Close();
            return result > 0;
        }
        public DataTable LayDoanhThuTheoThang(int nam)
        {
            string query = @"
                            WITH Months AS (
                        SELECT 1 AS Month
                        UNION ALL SELECT 2
                        UNION ALL SELECT 3
                        UNION ALL SELECT 4
                        UNION ALL SELECT 5
                        UNION ALL SELECT 6
                        UNION ALL SELECT 7
                        UNION ALL SELECT 8
                        UNION ALL SELECT 9
                        UNION ALL SELECT 10
                        UNION ALL SELECT 11
                        UNION ALL SELECT 12
                    )
                    SELECT 
                        m.Month, 
                        COALESCE(SUM(c.thanhTien), 0) AS Revenue
                    FROM 
                        Months m
                    LEFT JOIN 
                        (
                            SELECT MONTH(ngayLap) AS Month, thanhTien
                            FROM HoaDon
                            WHERE YEAR(ngayLap) = @Year
                            UNION ALL
                            SELECT MONTH(ngayLap) AS Month, thanhTien
                            FROM HoaDonDonHang
                            WHERE YEAR(ngayLap) = @Year
                        ) AS c
                    ON m.Month = c.Month
                    GROUP BY 
                        m.Month
                    ORDER BY 
                        m.Month;";
            connect.Open();
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@Year", nam);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable doanhThuTheoThang = new DataTable();
            adapter.Fill(doanhThuTheoThang);
            connect.Close();
            return doanhThuTheoThang;      
        }
        public DataTable LaySoLuongKhachTheoThang(int nam)
        {
            string query = @"
                            WITH Months AS (
                                SELECT 1 AS Month
                                UNION ALL SELECT 2
                                UNION ALL SELECT 3
                                UNION ALL SELECT 4
                                UNION ALL SELECT 5
                                UNION ALL SELECT 6
                                UNION ALL SELECT 7
                                UNION ALL SELECT 8
                                UNION ALL SELECT 9
                                UNION ALL SELECT 10
                                UNION ALL SELECT 11
                                UNION ALL SELECT 12
                            )
                            SELECT 
                                m.Month, 
                                COALESCE(COUNT(h.maHoaDon), 0) AS NumberOfCustomers
                            FROM 
                                Months m
                            LEFT JOIN 
                                (
                                    SELECT MONTH(ngayLap) AS Month, YEAR(ngayLap) AS Year, maHoaDon
                                    FROM HoaDon
                                    WHERE YEAR(ngayLap) = @Year
                                ) AS h
                            ON m.Month = h.Month
                            GROUP BY 
                                m.Month
                            ORDER BY 
                                m.Month;";
            connect.Open();
            sqlCommand =new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@Year", nam);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable soLuongKhachTheoThang = new DataTable();        
            adapter.Fill(soLuongKhachTheoThang);
            connect.Close();
            return soLuongKhachTheoThang;

        }
        public DataTable LayDoanhThuDonHang(int nam)
        {
            string query = @"	        
                WITH Months AS (
                SELECT 1 AS Month
                UNION ALL SELECT 2
                UNION ALL SELECT 3
                UNION ALL SELECT 4
                UNION ALL SELECT 5
                UNION ALL SELECT 6
                UNION ALL SELECT 7
                UNION ALL SELECT 8
                UNION ALL SELECT 9
                UNION ALL SELECT 10
                UNION ALL SELECT 11
                UNION ALL SELECT 12
            )
            SELECT 
                m.Month, 
                COALESCE(SUM(c.thanhTien), 0) AS Revenue
            FROM 
                Months m
            LEFT JOIN 
                (
                    SELECT MONTH(ngayLap) AS Month, thanhTien
                    FROM HoaDonDonHang
                    WHERE YEAR(ngayLap) = @Year
                ) AS c
            ON m.Month = c.Month
            GROUP BY 
                m.Month
            ORDER BY 
                m.Month;
                        ";
            connect.Open();
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@Year", nam);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable doanhThuDonHang = new DataTable();
            adapter.Fill(doanhThuDonHang);
            connect.Close();
            return doanhThuDonHang;
        }
        public int DoanhThuDonHangTrongNgay()
        {
            int doanhThu = 0;
            string query = @"
                SELECT 
                    COALESCE(SUM(thanhTien), 0) AS Revenue
                FROM 
                    HoaDonDonHang
                WHERE 
                    CAST(ngayLap AS DATE) = CAST(GETDATE() AS DATE)";

            try
            {
                connect.Open();
                sqlCommand = new SqlCommand(query, connect);
                object result = sqlCommand.ExecuteScalar();
                if (result != null)
                {
                    doanhThu = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connect.Close();
            }

            return doanhThu;
        }
        public DataTable LayThongTinHoaDonDonHangTrongNgay()
        {
            DataTable hoaDonTable = new DataTable();
            string query = @"
                SELECT *
                FROM HoaDonDonHang
                WHERE CAST(ngayLap AS DATE) = CAST(GETDATE() AS DATE)";

            try
            {
                connect.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(hoaDonTable);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connect.Close();
            }
            return hoaDonTable;
        }


        public int LayDoanhThuTheoNgay()
        {
            int doanhThu = 0;
            string query = @"
                SELECT 
                    COALESCE(SUM(c.thanhTien), 0) AS Revenue
                FROM 
                    (
                        SELECT CAST(ngayLap AS DATE) AS [Date], thanhTien
                        FROM HoaDon
                        WHERE CAST(ngayLap AS DATE) = CAST(GETDATE() AS DATE)
                        UNION ALL
                        SELECT CAST(ngayLap AS DATE) AS [Date], thanhTien
                        FROM HoaDonDonHang
                        WHERE CAST(ngayLap AS DATE) = CAST(GETDATE() AS DATE)
                    ) AS c;";
            try
            {
                connect.Open();
                sqlCommand = new SqlCommand(query, connect);
                object result = sqlCommand.ExecuteScalar();
                if (result != null)
                {
                    doanhThu = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connect.Close();
            }

            return doanhThu;
        }

    }
}
