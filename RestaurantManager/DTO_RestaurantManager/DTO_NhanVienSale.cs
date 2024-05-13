using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_NhanVienSale
    {
        public int maNVSale { get; set; }
        public string bangCap { get; set; }
        public int chucVu {  get; set; }

        // Constructor không tham số
        public DTO_NhanVienSale()
        {
        }

        // Constructor với tham số
        public DTO_NhanVienSale(int maNVSale, string bangCap)
        {
            this.maNVSale = maNVSale;
            this.bangCap = bangCap;
        }
        public DTO_NhanVienSale(int maNVSale, string bangCap, int chucVu)
        {
            this.maNVSale = maNVSale;
            this.bangCap = bangCap;
            this.chucVu = chucVu;
        }

    }
}
