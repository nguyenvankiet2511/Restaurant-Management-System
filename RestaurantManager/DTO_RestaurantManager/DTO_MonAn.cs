using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_MonAn
    {
        public int maMonAn { get; set; }
        public string tenMon { get; set; }
        public string moTa { get; set; }
        public float giaMon { get; set; }

        // Constructor không tham số
        public DTO_MonAn()
        {
        }
        // Constructor với tham số
        public DTO_MonAn(int maMonAn, string tenMon, string moTa, float giaMon)
        {
            this.maMonAn = maMonAn;
            this.tenMon = tenMon;
            this.moTa = moTa;
            this.giaMon = giaMon;
        }
    }
}
