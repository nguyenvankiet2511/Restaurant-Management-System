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
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        public DTO_TaiKhoan KiemTraTaiKhoan( string query)
        {
           DTO_TaiKhoan taiKhoan = new DTO_TaiKhoan();
            connect.Open();
            sqlCommand= new SqlCommand(query,connect);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
               taiKhoan= new DTO_TaiKhoan(sqlDataReader.GetString(2),sqlDataReader.GetString(3), sqlDataReader.GetInt32(5));
            }
            connect.Close();
            return taiKhoan;
        }
    }
}
