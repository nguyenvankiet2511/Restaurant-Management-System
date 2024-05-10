﻿using DAL_RestaurantManager;
using DTO_RestaurantManager;
using System;
using System.Collections.Generic;
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
    }
}