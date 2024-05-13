using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_NhanVienThuNgan
    {
        public int maNVTN { get; set; }
        public string bangCap { get; set; }
        public int chucVu { get; set; }

        // Constructor không tham số
        public DTO_NhanVienThuNgan()
        {
        }

        // Constructor với tham số
        public DTO_NhanVienThuNgan(int maNVTN, string bangCap)
        {
            this.maNVTN = maNVTN;
            this.bangCap = bangCap;
        }
    }
}
