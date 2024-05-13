using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_RestaurantManager
{
    public class DAL_ThucDon:DBConnect
    {
       public DAL_ThucDon() { }
        public void ThemThucDon( DTO_ThucDon thucDon)
        {
            connect.Open();
            string query = "INSERT INTO ThucDon (tenMon, soLuong, maMonAn, maBanDat) VALUES (@tenMon, @soLuong, @maMonAn, @maBanDat)";
            sqlCommand = new SqlCommand(query, connect);  
            sqlCommand.Parameters.AddWithValue("@tenMon", thucDon.tenMon);
            sqlCommand.Parameters.AddWithValue("@soLuong", thucDon.soLuong);
            sqlCommand.Parameters.AddWithValue("@maMonAn", thucDon.maMonAn);
            sqlCommand.Parameters.AddWithValue("@maBanDat", thucDon.maBanDat);
            sqlCommand.ExecuteNonQuery();
            connect.Close();
        }
    }
}
