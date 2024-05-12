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
                nguoiDung = new DTO_NguoiDung(sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetString(3), sqlDataReader.GetString(5));
            }
            connect.Close();
            return nguoiDung;
        }
    }
}
