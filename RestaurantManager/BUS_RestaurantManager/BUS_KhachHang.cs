using DAL_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_RestaurantManager
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dal_khachHang= new DAL_KhachHang();
        public BUS_KhachHang() { }
        public bool ThemKhachHang(int maNguoiDung)
        {
            return dal_khachHang.ThemKhachHang(maNguoiDung);
        }
    }
}
