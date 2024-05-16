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
        public bool ThemMonAn(DTO_MonAn monAn)
        {
            connect.Open();
            string query = "INSERT INTO MonAn (tenMon, moTa, giaMon) VALUES (@TenMon, @MoTa, @GiaMon)";
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@TenMon", monAn.tenMon);
            sqlCommand.Parameters.AddWithValue("@MoTa", monAn.moTa);
            sqlCommand.Parameters.AddWithValue("@GiaMon", monAn.giaMon);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                connect.Close();
                return true;
            }
            connect.Close();
            return false;
        }
        public bool CapNhatMonAn(DTO_MonAn monAn)
        {
            connect.Open();
            string query = "UPDATE MonAn SET tenMon = @TenMon, moTa = @MoTa, giaMon = @GiaMon WHERE maMonAn = @MaMonAn";
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@TenMon", monAn.tenMon);
            sqlCommand.Parameters.AddWithValue("@MoTa", monAn.moTa);
            sqlCommand.Parameters.AddWithValue("@GiaMon", monAn.giaMon);
            sqlCommand.Parameters.AddWithValue("@MaMonAn", monAn.maMonAn);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                connect.Close();
                return true;
            }
            connect.Close();
            return false;
        }
        public bool XoaMonAn(int maMonAn)
        {
            connect.Open();
            string query = "DELETE FROM MonAn WHERE maMonAn = @MaMonAn";
            sqlCommand = new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@MaMonAn", maMonAn);
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                connect.Close();
                return true;
            }
            connect.Close();
            return false;
        }
        public bool KiemTraMonAn( string tenMon)
        {
            connect.Open();
            string query = "SELECT COUNT(*) FROM MonAn WHERE LOWER(REPLACE(tenMon, ' ', '')) = @TenMon";
            sqlCommand = new SqlCommand(query, connect); 
            sqlCommand.Parameters.AddWithValue("@TenMon", tenMon.Trim().ToLower().Replace(" ", "")); // Loại bỏ khoảng trắng và chuyển về chữ thường
            int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
            connect.Close();
            return count > 0;
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
        public DTO_MonAn LayGiaMonAn(int maMonAn)
        {
            DTO_MonAn monAn = new DTO_MonAn();
            connect.Open();
            string query = "SELECT tenMon,giaMon FROM MonAn WHERE maMonAn=@maMonAn";
            sqlCommand= new SqlCommand(query, connect);
            sqlCommand.Parameters.AddWithValue("@maMonAn", maMonAn);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                monAn.tenMon = sqlDataReader.GetString(0);
                monAn.giaMon= sqlDataReader.GetInt32(1);
            }
            connect.Close();
            return monAn;
        }
    }
}
