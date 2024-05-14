using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_RestaurantManager
{
    public class DAL_QuyDinh: DBConnect
    {
        public DAL_QuyDinh() { }
        public int LayGiaTriQuyDinh(int maQD)
        {
            int quyDinh = new int();
            connect.Open();
            string query = "SELECT maQuyDinh, tenQuyDinh, giaTri FROM QuyDinh WHERE maQuyDinh = @maQD";
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@maQD", maQD);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                quyDinh= sqlDataReader.GetInt32(2);
            }
            connect.Close();
            return quyDinh;   
        }
    }
}
