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
    public class BUS_DanhSachDonHang
    {
        DAL_DanhSachDonHang dal_dsdh= new DAL_DanhSachDonHang();
        public BUS_DanhSachDonHang() { }
        public List<DTO_DanhSachDonHang> LayDanhSachDonHangDat( int maKH)
        {
            return dal_dsdh.LayDanhSachDonDat(maKH);
        }
        public bool ThemDonHangDat(DTO_DanhSachDonHang donHang)
        {
            return dal_dsdh.ThemDonHangDat(donHang);
        }
        public bool XoaDonHangDat(int maDSDH)
        {
            return dal_dsdh.XoaDonHangDat(maDSDH);
        }
        public bool CapNhatDonHang(DTO_DanhSachDonHang donHang)
        {
            return dal_dsdh.CapNhatDonHangDat(donHang);
        }
        public DataTable GetAllDanhSachDonHang()
        {
            return dal_dsdh.GetAllDanhSachDonHangList();
        }
        public bool XoaDonHang(int maDSDH)
        {
            return dal_dsdh.XoaDonHang(maDSDH);
        }
    }
}
