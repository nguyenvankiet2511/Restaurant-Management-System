using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_RestaurantManager
{
    public class DTO_Ban
    {
        public int maBan { get; set; }
        public string tenBan {  get; set; }    
        public bool trangThai {  get; set; }

        public DTO_Ban() { }
        public DTO_Ban(string tenBan, bool trangThai)
        {
            this.tenBan = tenBan;
            this.trangThai = trangThai;
        }
        public DTO_Ban(int maBan, string tenBan, bool trangThai)
        {
            this.maBan = maBan;
            this.tenBan = tenBan;
            this.trangThai = trangThai;
        }
    }
}
