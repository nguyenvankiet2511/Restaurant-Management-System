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
        public DataTable LayDanhSachQuyDinh()
        {
            string query = "SELECT * FROM QuyDinh";
           
            connect.Open();
            sqlCommand = new SqlCommand(query, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dsQuyDinh= new DataTable();
            adapter.Fill(dsQuyDinh);
            connect.Close();
            return dsQuyDinh;
        }
        public bool ThemQuyDinh(DTO_QuyDinh quyDinh)
        {
            try
            {
                connect.Open();
                string query = "INSERT INTO QuyDinh (tenQuyDinh, giaTri) VALUES (@tenQuyDinh, @giaTri)";
                sqlCommand = new SqlCommand(query, connect);               
                sqlCommand.Parameters.AddWithValue("@tenQuyDinh", quyDinh.tenQuyDinh);
                sqlCommand.Parameters.AddWithValue("@giaTri", quyDinh.giaTri);
                int result = sqlCommand.ExecuteNonQuery();
                return result > 0;                
            }
            finally
            {
                connect.Close();
            }
        }

        public bool SuaQuyDinh(DTO_QuyDinh quyDinh)
        {
            try
            {
                connect.Open();
                string query = "UPDATE QuyDinh SET tenQuyDinh = @tenQuyDinh, giaTri = @giaTri WHERE maQuyDinh = @maQuyDinh";
                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@maQuyDinh", quyDinh.maQuyDinh);
                sqlCommand.Parameters.AddWithValue("@tenQuyDinh", quyDinh.tenQuyDinh);
                sqlCommand.Parameters.AddWithValue("@giaTri", quyDinh.giaTri);
                int result = sqlCommand.ExecuteNonQuery();
                return result > 0;       
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
