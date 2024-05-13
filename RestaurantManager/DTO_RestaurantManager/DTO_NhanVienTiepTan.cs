using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_NhanVienTiepTan
    {
        public int maNVTT { get; set; }
        public string bangCap { get; set; }
        public int chucVu { get; set; }

        // Constructor không tham số
        public DTO_NhanVienTiepTan()
        {
        }

        // Constructor với tham số
        public DTO_NhanVienTiepTan(int maNVTT, string bangCap)
        {
            this.maNVTT = maNVTT;
            this.bangCap = bangCap;
        }
    }
}
