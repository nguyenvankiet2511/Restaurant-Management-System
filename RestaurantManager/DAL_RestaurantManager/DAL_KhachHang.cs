using System;
using System.Collections.Generic;
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
    }
}
