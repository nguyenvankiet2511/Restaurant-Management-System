using DTO_RestaurantManager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_RestaurantManager
{
    public class DAL_Ban:DBConnect
    {
        public DAL_Ban() { }
        public List<DTO_Ban> getListBan()
        {
            List<DTO_Ban> listBan = new List<DTO_Ban>();
            connect.Open();
            string query = "SELECT * FROM Ban";
            sqlCommand = new SqlCommand(query, connect);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                listBan.Add (new DTO_Ban(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetBoolean(2)));
            }
            connect.Close();
            return listBan;
        }
        public bool CapNhatTrangThaiBan(int maBan)
        {
            try
            {
                connect.Open();
                // Lấy trạng thái hiện tại của bàn
                string queryTrangThaiHienTai = "SELECT trangThai FROM Ban WHERE maBan = @MaBan";
                SqlCommand sqlCommandTrangThaiHienTai = new SqlCommand(queryTrangThaiHienTai, connect);
                sqlCommandTrangThaiHienTai.Parameters.AddWithValue("@MaBan", maBan);
                bool trangThaiHienTai = (bool)sqlCommandTrangThaiHienTai.ExecuteScalar();
                // Cập nhật trạng thái ngược lại của bàn
                bool trangThaiMoi = !trangThaiHienTai;
                // Cập nhật trạng thái mới của bàn vào cơ sở dữ liệu
                string queryCapNhatTrangThai = "UPDATE Ban SET trangThai = @TrangThaiMoi WHERE maBan = @MaBan";
                sqlCommand = new SqlCommand(queryCapNhatTrangThai, connect);
                sqlCommand.Parameters.AddWithValue("@TrangThaiMoi", trangThaiMoi);
                sqlCommand.Parameters.AddWithValue("@MaBan", maBan);
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
