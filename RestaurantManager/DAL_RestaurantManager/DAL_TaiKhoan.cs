using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_RestaurantManager;

namespace DAL_RestaurantManager
{
    public class DAL_TaiKhoan:DBConnect
    {
        public DAL_TaiKhoan() { }
      
        public DTO_TaiKhoan KiemTraTaiKhoan( string query)
        {
           DTO_TaiKhoan taiKhoan = new DTO_TaiKhoan();
            connect.Open();
            sqlCommand= new SqlCommand(query,connect);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
               taiKhoan= new DTO_TaiKhoan(sqlDataReader.GetString(2),sqlDataReader.GetString(3), sqlDataReader.GetInt32(5), sqlDataReader.GetInt32(6));
            }
            connect.Close();
            return taiKhoan;
        }
        public bool ThemTaiKhoan(DTO_TaiKhoan taiKhoan)
        {
            connect.Open();
            string query = "INSERT INTO TaiKhoan (tenTaiKhoan, username, password,loaiTaiKhoan,nguoiDung_id) VALUES (@tenTaiKhoan, @username, @password,5,@nguoiDungId)";
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@tenTaiKhoan", taiKhoan.tenTaiKhoan);
            sqlCommand.Parameters.AddWithValue("@username", taiKhoan.username);
            sqlCommand.Parameters.AddWithValue("@password", taiKhoan.password);
            sqlCommand.Parameters.AddWithValue("@nguoiDungId", taiKhoan.nguoiDungId);
            int result = sqlCommand.ExecuteNonQuery();
            return result > 0;
        }
        public bool UpdatePassword(DTO_TaiKhoan taiKhoan)
        {
            connect.Open();
            string query = "UPDATE TaiKhoan set password=@password where username=@username";
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@username", taiKhoan.username);
            sqlCommand.Parameters.AddWithValue("@password", taiKhoan.password);
            int count = sqlCommand.ExecuteNonQuery();
            return count > 0;
        }
    }
}
