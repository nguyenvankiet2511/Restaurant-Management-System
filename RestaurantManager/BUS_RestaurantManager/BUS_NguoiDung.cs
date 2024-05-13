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
    public class BUS_NguoiDung
    {
        DAL_NguoiDung dal_nguoiDung= new DAL_NguoiDung();
        public DTO_NguoiDung LayThongTinNguoiDung(int nguoiDung)
        {
            return dal_nguoiDung.LayThongTinNguoiDung(nguoiDung);
        }
        public bool CapNhatThongTinNguoiDung(DTO_NguoiDung nguoiDungMoi)
        {
            return dal_nguoiDung.CapNhapThongTinNguoiDung(nguoiDungMoi);
        }
        public int ThemNguoiDung(DTO_NguoiDung nguoiDung)
        {
            return dal_nguoiDung.ThemNguoiDung(nguoiDung) ;
        }
        public DataTable LayDanhSachNhanVien()
        {
            return dal_nguoiDung.LayDanhSachNhanVien();
        }
        public bool CapNhatThongTinNhanVien(DTO_NguoiDung nguoiDung)
        {
            return dal_nguoiDung.CapNhatThongTinNhanVien(nguoiDung);
        }
        public int ThemNguoiDungMoi(DTO_NguoiDung nguoiDung)
        {
            return dal_nguoiDung.ThemNguoiDungMoi(nguoiDung);
        }
        public bool XoaNguoiDung(int maNguoiDung)
        {
            return dal_nguoiDung.XoaNguoiDung(maNguoiDung);
        }
    }
}
