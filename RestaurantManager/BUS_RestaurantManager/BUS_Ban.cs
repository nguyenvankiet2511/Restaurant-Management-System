using DAL_RestaurantManager;
using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_RestaurantManager
{
    public class BUS_Ban
    {
        DAL_Ban dal_ban=new DAL_Ban();
        public List<DTO_Ban> getListBan()
        {
            return dal_ban.getListBan();
        }
        public bool CapNhatTrangThaiBan(int maBan)
        {
           return dal_ban.CapNhatTrangThaiBan(maBan);
        }
    }
}
