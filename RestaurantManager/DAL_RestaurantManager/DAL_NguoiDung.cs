using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
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
            int maKH = -1; // Default value if no identity value is returned
            connect.Open();
            string queryNguoiDung = "INSERT INTO NguoiDung (ten_nguoi_dung, email, soDienThoai) VALUES (@Ten, @Email, @SoDienThoai); SELECT @@IDENTITY;";
            sqlCommand = new SqlCommand(queryNguoiDung, connect);
            sqlCommand.Parameters.AddWithValue("@Ten", nguoiDung.tenNguoiDung);
            sqlCommand.Parameters.AddWithValue("@Email", nguoiDung.email);
            sqlCommand.Parameters.AddWithValue("@SoDienThoai", nguoiDung.soDienThoai);
            object result = sqlCommand.ExecuteScalar(); // ExecuteScalar for retrieving single value
            if (result != DBNull.Value)
            {
                maKH = Convert.ToInt32(result); // Convert to integer
            }
            connect.Close(); // Ensure connection is closed after query execution
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

    }
}
