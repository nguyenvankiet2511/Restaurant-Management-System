using DAL_RestaurantManager;
using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_RestaurantManager
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dal_nhanVien = new DAL_NhanVien();
        public BUS_NhanVien() { }
        public bool CapNhatNhanVienTiepTan(DTO_NhanVienTiepTan nhanVienTiepTan)
        {
            return dal_nhanVien.CapNhatNhanVienTiepTan(nhanVienTiepTan);
        }
        public bool CapNhatNhanVienSale(DTO_NhanVienSale nhanVienSale)
        {
            return dal_nhanVien.CapNhatNhanVienSale(nhanVienSale);
        }
        public bool CapNhatNhanVienThuNgan(DTO_NhanVienThuNgan nhanVienThuNgan)
        {
            return dal_nhanVien.CapNhatNhanVienThuNgan(nhanVienThuNgan);
        }
        public bool ThemNhanVienTiepTan(DTO_NhanVienTiepTan nhanVienTT)
        {
            return dal_nhanVien.ThemNhanVienTiepTan(nhanVienTT);
        }
        public bool ThemNhanVienSale(DTO_NhanVienSale nhanVienSale)
        {
            return dal_nhanVien.ThemNhanVienSale(nhanVienSale);
        }
        public bool ThemNhanVienThuNgan(DTO_NhanVienThuNgan nhanVienThuNgan)
        {
            return dal_nhanVien.ThemNhanVienThuNgan(nhanVienThuNgan);
        }
        public bool XoaNhanVienTiepTan(int maNhanVien)
        {
            return dal_nhanVien.XoaNhanVienTiepTan(maNhanVien);
        }
        public bool XoaNhanVienSale(int maNhanVien)
        {
            return dal_nhanVien.XoaNhanVienSale(maNhanVien);
        }
        public bool XoaNhanVienThuNgan(int maNhanVien)
        {
            return dal_nhanVien.XoaNhanVienThuNgan(maNhanVien);
        }
    }
}
