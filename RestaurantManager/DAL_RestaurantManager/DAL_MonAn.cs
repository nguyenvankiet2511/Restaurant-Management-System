using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL_RestaurantManager
{
    public class DAL_MonAn: DBConnect
    {
        public DAL_MonAn() { }
        public List<DTO_MonAn> getListMonAn()
        {
            List<DTO_MonAn> listMonAn = new List<DTO_MonAn>();
            try
            {
                connect.Open();
                string query = "SELECT * FROM MonAn";
                sqlCommand = new SqlCommand(query, connect);
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    // Thử bắt lỗi ở đây                   
                        // Thêm dữ liệu vào danh sách
                        listMonAn.Add(new DTO_MonAn(
                            sqlDataReader.GetInt32(0),
                            sqlDataReader.GetString(1),
                            sqlDataReader.GetString(2),
                            sqlDataReader.GetInt32(3)
                        ));           
                }
            }
            catch (Exception ex) { }
            finally
            {
                connect.Close();
            }
            return listMonAn;
        }
        public List<DTO_MonAn> TimKiemMonAn(string key)
        {
            List<DTO_MonAn> danhSachTimKiem = new List<DTO_MonAn>();
            try
            {
                connect.Open();
                string query = "SELECT * FROM MonAn WHERE tenMon LIKE @Key ";
                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@Key", "%" + key + "%");
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    // Thêm dữ liệu vào danh sách
                    danhSachTimKiem.Add(new DTO_MonAn(
                        sqlDataReader.GetInt32(0),
                        sqlDataReader.GetString(1),
                        sqlDataReader.GetString(2),
                        sqlDataReader.GetInt32(3)
                    ));
                }
            }
            catch (Exception ex) { }
            finally
            {
                connect.Close();
            }
            return danhSachTimKiem;
        }
    }
}
