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
    public class BUS_ThucDon
    {
        DAL_ThucDon dal_thucDon= new DAL_ThucDon();
        public BUS_ThucDon() { }
        public bool ThemThucDon(DTO_ThucDon thucDon)
        {
          return  dal_thucDon.ThemThucDon(thucDon);
        }
        public DataTable GetThucDonList(int maBanDat)
        {
            return dal_thucDon.GetThucDonList(maBanDat);
        }
      
    }
}
