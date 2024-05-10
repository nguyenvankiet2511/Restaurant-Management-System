using DAL_RestaurantManager;
using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_RestaurantManager
{
    public class BUS_DangKyBanDat
    {
        DAL_DangKyBanDat dal_banDat= new DAL_DangKyBanDat();
        public BUS_DangKyBanDat() { }
        public bool themDKBanDat(DTO_DangKyBanDat bandat)
        {
           return dal_banDat.ThemDatBan(bandat);
        }
    }
}
