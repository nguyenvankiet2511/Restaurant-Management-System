using DAL_RestaurantManager;
using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_RestaurantManager
{
    public class BUS_BanDat
    {
        DAL_BanDat dal_banDat = new DAL_BanDat();
        public BUS_BanDat() { }
        public bool ThemBanDat(DTO_BanDat banDat)
        {  
          return  dal_banDat.ThemBanDat(banDat);
        }
        public bool ThemBanDat_KHMoi(DTO_BanDat banDat, int maKH)
        {
            return dal_banDat.ThemBanDat_KHMoi(banDat, maKH);
        }
        public DTO_BanDat LayThongTinBan(int maBan)
        {
            return dal_banDat.LayThongTinBan(maBan);
        }
        public bool CapNhatThongTinBan(DTO_BanDat banDatMoi) 
        {
            return dal_banDat.CapNhatThongTinBan(banDatMoi);
        }
        public bool XoaBanDat(int maBanDat)
        {
            return dal_banDat.XoaBanDat(maBanDat);
        }

    }
}
