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
        public bool themBanDat(DTO_BanDat banDat)
        {  
          return  dal_banDat.ThemBanDat(banDat);
        }
        public DTO_BanDat LayThongTinBan(int maBan)
        {
            return dal_banDat.LayThongTinBan(maBan);
        }
    }
}
