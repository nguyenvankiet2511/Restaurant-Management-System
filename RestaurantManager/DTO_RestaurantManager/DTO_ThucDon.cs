using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_ThucDon
    {
        public int maThucDon { get; set; }
        public string tenMon { get; set; }
        public int soLuong { get; set; }
        public string ghiChu { get; set; }
        public int maMonAn { get; set; }

        // Constructor không tham số
        public DTO_ThucDon()
        {
        }

        // Constructor với tham số
        public DTO_ThucDon(int maThucDon, string tenMon, int soLuong, string ghiChu, int maMonAn)
        {
            this.maThucDon = maThucDon;
            this.tenMon = tenMon;
            this.soLuong = soLuong;
            this.ghiChu = ghiChu;
            this.maMonAn = maMonAn;
        }

    }
}
