using DAL_RestaurantManager;
using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_RestaurantManager
{
    public class BUS_DangNhap
    {
        public BUS_DangNhap() { }

        DAL_TaiKhoan dal_TaiKhoan = new DAL_TaiKhoan();
        public DTO_TaiKhoan KiemTraTaiKhoan(string username, string password)
        {
            string query = "SELECT * FROM TaiKhoan WHERE username ='" + username + "' AND password ='" + password + "'";
            return dal_TaiKhoan.KiemTraTaiKhoan(query);             
        }  
    }
}
