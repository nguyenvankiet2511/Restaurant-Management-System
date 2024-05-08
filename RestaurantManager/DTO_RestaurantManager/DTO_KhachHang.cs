using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_KhachHang
    {
        public int maKH { get; set; }
        public string loaiKH { get; set; }

        // Constructor không tham số
        public DTO_KhachHang()
        {
        }

        // Constructor với tham số
        public DTO_KhachHang(int maKH, string loaiKH)
        {
            this.maKH = maKH;
            this.loaiKH = loaiKH;
        }
    }
}
