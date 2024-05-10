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
       public SqlCommand sqlCommand;
        public SqlDataReader sqlDataReader;
        protected SqlConnection connect = new SqlConnection("Data Source=ADMIN\\SQL2022;Initial Catalog=QuanLyNhaHang;Integrated Security=True");

    }
}
