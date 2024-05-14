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
    public class DAL_ThucDon:DBConnect
    {
       public DAL_ThucDon() { }
        public bool ThemThucDon( DTO_ThucDon thucDon)
        {
            try
            {
                connect.Open();
                string query = "INSERT INTO ThucDon (tenMon, soLuong, maMonAn, maBanDat) VALUES (@tenMon, @soLuong, @maMonAn, @maBanDat)";
                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@tenMon", thucDon.tenMon);
                sqlCommand.Parameters.AddWithValue("@soLuong", thucDon.soLuong);
                sqlCommand.Parameters.AddWithValue("@maMonAn", thucDon.maMonAn);
                sqlCommand.Parameters.AddWithValue("@maBanDat", thucDon.maBanDat);
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            finally { connect.Close(); }
            
            return false;

        }
        public DataTable GetThucDonList(int maBanDat)
        {           
                connect.Open();
                string query = @"
                                SELECT 
                                    td.tenMon,
                                    td.soLuong,
                                    ma.giaMon,
                                    (td.soLuong * ma.giaMon) AS thanhTien
                                FROM 
                                    ThucDon td
                                JOIN 
                                    MonAn ma ON td.maMonAn = ma.maMonAn
                                WHERE 
                                    td.maBanDat = @maBanDat";
                sqlCommand = new SqlCommand(query, connect);
                sqlCommand.Parameters.AddWithValue("@maBanDat", maBanDat);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable thucDonList = new DataTable();
                adapter.Fill(thucDonList);
                connect.Close();
                return thucDonList;
            
        }
    }
}
