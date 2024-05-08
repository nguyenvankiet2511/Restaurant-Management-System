using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_ThoiGian
    {
        public int idThoiGian { get; set; }
        public DateTime ngayDat { get; set; }
        public DateTime ngayDen { get; set; }
        public TimeSpan gioDen { get; set; }

        // Constructor không tham số
        public DTO_ThoiGian()
        {
            // Khởi tạo ngày đặt là ngày hiện tại
            this.ngayDat = DateTime.Now.Date;
        }

        // Constructor với tham số
        public DTO_ThoiGian(int idThoiGian, DateTime ngayDat, DateTime ngayDen, TimeSpan gioDen)
        {
            this.idThoiGian = idThoiGian;
            this.ngayDat = ngayDat;
            this.ngayDen = ngayDen;
            this.gioDen = gioDen;
        }
    }
}
