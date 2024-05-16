using DAL_RestaurantManager;
using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_RestaurantManager
{
    public class BUS_DonHang
    {
        DAL_DonHang dal_donHang = new DAL_DonHang();
        public bool ThemDonHang(DTO_DonHang donHang)
        {
            return dal_donHang.ThemDonHang(donHang);
        }
        public DataTable LayDanhSachDonHang()
        {
            return dal_donHang.LayDanhSachDonHang();
        }
        public bool XoaDonHang(int maDonHang)
        {
            return dal_donHang.XoaDonHang(maDonHang);
        }
        public bool CapNhatDonHang(DTO_DonHang donHang)
        {
            return dal_donHang.CapNhatDonHang(donHang);
        }
    }
}
