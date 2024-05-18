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
    public class BUS_QuyDinh
    {
        DAL_QuyDinh dal_quyDinh= new DAL_QuyDinh();
        public BUS_QuyDinh() { }
        public int LayGiaTriQuyDinh(int maQD)
        {
            return dal_quyDinh.LayGiaTriQuyDinh(maQD);
        }
        public DataTable LayDanhSachQuyDinh()
        {
            return dal_quyDinh.LayDanhSachQuyDinh();
        }
        public bool ThemQuyDinh(DTO_QuyDinh quyDinh)
        {
            return dal_quyDinh.ThemQuyDinh(quyDinh);
        }
        public bool SuaQuyDinh(DTO_QuyDinh quyDinh)
        {
            return dal_quyDinh.SuaQuyDinh(quyDinh);
        }
    }
}
