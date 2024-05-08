using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_RestaurantManager
{
    public class DBConnect
    {
        protected SqlConnection connect = new SqlConnection("Data Source = SQL2022;Initial Catalog=QuanLyNhaHang; Intergrated Security =True");
    }
}
