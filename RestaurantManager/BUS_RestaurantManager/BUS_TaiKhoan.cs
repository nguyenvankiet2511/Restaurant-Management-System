using DAL_RestaurantManager;
using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_RestaurantManager
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dal_taiKhoan= new DAL_TaiKhoan();
        public BUS_TaiKhoan() { }
        public bool ThemTaiKhoan(DTO_TaiKhoan taiKhoan)
        {
            return dal_taiKhoan.ThemTaiKhoan(taiKhoan);
        }
    }
}
