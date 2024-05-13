using DAL_RestaurantManager;
using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_RestaurantManager
{
    public class BUS_ThucDon
    {
        DAL_ThucDon dal_thucDon= new DAL_ThucDon();
        public BUS_ThucDon() { }
        public void ThemThucDon(DTO_ThucDon thucDon)
        {
            dal_thucDon.ThemThucDon(thucDon);
        }
      
    }
}
