using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_QuanTriVien
    {
        public int maQTV { get; set; }

        // Constructor không tham số
        public DTO_QuanTriVien()
        {
        }

        // Constructor với tham số
        public DTO_QuanTriVien(int maQTV)
        {
            this.maQTV = maQTV;
        }
    }
}
