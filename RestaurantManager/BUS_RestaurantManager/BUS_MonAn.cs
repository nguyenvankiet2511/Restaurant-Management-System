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
    public class BUS_MonAn
    {
       DAL_MonAn dal_monAn = new DAL_MonAn();
        public List<DTO_MonAn> getListMonAn()
        { 
            return dal_monAn.getListMonAn();
        }
        public List<DTO_MonAn> TimKiemMonAn(string key)
        {
            return dal_monAn.TimKiemMonAn(key);
        }
        public bool ThemMonAn(DTO_MonAn monAn)
        {
           return dal_monAn.ThemMonAn(monAn);
        }
        public bool CapNhatMonAn(DTO_MonAn monAn)
        {
            return dal_monAn.CapNhatMonAn(monAn) ;
        }
        public bool XoaMonAn(int maMonAn)
        {
            return dal_monAn.XoaMonAn(maMonAn) ;
        }
        public bool KiemTraMonAn( string tenMon)
        {
            return dal_monAn.KiemTraMonAn( tenMon) ;
        }
        public DTO_MonAn LayGiaMonAn(int maMonAn)
        {
            return dal_monAn.LayGiaMonAn(maMonAn);
        }
        public DataTable LayTanSuatMonAn(int thang, int nam)
        {
            return dal_monAn.LayTanSuatMonAn(thang,nam);
        }
    }
}
